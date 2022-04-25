using System.Windows.Forms;

namespace Demo.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblNhom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTrash = new System.Windows.Forms.RadioButton();
            this.btnSent = new System.Windows.Forms.RadioButton();
            this.btnDrafts = new System.Windows.Forms.RadioButton();
            this.btnInbox = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewMessage = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lsbMessages = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSortDirection = new System.Windows.Forms.RadioButton();
            this.cmbSortOpt = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(108)))), ((int)(((byte)(167)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // panel10
            // 
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel10.Controls.Add(this.label1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(530, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10);
            this.panel10.Size = new System.Drawing.Size(688, 38);
            this.panel10.TabIndex = 5;
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panel10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(451, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "mailtest@nhom10.nt106";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbSearch);
            this.panel9.Controls.Add(this.lblFolder);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(200, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(5);
            this.panel9.Size = new System.Drawing.Size(330, 38);
            this.panel9.TabIndex = 4;
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panel9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panel9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // txbSearch
            // 
            this.txbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbSearch.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearch.Location = new System.Drawing.Point(84, 5);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PlaceholderText = "Search ";
            this.txbSearch.Size = new System.Drawing.Size(241, 27);
            this.txbSearch.TabIndex = 1;
            // 
            // lblFolder
            // 
            this.lblFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFolder.Font = new System.Drawing.Font("CaskaydiaCove NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.lblFolder.Location = new System.Drawing.Point(5, 5);
            this.lblFolder.Margin = new System.Windows.Forms.Padding(3);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(79, 28);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "Inbox";
            this.lblFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.lblFolder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.lblFolder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblNhom);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel8.Size = new System.Drawing.Size(200, 38);
            this.panel8.TabIndex = 3;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panel8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // lblNhom
            // 
            this.lblNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNhom.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.lblNhom.Location = new System.Drawing.Point(10, 0);
            this.lblNhom.Name = "lblNhom";
            this.lblNhom.Padding = new System.Windows.Forms.Padding(5);
            this.lblNhom.Size = new System.Drawing.Size(190, 38);
            this.lblNhom.TabIndex = 0;
            this.lblNhom.Text = "NT106, Group 10";
            this.lblNhom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNhom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.lblNhom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.lblNhom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("SF Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.button1.Location = new System.Drawing.Point(1218, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "➖";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("SF Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.btnExit.Location = new System.Drawing.Point(1248, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "❌";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTrash);
            this.panel2.Controls.Add(this.btnSent);
            this.panel2.Controls.Add(this.btnDrafts);
            this.panel2.Controls.Add(this.btnInbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnNewMessage);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.panel2.Size = new System.Drawing.Size(200, 680);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.outerLeft_Paint);
            // 
            // btnTrash
            // 
            this.btnTrash.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnTrash.AutoSize = true;
            this.btnTrash.BackColor = System.Drawing.Color.Transparent;
            this.btnTrash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrash.FlatAppearance.BorderSize = 0;
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTrash.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnTrash.Location = new System.Drawing.Point(0, 197);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTrash.Size = new System.Drawing.Size(199, 29);
            this.btnTrash.TabIndex = 16;
            this.btnTrash.Text = " Trash";
            this.btnTrash.UseVisualStyleBackColor = false;
            this.btnTrash.CheckedChanged += new System.EventHandler(this.btnTrash_CheckedChanged);
            // 
            // btnSent
            // 
            this.btnSent.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSent.AutoSize = true;
            this.btnSent.BackColor = System.Drawing.Color.Transparent;
            this.btnSent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSent.FlatAppearance.BorderSize = 0;
            this.btnSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSent.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSent.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnSent.Location = new System.Drawing.Point(0, 168);
            this.btnSent.Name = "btnSent";
            this.btnSent.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSent.Size = new System.Drawing.Size(199, 29);
            this.btnSent.TabIndex = 15;
            this.btnSent.Text = " Sent";
            this.btnSent.UseVisualStyleBackColor = false;
            this.btnSent.CheckedChanged += new System.EventHandler(this.btnSent_CheckedChanged);
            // 
            // btnDrafts
            // 
            this.btnDrafts.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnDrafts.AutoSize = true;
            this.btnDrafts.BackColor = System.Drawing.Color.Transparent;
            this.btnDrafts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrafts.FlatAppearance.BorderSize = 0;
            this.btnDrafts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrafts.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDrafts.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnDrafts.Location = new System.Drawing.Point(0, 139);
            this.btnDrafts.Name = "btnDrafts";
            this.btnDrafts.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDrafts.Size = new System.Drawing.Size(199, 29);
            this.btnDrafts.TabIndex = 14;
            this.btnDrafts.Text = " Drafts";
            this.btnDrafts.UseVisualStyleBackColor = false;
            this.btnDrafts.CheckedChanged += new System.EventHandler(this.btnDrafts_CheckedChanged);
            // 
            // btnInbox
            // 
            this.btnInbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnInbox.AutoSize = true;
            this.btnInbox.BackColor = System.Drawing.Color.Transparent;
            this.btnInbox.Checked = true;
            this.btnInbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInbox.FlatAppearance.BorderSize = 0;
            this.btnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInbox.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnInbox.Location = new System.Drawing.Point(0, 110);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInbox.Size = new System.Drawing.Size(199, 29);
            this.btnInbox.TabIndex = 13;
            this.btnInbox.TabStop = true;
            this.btnInbox.Text = " Inbox";
            this.btnInbox.UseVisualStyleBackColor = false;
            this.btnInbox.CheckedChanged += new System.EventHandler(this.btnInbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(0, 80);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(199, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "MAILBOX";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNewMessage
            // 
            this.btnNewMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(168)))), ((int)(((byte)(158)))));
            this.btnNewMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewMessage.FlatAppearance.BorderSize = 0;
            this.btnNewMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMessage.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewMessage.Location = new System.Drawing.Point(0, 40);
            this.btnNewMessage.Name = "btnNewMessage";
            this.btnNewMessage.Size = new System.Drawing.Size(199, 40);
            this.btnNewMessage.TabIndex = 3;
            this.btnNewMessage.Text = " New message";
            this.btnNewMessage.UseVisualStyleBackColor = false;
            this.btnNewMessage.Click += new System.EventHandler(this.btnNewMessage_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnHide);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel7.Size = new System.Drawing.Size(199, 40);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.miniTop1_Paint);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHide.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHide.Location = new System.Drawing.Point(98, 0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(91, 40);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Hide ";
            this.btnHide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(200, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.panel3.Size = new System.Drawing.Size(330, 680);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.middle_Paint);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lsbMessages);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(1, 40);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10);
            this.panel12.Size = new System.Drawing.Size(328, 640);
            this.panel12.TabIndex = 1;
            // 
            // lsbMessages
            // 
            this.lsbMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.lsbMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbMessages.FormattingEnabled = true;
            this.lsbMessages.ItemHeight = 15;
            this.lsbMessages.Location = new System.Drawing.Point(10, 10);
            this.lsbMessages.Name = "lsbMessages";
            this.lsbMessages.Size = new System.Drawing.Size(308, 620);
            this.lsbMessages.TabIndex = 0;
            this.lsbMessages.SelectedIndexChanged += new System.EventHandler(this.lsbMessages_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.btnSortDirection);
            this.panel5.Controls.Add(this.cmbSortOpt);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(9);
            this.panel5.Size = new System.Drawing.Size(328, 40);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.miniTop2_Paint);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.Location = new System.Drawing.Point(264, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 22);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSortDirection
            // 
            this.btnSortDirection.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSortDirection.AutoCheck = false;
            this.btnSortDirection.AutoSize = true;
            this.btnSortDirection.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSortDirection.FlatAppearance.BorderSize = 0;
            this.btnSortDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortDirection.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSortDirection.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSortDirection.Location = new System.Drawing.Point(295, 9);
            this.btnSortDirection.Name = "btnSortDirection";
            this.btnSortDirection.Size = new System.Drawing.Size(24, 22);
            this.btnSortDirection.TabIndex = 1;
            this.btnSortDirection.TabStop = true;
            this.btnSortDirection.Text = "";
            this.btnSortDirection.UseVisualStyleBackColor = true;
            this.btnSortDirection.Click += new System.EventHandler(this.btnSortDirection_Clicked);
            // 
            // cmbSortOpt
            // 
            this.cmbSortOpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.cmbSortOpt.DisplayMember = "Text";
            this.cmbSortOpt.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbSortOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortOpt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSortOpt.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSortOpt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbSortOpt.FormattingEnabled = true;
            this.cmbSortOpt.Location = new System.Drawing.Point(9, 9);
            this.cmbSortOpt.Name = "cmbSortOpt";
            this.cmbSortOpt.Size = new System.Drawing.Size(121, 23);
            this.cmbSortOpt.TabIndex = 0;
            this.cmbSortOpt.ValueMember = "ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(530, 40);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(750, 680);
            this.panel4.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.rtbMessage);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(1, 40);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10);
            this.panel11.Size = new System.Drawing.Size(749, 640);
            this.panel11.TabIndex = 1;
            // 
            // rtbMessage
            // 
            this.rtbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMessage.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbMessage.Location = new System.Drawing.Point(10, 10);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(729, 620);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(749, 40);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.miniTop3_Paint);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.Dock = System.Windows.Forms.DockStyle.Left;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("SF Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 40);
            this.button10.TabIndex = 7;
            this.button10.Text = "❌";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(629, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Location = new System.Drawing.Point(659, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("CaskaydiaCove NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Location = new System.Drawing.Point(689, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("CaskaydiaCove NF", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(719, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "ﰲ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel8;
        private Label lblNhom;
        private Button button1;
        private Button btnExit;
        private Panel panel7;
        private Panel panel5;
        private Panel panel6;
        private Panel panel9;
        private Label lblFolder;
        private TextBox txbSearch;
        private Panel panel10;
        private Label label1;
        private Button btnHide;
        private Button btnNewMessage;
        private ComboBox cmbSortOpt;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label2;
        private RadioButton btnInbox;
        private Button button10;
        private RadioButton btnTrash;
        private RadioButton btnSent;
        private RadioButton btnDrafts;
        private RadioButton btnSortDirection;
        private Panel panel12;
        private ListBox lsbMessages;
        private Panel panel11;
        private RichTextBox rtbMessage;
        private Button btnRefresh;
    }
}