using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Forms
{
    public partial class Main : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool sortDirection = false;
        private Classes.POP3Client pop3Client;
        class ComboItem
        {
            public int ID { get; set; }
            public string Text { get; set; }
        }

        public Main()
        {
            InitializeComponent();
            pop3Client = new Classes.POP3Client();
            cmbSortOpt.DataSource = new ComboItem[]
            {
                new ComboItem{ ID = 0, Text = "Sort by date" },
                new ComboItem{ ID = 1, Text = "Sort by name" }
            };
            pop3Client.GetMailFromFolder("", ref lsbMessages);             
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void outerLeft_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.DimGray, 1, ButtonBorderStyle.Solid,
                Color.Transparent, 1, ButtonBorderStyle.None);
        }

        private void middle_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel3.ClientRectangle,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.DimGray, 1, ButtonBorderStyle.Solid,
                Color.Transparent, 1, ButtonBorderStyle.None);
        }

        private void miniTop_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel3.ClientRectangle,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.DimGray, 1, ButtonBorderStyle.Solid,
                Color.Transparent, 1, ButtonBorderStyle.None);
        }

        private void miniTop2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel5.ClientRectangle,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.DimGray, 1, ButtonBorderStyle.Solid);
        }

        private void miniTop1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel7.ClientRectangle,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.DimGray, 1, ButtonBorderStyle.Solid);
        }

        private void miniTop3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel6.ClientRectangle,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.Transparent, 1, ButtonBorderStyle.None,
                Color.DimGray, 1, ButtonBorderStyle.Solid);
        }

        private void btnInbox_CheckedChanged(object sender, EventArgs e)
        {
            if (btnInbox.Checked)
                lblFolder.Text = "Inbox";
        }

        private void btnDrafts_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDrafts.Checked)
                lblFolder.Text = "Drafts";
        }

        private void btnSent_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSent.Checked)
                lblFolder.Text = "Sent";
        }

        private void btnTrash_CheckedChanged(object sender, EventArgs e)
        {
            if (btnTrash.Checked)
                lblFolder.Text = "Trash";
        }

        private void btnNewMessage_Click(object sender, EventArgs e)
        {
            var newMessageForm = new NewMessage();
            newMessageForm.Show();
        }

        private void btnSortDirection_Clicked(object sender, EventArgs e)
        {
            btnSortDirection.Checked = !btnSortDirection.Checked;
            sortDirection = btnSortDirection.Checked;
            if (btnSortDirection.Checked)
                btnSortDirection.Text = "";
            else
                btnSortDirection.Text = "";
        }

        private void lsbMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbMessage.Clear();
            int i = lsbMessages.SelectedIndex + 1;

            string html = pop3Client.GetMessageAt(i);

            WebBrowser wb = new WebBrowser();
            wb.DocumentText = html;
            Application.DoEvents();
            wb.Document.ExecCommand("SelectAll", false, null);
            wb.Document.ExecCommand("Copy", false, null);
            rtbMessage.Paste();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            pop3Client.GetMailFromFolder(lblFolder.Text.Trim(), ref lsbMessages);
        }
    }
}
