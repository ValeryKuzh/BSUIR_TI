using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"; // Фильтр файлов
            openFileDialog.Title = "Открыть файл";
            string content = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK) // Если пользователь выбрал файл
            {
                string filePath = openFileDialog.FileName; // Получаем путь к файлу
                content = File.ReadAllText(filePath); // Читаем файл
            }
            return content;
        }

        static void SaveFile(string content)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"; // Фильтр файлов
            saveFileDialog.Title = "Сохранить файл";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) // Если пользователь выбрал место сохранения
            {
                string filePath = saveFileDialog.FileName; // Получаем путь к файлу
                File.WriteAllText(filePath, content); // Записываем данные в файл
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DecimationCipher dc = new DecimationCipher();
            string strKey = DecimationCipher.GetValidKey(textBox1.Text);
            textBox1.Text = strKey;
            int key = -1;
            string error = "";
            richTextBox1.Text = dc.getValidString(DecimationCipher.ToUpper(richTextBox1.Text));
            if (Data.IsEnglish(DecimationCipher.ToUpper(richTextBox1.Text)))
            {
                if (!string.IsNullOrEmpty(DecimationCipher.ToUpper(textBox1.Text)))
                    if (int.TryParse(textBox1.Text, out key) && key > 0)
                        richTextBox2.Text = dc.Ciphe(richTextBox1.Text, key, out error);
                    else
                        error = "Невалидный ключ";
                else
                    error = "Нет ключа";
            }
            else
                error = "Невалидная шифруемая строка (должны быть английские символы)"; 
            label4.Text = error;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DecimationCipher dc = new DecimationCipher();
            string strKey = DecimationCipher.GetValidKey(textBox1.Text);
            textBox1.Text = strKey;
            int key = -1;
            string error = "";
            richTextBox2.Text = dc.getValidString(DecimationCipher.ToUpper(richTextBox2.Text));
            if (Data.IsEnglish(DecimationCipher.ToUpper(richTextBox2.Text)))
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                    if (int.TryParse(textBox1.Text, out key) && key > 0)
                        richTextBox1.Text = dc.Deciphe(richTextBox2.Text, key, out error);
                    else
                        error = "Невалидный ключ";
                else
                    error = "Нет ключа";
            }
            else
                error = "Невалидная дешифруемая строка (должны быть английские символы)";
            label4.Text = error;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string jsonText = OpenFile();
           
            if (!string.IsNullOrEmpty(jsonText))
            {
                try 
                {
                    Data dat = JsonSerializer.Deserialize<Data>(jsonText)!;
                    tabControl1.SelectedIndex = (int)dat.cipherType;
                    richTextBox1.Text = dat.PlainText;
                    richTextBox2.Text = dat.CipherText; 
                }
                catch 
                {
                    label4.Text = "Невозможно открыть файл";
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            Cipher c = Cipher.Decimation;

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    c = Cipher.Decimation;
                    break;
                case 1:
                    c = Cipher.Vizhinera;
                    break;
            }
            if (Data.IsEnglish(richTextBox1.Text) && Data.IsEnglish(richTextBox2.Text) || string.IsNullOrEmpty(richTextBox1.Text) || string.IsNullOrEmpty(richTextBox2.Text))
            {
                Data dat = new Data(DecimationCipher.ToUpper(richTextBox1.Text), DecimationCipher.ToUpper(richTextBox2.Text), c);
                string jsonText = JsonSerializer.Serialize(dat, options);
                SaveFile(jsonText);
            }
            else
            {
                label4.Text = "Невалидные строки для сохранения в этом алгоритме";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            VizhenereCipher vc = new VizhenereCipher();

            string key = VizhenereCipher.ToUpper(textBox2.Text);
            key = VizhenereCipher.GetValidKey(key);
            textBox2.Text = key;
            vc.key = key;
            string error = "";
            richTextBox1.Text = vc.getValidString(DecimationCipher.ToUpper(richTextBox1.Text));
            if (Data.IsRussian(VizhenereCipher.ToUpper(richTextBox1.Text)))
            {
                if (!string.IsNullOrEmpty(key))
                {
                    if (VizhenereCipher.IsValidKey(key))
                        richTextBox2.Text = vc.Ciphe(richTextBox1.Text, key, out error);
                    else
                        error = "Невалидный ключ";
                }
                else
                    error = "Нет ключа";
            }
            else
                error = "Невалидная шифруемая строка (должны быть русские символы)";
            label6.Text = error;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VizhenereCipher vc = new VizhenereCipher();

            string key = VizhenereCipher.ToUpper(textBox2.Text);
            key = VizhenereCipher.GetValidKey(key);
            vc.key = key;
            textBox2.Text = key;
            string error = "";
            richTextBox2.Text = vc.getValidString(DecimationCipher.ToUpper(richTextBox2.Text));
            if (Data.IsRussian(VizhenereCipher.ToUpper(richTextBox2.Text)))
            {
                if (!string.IsNullOrEmpty(key))
                {
                    if (VizhenereCipher.IsValidKey(key))
                        richTextBox1.Text = vc.Deciphe(richTextBox2.Text, key, out error);
                    else
                        error = "Невалидный ключ";
                }
                else
                    error = "Нет ключа";
            }
            else
                error = "Невалидная дешифруемая строка (должны быть русские символы)";
            label6.Text = error;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            textBox2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string jsonText = OpenFile();
            if (!string.IsNullOrEmpty(jsonText))
            {
                try
                {
                    Data dat = JsonSerializer.Deserialize<Data>(jsonText)!;
                    tabControl1.SelectedIndex = (int)dat.cipherType;
                    richTextBox1.Text = dat.PlainText;
                    richTextBox2.Text = dat.CipherText;
                }
                catch
                {
                    label6.Text = "Невозможно открыть файл";
                }
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };
            Cipher c = Cipher.Decimation;
            string key = textBox2.Text;

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    c = Cipher.Decimation;
                    break;
                case 1:
                    c = Cipher.Vizhinera;
                    break;
            }
            if (Data.IsRussian(richTextBox1.Text) && Data.IsRussian(richTextBox2.Text) || string.IsNullOrEmpty(richTextBox1.Text) || string.IsNullOrEmpty(richTextBox2.Text))
            {
                Data dat = new Data(VizhenereCipher.ToUpper(richTextBox1.Text), VizhenereCipher.ToUpper(richTextBox2.Text), c);
                string jsonText = JsonSerializer.Serialize(dat, options);
                SaveFile(jsonText);
            }
            else
            {
                label6.Text = "Невалидные строки для сохранения в этом алгоритме";
            }
        }
    }
}
