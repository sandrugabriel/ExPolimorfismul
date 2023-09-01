using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controllers;
using View.Mockups;
using View.Models;
using View.Properties;

namespace View.Panels
{
    internal class PnlLogin : Panel
    {

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox mini;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.PictureBox btnLogin;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.PictureBox pctLock;
        private System.Windows.Forms.PictureBox pctName;
        private System.Windows.Forms.PictureBox pct2;
        private System.Windows.Forms.PictureBox pct1;
        private ZBobb.AlphaBlendTextBox txtPass;
        private ZBobb.AlphaBlendTextBox txtName;

        ControllerClient controllerClient;
        Form1 form;

        string path;

        public PnlLogin(Form1 form1)
        {

            form = form1;
            controllerClient = new ControllerClient();

            path = Application.StartupPath + @"/data/imagini/";

            this.form.Size = new System.Drawing.Size(562, 778);

            //PnlLogin
            this.Size = new System.Drawing.Size(562, 778);
            this.Name = "PnlLogin";

            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.mini = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblSign = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.PictureBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.pctLock = new System.Windows.Forms.PictureBox();
            this.pctName = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new ZBobb.AlphaBlendTextBox();
            this.txtName = new ZBobb.AlphaBlendTextBox();

            this.Controls.Add(this.bunifuGradientPanel1);

            // bunifuElipse1
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
             
            // bunifuElipse2
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.bunifuGradientPanel1;

            // bunifuGradientPanel1
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox3);
            this.bunifuGradientPanel1.Controls.Add(this.close);
            this.bunifuGradientPanel1.Controls.Add(this.mini);
            this.bunifuGradientPanel1.Controls.Add(this.linkLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.lblSign);
            this.bunifuGradientPanel1.Controls.Add(this.btnLogin);
            this.bunifuGradientPanel1.Controls.Add(this.lblTitlu);
            this.bunifuGradientPanel1.Controls.Add(this.pctLock);
            this.bunifuGradientPanel1.Controls.Add(this.pctName);
            this.bunifuGradientPanel1.Controls.Add(this.pct2);
            this.bunifuGradientPanel1.Controls.Add(this.pct1);
            this.bunifuGradientPanel1.Controls.Add(this.txtPass);
            this.bunifuGradientPanel1.Controls.Add(this.txtName);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(250)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(78)))), ((int)(((byte)(214)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(78)))), ((int)(((byte)(214)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(77)))), ((int)(((byte)(155)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(562, 778);
             

            // pictureBox3
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.Location = new System.Drawing.Point(-17, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(600, 1);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
             
            // close
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = Image.FromFile(path+"close.png");
            this.close.Location = new System.Drawing.Point(518, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 29);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.Click += new EventHandler(close_Click);
             
            // mini
            this.mini.BackColor = System.Drawing.Color.Transparent;
            this.mini.Image = Image.FromFile(path + "mini.png");
            this.mini.Location = new System.Drawing.Point(473, 12);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(28, 29);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini.Click += new EventHandler(mini_Click);
             
            // linkLabel1
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(403, 719);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 23);
            this.linkLabel1.Click += new EventHandler(link_Click);
            this.linkLabel1.Text = "Create one!";

            // lblSign
            this.lblSign.AutoSize = true;
            this.lblSign.BackColor = System.Drawing.Color.Transparent;
            this.lblSign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSign.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSign.Location = new System.Drawing.Point(300, 719);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(257, 23);
            this.lblSign.TabIndex = 5;
            this.lblSign.Text = "No account. Create one!";
             
            // btnLogin
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Image = global::View.Properties.Resources.button_login__1_;
            this.btnLogin.Location = new System.Drawing.Point(143, 603);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(276, 85);
            this.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogin.TabIndex = 4;
            this.btnLogin.TabStop = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
             
            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitlu.Location = new System.Drawing.Point(208, 69);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(147, 47);
            this.lblTitlu.TabIndex = 3;
            this.lblTitlu.Text = "LOGIN";
             
            // pctLock
            this.pctLock.BackColor = System.Drawing.Color.Transparent;
            this.pctLock.Image = Image.FromFile(path + "lock.png");
            this.pctLock.Location = new System.Drawing.Point(34, 413);
            this.pctLock.Name = "pctLock";
            this.pctLock.Size = new System.Drawing.Size(58, 48);
            this.pctLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
             
            // pctName
            this.pctName.BackColor = System.Drawing.Color.Transparent;
            this.pctName.Image = Image.FromFile(path + "user.png");
            this.pctName.Location = new System.Drawing.Point(34, 268);
            this.pctName.Name = "pctName";
            this.pctName.Size = new System.Drawing.Size(46, 46);
            this.pctName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
             
            // pct2
            this.pct2.Location = new System.Drawing.Point(30, 476);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(520, 2);
            this.pct2.TabIndex = 1;
            this.pct2.TabStop = false;
             
            // pct1
            this.pct1.Location = new System.Drawing.Point(30, 330);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(520, 2);
            this.pct1.TabIndex = 1;
            this.pct1.TabStop = false;
             
            // txtPass
            this.txtPass.BackAlpha = 0;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Transparent;
            this.txtPass.Location = new System.Drawing.Point(94, 423);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(456, 55);
            this.txtPass.Enter += new EventHandler(txtPass_Enter);
            this.txtPass.Leave += new EventHandler(txtPass_Leve);
            this.txtPass.Text = "Password";
             
            // txtName
            this.txtName.BackAlpha = 0;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Transparent;
            this.txtName.Location = new System.Drawing.Point(94, 277);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(456, 55);
            this.txtName.Enter += new EventHandler(txtName_Enter);
            this.txtName.Leave += new EventHandler(txtName_Leve);
            this.txtName.Text = "Username";

        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if(txtName.Text.Equals("Username"))
            this.txtName.Text = "";
        }

        private void txtName_Leve(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
                this.txtName.Text = "Username";

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals("Password"))
                this.txtPass.Text = "";
        }

        private void txtPass_Leve(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(""))
                this.txtPass.Text = "Password";

        }

        private void close_Click(object sender, EventArgs e)
        {

            this.form.Close();

        }

        private void mini_Click(object sender, EventArgs e)
        {

            this.form.WindowState = FormWindowState.Minimized;

        }

        private void link_Click(object sender, EventArgs e)
        {
            this.form.removePnl("PnlLogin");
            this.form.Controls.Add(new PnlSignUp(form));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(txtName.Text.Equals("Username") || txtPass.Text.Equals("Password"))
            {
                MessageBox.Show("Username/Password were not introduced!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                if(controllerClient.verificare(txtName.Text,txtPass.Text))
                {
                    this.form.removePnl("PnlLogin");
                    Client client = controllerClient.getClient(txtName.Text, txtPass.Text);

                }
                else
                {
                    MessageBox.Show("Username/Password are incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

    }
}
