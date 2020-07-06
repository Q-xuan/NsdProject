namespace FrmSupermarketManagement
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pPwd = new System.Windows.Forms.Panel();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.pUser = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pbPwd = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pPwd.SuspendLayout();
            this.pUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 761);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(378, 740);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "收银台登录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("腾祥童话体简", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(80, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "须乎超市管理系统";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("腾祥童话体简", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(209, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎进入";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(449, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(735, 69);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pbPwd);
            this.panel2.Controls.Add(this.pbUser);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pPwd);
            this.panel2.Controls.Add(this.pUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(449, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 761);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("腾祥童话体简", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(236, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "欢迎进入前台收银系统";
            // 
            // pPwd
            // 
            this.pPwd.Controls.Add(this.txtPwd);
            this.pPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pPwd.Location = new System.Drawing.Point(1, 349);
            this.pPwd.Name = "pPwd";
            this.pPwd.Size = new System.Drawing.Size(735, 70);
            this.pPwd.TabIndex = 3;
            this.pPwd.Click += new System.EventHandler(this.txtPwd_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("腾祥童话体简", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPwd.Location = new System.Drawing.Point(198, 24);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(355, 25);
            this.txtPwd.TabIndex = 0;
            this.txtPwd.UseSystemPasswordChar = true;
            this.txtPwd.Click += new System.EventHandler(this.txtPwd_Click);
            // 
            // pUser
            // 
            this.pUser.BackColor = System.Drawing.Color.White;
            this.pUser.Controls.Add(this.txtUser);
            this.pUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pUser.Location = new System.Drawing.Point(0, 261);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(735, 70);
            this.pUser.TabIndex = 3;
            this.pUser.Click += new System.EventHandler(this.txtUser_Click);
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("腾祥童话体简", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUser.Location = new System.Drawing.Point(198, 24);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(365, 33);
            this.txtUser.TabIndex = 0;
            this.txtUser.Click += new System.EventHandler(this.txtUser_Click);
            // 
            // pbPwd
            // 
            this.pbPwd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbPwd.Image = global::FrmSupermarketManagement.Properties.Resources._lock;
            this.pbPwd.Location = new System.Drawing.Point(121, 357);
            this.pbPwd.Name = "pbPwd";
            this.pbPwd.Size = new System.Drawing.Size(50, 50);
            this.pbPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPwd.TabIndex = 2;
            this.pbPwd.TabStop = false;
            this.pbPwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPwd_MouseDown);
            this.pbPwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPwd_MouseUp);
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.White;
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(121, 271);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(50, 50);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 2;
            this.pbUser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrmSupermarketManagement.Properties.Resources.go_to_link;
            this.pictureBox1.Location = new System.Drawing.Point(340, 552);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pPwd.ResumeLayout(false);
            this.pPwd.PerformLayout();
            this.pUser.ResumeLayout(false);
            this.pUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbPwd;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pUser;
        private System.Windows.Forms.Panel pPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}