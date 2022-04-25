using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Forms
{
    public partial class NewMessage : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public NewMessage()
        {
            InitializeComponent();
        }
        public NewMessage(string recipients, string subject)
        {           
            InitializeComponent();
            txtRecipients.Text = recipients;
            txtSubject.Text = subject;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle,
                Color.DimGray, 1, ButtonBorderStyle.Solid,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.DimGray, 1, ButtonBorderStyle.Solid,
                Color.DimGray, 1, ButtonBorderStyle.Solid);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = "mailtest@nhom10.nt106";
                string mailto = txtRecipients.Text.ToString().Trim();
                string password = "Ivagrentina123";
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = txtSubject.Text.ToString().Trim();
                    message.IsBodyHtml = true;
                    message.Body = rtxtMessage.Text.ToString();
                    message.To.Add(mailto);

                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch (Exception ex)
                    { Console.WriteLine(ex.ToString()); }
                }
            }
            this.Close();
        }
    }
}
