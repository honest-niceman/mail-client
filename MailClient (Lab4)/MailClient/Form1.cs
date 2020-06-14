using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace MailClient
{
    public partial class Form1 : Form
    {
        List<string> attachments = new List<string>();
        List<string> recievers = new List<string>();
        public Form1()
        {
            InitializeComponent();
            listBox_Recievers.Visible = false;
            label7.Visible = false;
        }
        private void button_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBox_Port.Text, out int n))
                {
                    SmtpClient client = new SmtpClient(textBox_SMTP.Text, int.Parse(textBox_Port.Text));
                    client.EnableSsl = true;
                    client.Timeout = 20000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(textBox_Login.Text, textBox_Password.Text);
                    MailMessage msg = new MailMessage();                   
                    if (attachments.Count != 0)
                                    {
                        for (int i = 0; i < attachments.Count; i++)
                        {
                            msg.Attachments.Add(new Attachment(attachments[i]));
                        }
                    }
                    if(recievers.Count !=0 )
                    {
                        for (int i = 0; i < recievers.Count; i++)
                        {
                            msg.To.Add(recievers[i]);
                        }
                    }
                    else
                    {
                        msg.To.Add(textBox_To.Text);
                    }
                    msg.From = new MailAddress(textBox_Login.Text);
                    msg.Subject = textBox_Sub.Text;
                    msg.Body = textBox_Msg.Text;
                    client.Send(msg);
                    MessageBox.Show("Сообщение успешно доставлено!");
                    attachments.Clear();
                    listBox_Attachments.SelectedItems.Clear();
                    listBox_Recievers.SelectedItems.Clear();
                    recievers.Clear();
                    listBox_Recievers.Visible = false;
                    label7.Visible = false;
                }
                else
                {
                    MessageBox.Show("Проверьте правильность ввода данных");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_Atch_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                attachments.Add(ofd.FileName);
                listBox_Attachments.Items.Add(attachments.Count + ") " + ofd.FileName);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox_Recievers.Visible = true;
            label7.Visible = true;
            recievers.Add(textBox_To.Text);
            listBox_Recievers.Items.Add(recievers.Count + ")" + textBox_To.Text);
            textBox_To.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
