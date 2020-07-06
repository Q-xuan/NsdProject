using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CustomAlertBoxDemo;

namespace FrmSupermarketManagement
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private Point mPoint;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FrmLoading fl = new FrmLoading();
        }
        #region 窗体移动
        /// <summary>
        /// 鼠标按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// 鼠标移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.White;
            pUser.BackColor = Color.White;
            pbUser.BackColor = Color.White;
            txtPwd.BackColor = SystemColors.ControlLight;
            pPwd.BackColor = SystemColors.ControlLight;
            pbPwd.BackColor = SystemColors.ControlLight;
        }

        private void txtPwd_Click(object sender, EventArgs e)
        {
            txtPwd.BackColor = Color.White;
            pPwd.BackColor = Color.White;
            pbPwd.BackColor = Color.White;
            txtUser.BackColor = SystemColors.ControlLight;
            pUser.BackColor = SystemColors.ControlLight;
            pbUser.BackColor = SystemColors.ControlLight;
        }

        private void pbPwd_MouseDown(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = false;
            Image i = new Bitmap("C:\\Users\\A_rui\\Desktop\\NSD组项目答辩\\实验\\NsdProject\\FrmSupermarketManagement\\Resources\\unlock.png");
            pbPwd.Image = i;
        }

        private void pbPwd_MouseUp(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = true;
            Image i = new Bitmap("C:\\Users\\A_rui\\Desktop\\NSD组项目答辩\\实验\\NsdProject\\FrmSupermarketManagement\\Resources\\lock.png");
            pbPwd.Image = i;
        }


        #region 验证

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public void isright()
        {
            if (txtPwd.Text.Trim().Equals(string.Empty))
            {
                this.Alert("密码不能为空", Form_Alert.enmType.Warning);
                txtPwd.Focus();
            }
        }
        #endregion

    }
}
