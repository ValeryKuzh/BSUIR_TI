using System;
using System.IO;
using System.Windows.Forms;

namespace ti_2tr
{
    public partial class Form1 : Form
    {
        public const int maxViewLengthD2 = 50;
        Cipher cip = new Cipher();
        Coder code = new Coder();
        byte[] data;
        byte[] key;
        public Form1()
        { 
            InitializeComponent();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblCount.Text != "31")
                MessageBox.Show("Ключ должен состоять из 31 разряда единиц и нулей");
            else
            {
                Int64 k = 0;
                for (int i = 0; i<tbInsKey.Text.Length; i++)
                    if (tbInsKey.Text[i] == '0' || tbInsKey.Text[i] == '1')
                    {
                        k = (k << 1) + (tbInsKey.Text[i] - '0');
                    }
                if(tbPlain.Text.Length <= maxViewLengthD2 * 2)
                    data = code.BinaryToBytes(tbPlain.Text);
                key = cip.Encrypt(data, k);

                SetKeyTextBox();
                SetCipherTextBox();
            }
        }
        private void SetPlainTextBox()
        {
            if (data != null)
                if (data.Length <= maxViewLengthD2 * 2)
                {
                    tbPlain.Text = code.BytesToBinary(data);
                    tbPlain.ReadOnly = true;
                }
                else
                {
                    tbPlain.ReadOnly = true;
                    byte[] tempArr1 = new byte[maxViewLengthD2];
                    byte[] tempArr2 = new byte[maxViewLengthD2];
                    Array.Copy(data, tempArr1, maxViewLengthD2);
                    Array.Copy(data, data.Length - maxViewLengthD2, tempArr2, 0, maxViewLengthD2);
                    tbPlain.Text = code.BytesToBinary(tempArr1) + "\n" + "..." + "\n" + code.BytesToBinary(tempArr2);
                }
        }

        private void SetKeyTextBox()
        {
            if (key != null)
                if (key.Length <= maxViewLengthD2 * 2)
                {
                    tbKey.Text = code.BytesToBinary(key);
                    tbKey.ReadOnly = true;
                }
                else
                {
                    tbKey.ReadOnly = true;
                    byte[] tempArr1 = new byte[maxViewLengthD2];
                    byte[] tempArr2 = new byte[maxViewLengthD2];
                    Array.Copy(key, tempArr1, maxViewLengthD2);
                    Array.Copy(key, key.Length - maxViewLengthD2, tempArr2, 0, maxViewLengthD2);
                    tbKey.Text = code.BytesToBinary(tempArr1) + "\n" + "..." + "\n" + code.BytesToBinary(tempArr2);
                }
        }
        private void SetCipherTextBox()
        {
            if (data != null)
                if (data.Length <= maxViewLengthD2 * 2)
                {
                    tbCipher.Text = code.BytesToBinary(data);
                    tbCipher.ReadOnly = true;
                }
                else
                {
                    tbCipher.ReadOnly = true;
                    byte[] tempArr1 = new byte[maxViewLengthD2];
                    byte[] tempArr2 = new byte[maxViewLengthD2];
                    Array.Copy(data, tempArr1, maxViewLengthD2);
                    Array.Copy(data, data.Length - maxViewLengthD2, tempArr2, 0, maxViewLengthD2);
                    tbCipher.Text = code.BytesToBinary(tempArr1) + "\n" + "..." + "\n" + code.BytesToBinary(tempArr2);
                }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                data = (File.ReadAllBytes(openFileDialog1.FileName));
                SetPlainTextBox();
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '0') && (e.KeyChar != '1'))
                e.Handled = true;
        }

        private void tbInsKey_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < tbInsKey.Text.Length; i++)
                if (tbInsKey.Text[i] == '0' || tbInsKey.Text[i] == '1')
                    count++;
            lblCount.Text = count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (data != null)
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, data);
                }
        }
    }
}
