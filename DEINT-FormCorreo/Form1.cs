using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEINT_FormCorreo
{
    public partial class Form1 : Form
    {
        Attachment datos;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show("File Content at path: " + filePath);
            datos = new Attachment(filePath, MediaTypeNames.Application.Octet);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (tbDe.Text.Equals("") || tbPara.Text.Equals("") || tbContra.Text.Equals("") || tbAsunto.Text.Equals(""))
            {
                MessageBox.Show("Debe introducir todos los campos para enviar el correo.");
            }
            else
            {
                try
                {
                    MailMessage correo = new MailMessage();
                    correo.From = new MailAddress(tbDe.Text);

                    correo.To.Add(tbPara.Text);
                    correo.Subject = tbAsunto.Text;
                    correo.Body = tbContenido.Text;
                    correo.Priority = MailPriority.Normal;
                    if (datos != null)
                    {
                        correo.Attachments.Add(datos);
                    }

                    SmtpClient smtp = new SmtpClient();
                    smtp.Credentials = new NetworkCredential(tbDe.Text, tbContra.Text);

                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;

                    smtp.Send(correo);

                    MessageBox.Show("Correo enviado correctamente :).");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo ha fallado al enviarl :(.");
                }
            }
        }
    }
}
