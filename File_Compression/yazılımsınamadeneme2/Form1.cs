using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazılımsınamadeneme2
{
    public partial class Form1 : Form
    {
        byte[] abc;
        byte[,] table;
        public Form1()
        {   
            InitializeComponent();
        }
        private void textDosyaYolu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog V1 = new OpenFileDialog();
            V1.Filter = "TEXT files (*.txt)|*txt|All files(*.*)|*.*";

            if (V1.ShowDialog() == DialogResult.OK)
            {
                textDosyaYolu.Text = Path.GetFileName(V1.FileName);
                textDosyaYolu.Text = V1.FileName;
            }
        }
        private void rbsifrele_CheckedChanged(object sender, EventArgs e)
        {
            if (rbsifrele.Checked)
            {   
                DosyaRarla.Checked = false;
            }
        }
        private void DosyaRarla_CheckedChanged(object sender, EventArgs e)
        {
            if (DosyaRarla.Checked)
            {
                rbsifrele.Checked = false;
            }
            var fileName = Path.GetFileNameWithoutExtension(textDosyaYolu.Text);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var path = Path.Combine(desktop, $"{fileName}.zip");
            using (var archive = ZipFile.Open(path, ZipArchiveMode.Create))
            {
                var entry = archive.CreateEntryFromFile(textDosyaYolu.Text, Path.GetFileName(textDosyaYolu.Text), CompressionLevel.Fastest);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            rbsifrele.Checked = true;
            //abc ve tabloyu başlat
            abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);

            table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
                }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textDosyaYolu.Text))
            {
                MessageBox.Show("dosya çıkmıyor.");
                return;
            }
            if (string.IsNullOrEmpty(textSifre.Text))
            {
                MessageBox.Show("Şifre boş lütfen şifreyi giriniz.");
                return;
            }

            try
            {
                byte[] fileContent = File.ReadAllBytes(textDosyaYolu.Text);
                byte[] passwordTmp = Encoding.ASCII.GetBytes(textSifre.Text);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                    keys[i] = passwordTmp[i % passwordTmp.Length];

                //şifrelemek
                byte[] result = new byte[fileContent.Length];
                if (rbsifrele.Checked)
                {

                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        result[i] = table[keyIndex, valueIndex];
                    }
                }

                //SifreCözme
                else
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (table[keyIndex, j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        result[i] = abc[valueIndex];
                    }
                }
                //aynı uzantıyı kaydet
                string fileExt = Path.GetExtension(textDosyaYolu.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Files(*" + fileExt + ")|*" + fileExt;
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, result);
                }
            }
            catch
            {
                MessageBox.Show("hata");
                return;


            }
        }

       
    }
}