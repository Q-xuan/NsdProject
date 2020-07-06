namespace FrmSupermarketManagement
{
    partial class FrmLoading
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoading));
            this.pLoadingbox = new System.Windows.Forms.Panel();
            this.pLoading = new System.Windows.Forms.Panel();
            this.timepass = new System.Windows.Forms.Timer(this.components);
            this.pLoadingbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLoadingbox
            // 
            this.pLoadingbox.BackColor = System.Drawing.Color.Transparent;
            this.pLoadingbox.Controls.Add(this.pLoading);
            this.pLoadingbox.Location = new System.Drawing.Point(0, 484);
            this.pLoadingbox.Name = "pLoadingbox";
            this.pLoadingbox.Size = new System.Drawing.Size(900, 15);
            this.pLoadingbox.TabIndex = 0;
            // 
            // pLoading
            // 
            this.pLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(227)))), ((int)(((byte)(204)))));
            this.pLoading.Location = new System.Drawing.Point(0, 0);
            this.pLoading.Name = "pLoading";
            this.pLoading.Size = new System.Drawing.Size(14, 20);
            this.pLoading.TabIndex = 0;
            // 
            // timepass
            // 
            this.timepass.Enabled = true;
            this.timepass.Interval = 10;
            this.timepass.Tick += new System.EventHandler(this.timepass_Tick);
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pLoadingbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pLoadingbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLoadingbox;
        private System.Windows.Forms.Panel pLoading;
        private System.Windows.Forms.Timer timepass;
    }
}

