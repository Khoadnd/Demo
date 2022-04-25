namespace Demo.Forms
{
    partial class NewMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.div2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.div1 = new System.Windows.Forms.Panel();
            this.txtRecipients = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(108)))), ((int)(((byte)(167)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(134, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "New message";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("SF Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.btnExit.Location = new System.Drawing.Point(620, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "❌";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtxtMessage);
            this.panel2.Controls.Add(this.div2);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.txtSubject);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.div1);
            this.panel2.Controls.Add(this.txtRecipients);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(650, 490);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.rtxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtMessage.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtMessage.Location = new System.Drawing.Point(15, 77);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(620, 350);
            this.rtxtMessage.TabIndex = 7;
            this.rtxtMessage.Text = "";
            // 
            // div2
            // 
            this.div2.Dock = System.Windows.Forms.DockStyle.Top;
            this.div2.Location = new System.Drawing.Point(15, 67);
            this.div2.Name = "div2";
            this.div2.Size = new System.Drawing.Size(620, 10);
            this.div2.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDiscard);
            this.panel6.Controls.Add(this.btnSend);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(15, 427);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(620, 48);
            this.panel6.TabIndex = 5;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDiscard.FlatAppearance.BorderSize = 0;
            this.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiscard.Location = new System.Drawing.Point(582, 5);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(33, 38);
            this.btnDiscard.TabIndex = 1;
            this.btnDiscard.Text = "";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(165)))), ((int)(((byte)(205)))));
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSend.Location = new System.Drawing.Point(5, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 38);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(15, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(620, 1);
            this.panel5.TabIndex = 4;
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSubject.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubject.Location = new System.Drawing.Point(15, 46);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PlaceholderText = "Subject";
            this.txtSubject.Size = new System.Drawing.Size(620, 20);
            this.txtSubject.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(15, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(620, 10);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // div1
            // 
            this.div1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.div1.Dock = System.Windows.Forms.DockStyle.Top;
            this.div1.Location = new System.Drawing.Point(15, 35);
            this.div1.Name = "div1";
            this.div1.Size = new System.Drawing.Size(620, 1);
            this.div1.TabIndex = 1;
            // 
            // txtRecipients
            // 
            this.txtRecipients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.txtRecipients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecipients.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRecipients.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipients.Location = new System.Drawing.Point(15, 15);
            this.txtRecipients.Name = "txtRecipients";
            this.txtRecipients.PlaceholderText = "Recipients";
            this.txtRecipients.Size = new System.Drawing.Size(620, 20);
            this.txtRecipients.TabIndex = 0;
            // 
            // NewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(650, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMessage";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Panel panel2;
        private Label label1;
        private TextBox txtRecipients;
        private Panel div1;
        private Panel panel5;
        private TextBox txtSubject;
        private Panel panel6;
        private Button btnDiscard;
        private Button btnSend;
        private Panel panel4;
        private RichTextBox rtxtMessage;
        private Panel div2;
    }
}