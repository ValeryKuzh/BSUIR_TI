using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace timb3
{
    public partial class MainForm : Form
    {
        byte[] decrypted;
        byte[] encrypted;
        public MainForm()
        {
            InitializeComponent();
            int i = CipMath.IntPower(15, 9, 33);
            i = 0;
        }
        private void btnZashibis1_Click(object sender, EventArgs ee)
        {
            int p = (int)numP.Value, q = (int)numQ.Value, e = (int)numE.Value;
            StringBuilder sb = new StringBuilder();
            if (!CipMath.IsPrime(p))
                sb.Append("|P должно быть простым|" + "\n");
            if (!CipMath.IsPrime(q))
                sb.Append("|Q должно быть простым|" + "\n");
            int r = p * q;
            if (r <256)
                sb.Append("|P*Q должно быть больше 256|" +"\n");
            else if (r > 256*256-1)
                sb.Append("|P*Q должно быть меньше 65.535|" + "\n");

            if (sb.Length == 0)
            {
                lblRValue.Text = r.ToString();
                int fe = CipMath.FEuler(p, q);
                lblFValue.Text = fe.ToString();
                if (e >= fe)
                    sb.Append("|E должно быть меньше F(R)|" + "\n");
                else
                {
                    int[] f = CipMath.GetInverse(fe, e);
                    if (f[2] != 1)
                        sb.Append("|E и F(R) должны иметь НОД = 1|" + "\n");
                    else
                        numD.Text = f[1].ToString();
                }
            }
            else
            {
                lblRValue.Text = "Oops...";
                lblFValue.Text = "Oops...";
            }

            if (sb.Length != 0)
                MessageBox.Show(sb.ToString());
        }
        private void btnOpenEncrypt_Click(object sender, EventArgs e)
        {
            int r = (int)numP.Value * (int)numQ.Value;
            if ((r > 256) && (r < 65535) && openFileDialog.ShowDialog() == DialogResult.OK)
            {
                encrypted = File.ReadAllBytes(openFileDialog.FileName);
                txtIn.Text = Converter.BytesToStr(encrypted);
                decrypted = Cipher.Encode(encrypted, (int)numE.Value, r);
                txtOut.Text = Converter.WordsToStr(decrypted);
            }
        }
        private void btnOpenDecrypt_Click(object sender, EventArgs e)
        {
            int r = (int)numP.Value * (int)numQ.Value;
            if ((r > 256) && (r < 65535) && openFileDialog.ShowDialog() == DialogResult.OK)
            {
                encrypted = File.ReadAllBytes(openFileDialog.FileName);
                txtIn.Text = Converter.WordsToStr(encrypted);
                decrypted = Cipher.Decode(encrypted, int.Parse(numD.Text), r);
                txtOut.Text = Converter.BytesToStr(decrypted);
            }
        }
        private void btnSaveDec_Click(object sender, EventArgs e)
        {
            if (decrypted != null && saveFileDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllBytes(saveFileDialog.FileName, decrypted);
        }
    }
}
