using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Crypt
{
    public partial class CryptForm : Form
    {
        public CryptForm()
        {
            InitializeComponent();
        }

        private string archive;
        private string publicPrivateXml;
        private string publicXml;

        ASCIIEncoding ByteConverter = new ASCIIEncoding();

        private void selectArchiveButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog.FileName);
                    archive = sr.ReadToEnd().ToString();
                    MessageBox.Show("Arquivo importado!");
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Ocorreu um erro ao abrir o arquivo!");
                }
            }
        }

        private void generateKeysButton_Click(object sender, EventArgs e)
        {
            var rsa = new RSACryptoServiceProvider();
            publicPrivateXml = rsa.ToXmlString(true);
            publicXml = rsa.ToXmlString(false);
            MessageBox.Show("Par de chaves geradas!");
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(publicXml);
                byte[] toEncryptData = ByteConverter.GetBytes(archive);
                byte[] encryptedRSA = rsa.Encrypt(toEncryptData, false);

                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                filePath = filePath + @"\ArchiveEncrypted.crypt";
                TextWriter sw = new StreamWriter(filePath);
                for (var i = 0; i < encryptedRSA.Count(); i++)
                {
                    if (i < encryptedRSA.Count() - 1)
                    {
                        sw.Write(encryptedRSA[i] + ",");
                    }
                    else
                    {
                        sw.Write(encryptedRSA[i]);
                    }
                }
                sw.Close();
                MessageBox.Show("Arquivo criptografado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro ocorreu ao tentar criptografar");
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                var toDencryptData = archive.Split(',').Select(el => (byte)Convert.ToInt32(el)).ToArray();

                var rsa2 = new RSACryptoServiceProvider();
                rsa2.FromXmlString(publicPrivateXml);

                byte[] decryptedRSA = rsa2.Decrypt(toDencryptData, false);
                string originalResult = ByteConverter.GetString(decryptedRSA);

                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                filePath = filePath + @"\ArchiveDecrypted.txt";
                TextWriter sw = new StreamWriter(filePath);
                sw.Write(originalResult);
                sw.Close();

                MessageBox.Show("Arquivo descriptografado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro ocorreu ao tentar descriptografar");
            }
        }

        private void savePublicKey_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(publicXml))
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                filePath = filePath + @"\PublicKey.xml";
                TextWriter sw = new StreamWriter(filePath);

                sw.Write(publicXml);
                sw.Close();

                MessageBox.Show("Chave pública salva!");
            }
            else
            {
                MessageBox.Show("É necessário gerar uma chave para salva-la!");
            }
        }

        private void importPublicKey_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var xmlReader = new XmlTextReader(openFileDialog.FileName);

                    string txtDados = "";

                    while (xmlReader.Read())
                    {
                        switch (xmlReader.NodeType)
                        {
                            case XmlNodeType.Element:
                                txtDados += "<" + xmlReader.Name + ">";
                                break;
                            case XmlNodeType.Text:
                                txtDados += xmlReader.Value;
                                break;
                            case XmlNodeType.EndElement:
                                txtDados += "</" + xmlReader.Name + ">";
                                break;
                        }
                    }

                    var rsa = new RSACryptoServiceProvider();
                    rsa.FromXmlString(txtDados);

                    if (!txtDados.Contains("<RSAKeyValue>") || !txtDados.Contains("<Modulus>") || !txtDados.Contains("<Exponent>") || txtDados.Contains("<P>") ||
                        txtDados.Contains("<Q>") || txtDados.Contains("<DP>") || txtDados.Contains("<DQ>") || txtDados.Contains("<InverseQ>") ||
                        txtDados.Contains("<D>"))
                    {
                        throw new System.ArgumentException("Erro ao importar chave");
                    }

                    publicXml = txtDados;
                    MessageBox.Show($"Chave pública Importada");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao importar a chave pública");
                }
            }
        }
    }
}
