using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controllers;
using View.Models;
using View.Properties;

namespace View.Panels
{
    internal class PnlSignUp : Panel
    {

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox btnSignUp;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.PictureBox pctConfPass;
        private System.Windows.Forms.PictureBox pctLock;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox mini;
        private System.Windows.Forms.PictureBox pctName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pct2;
        private System.Windows.Forms.PictureBox pct1;
        private ZBobb.AlphaBlendTextBox txtConfPass;
        private ZBobb.AlphaBlendTextBox txtPass;
        private ZBobb.AlphaBlendTextBox txtName;

        ControllerClient controllerClient;

        Form1 form;

        string path;

        public PnlSignUp(Form1 form1)
        {

            form = form1;
            controllerClient = new ControllerClient();

            path = Application.StartupPath + @"/data/imagini/";

            //PnlSignUp
            this.ClientSize = new System.Drawing.Size(565, 782);
            this.Name = "PnlSignUp";

            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse();
            this.txtName = new ZBobb.AlphaBlendTextBox();
            this.txtPass = new ZBobb.AlphaBlendTextBox();
            this.txtConfPass = new ZBobb.AlphaBlendTextBox();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctName = new System.Windows.Forms.PictureBox();
            this.mini = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.pctLock = new System.Windows.Forms.PictureBox();
            this.pctConfPass = new System.Windows.Forms.PictureBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();

            this.Controls.Add(this.bunifuGradientPanel1);

            // bunifuElipse1
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
             
            // bunifuElipse2
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.bunifuGradientPanel1;
             
            // txtName
            this.txtName.BackAlpha = 0;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Transparent;
            this.txtName.Location = new System.Drawing.Point(97, 220);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(456, 55);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Username";

            // txtPass
            this.txtPass.BackAlpha = 0;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Transparent;
            this.txtPass.Location = new System.Drawing.Point(97, 347);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(456, 55);
            this.txtPass.Text = "Password";
            
            // txtConfPass
            this.txtConfPass.BackAlpha = 0;
            this.txtConfPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtConfPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfPass.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfPass.ForeColor = System.Drawing.Color.Transparent;
            this.txtConfPass.Location = new System.Drawing.Point(97, 480);
            this.txtConfPass.Multiline = true;
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.Size = new System.Drawing.Size(456, 55);
            this.txtConfPass.TabIndex = 0;
            this.txtConfPass.Text = "Password Confirmation";
             
            // pct1
            this.pct1.Location = new System.Drawing.Point(33, 273);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(520, 2);
            this.pct1.TabIndex = 1;
            this.pct1.TabStop = false;
             
            // pct2
            this.pct2.Location = new System.Drawing.Point(33, 400);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(520, 2);
            this.pct2.TabIndex = 1;
            this.pct2.TabStop = false;
             
            // pictureBox1
            this.pictureBox1.Location = new System.Drawing.Point(33, 533);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 2);
             
            // pctName
            this.pctName.BackColor = System.Drawing.Color.Transparent;
            this.pctName.Image = Image.FromFile(path + "user.png");
            this.pctName.Location = new System.Drawing.Point(37, 211);
            this.pctName.Name = "pctName";
            this.pctName.Size = new System.Drawing.Size(46, 46);
            this.pctName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
             
            // mini
            this.mini.BackColor = System.Drawing.Color.Transparent;
            this.mini.Image = Image.FromFile(path + "mini.png");
            this.mini.Location = new System.Drawing.Point(473, 11);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(28, 29);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini.Click += new EventHandler(mini_Click);
            
            // close
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = Image.FromFile(path + "close.png");
            this.close.Location = new System.Drawing.Point(518, 11);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 29);
            this.close.Click += new EventHandler(close_Click);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // pctLock
            this.pctLock.BackColor = System.Drawing.Color.Transparent;
            this.pctLock.Image = Image.FromFile(path + "lock.png");
            this.pctLock.Location = new System.Drawing.Point(37, 337);
            this.pctLock.Name = "pctLock";
            this.pctLock.Size = new System.Drawing.Size(58, 48);
            this.pctLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLock.TabIndex = 2;
            this.pctLock.TabStop = false;
             
            // pctConfPass
            this.pctConfPass.BackColor = System.Drawing.Color.Transparent;
            this.pctConfPass.Image = Image.FromFile(path + "padlock.png");
            this.pctConfPass.Location = new System.Drawing.Point(37, 470);
            this.pctConfPass.Name = "pctConfPass";
            this.pctConfPass.Size = new System.Drawing.Size(58, 48);
            this.pctConfPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctConfPass.TabIndex = 2;
            this.pctConfPass.TabStop = false;
             
            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitlu.Location = new System.Drawing.Point(96, 64);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(373, 47);
            this.lblTitlu.TabIndex = 3;
            this.lblTitlu.Text = "CREATE ACCOUNT";
             
            // btnSignUp
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.Image = Image.FromFile(path + "sign.png");
            this.btnSignUp.Location = new System.Drawing.Point(143, 603);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(276, 85);
            this.btnSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSignUp.Click += new EventHandler(btnSignUp_Click);
             
            // linkLabel1
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(250, 718);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(280, 23);
            this.linkLabel1.Text = "Already have an account?";
            this.linkLabel1.Click += new EventHandler(link_Click);
             
            // pictureBox3
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.Location = new System.Drawing.Point(-17, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(600, 1);
             
            // bunifuGradientPanel1
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox3);
            this.bunifuGradientPanel1.Controls.Add(this.linkLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.btnSignUp);
            this.bunifuGradientPanel1.Controls.Add(this.lblTitlu);
            this.bunifuGradientPanel1.Controls.Add(this.pctConfPass);
            this.bunifuGradientPanel1.Controls.Add(this.pctLock);
            this.bunifuGradientPanel1.Controls.Add(this.close);
            this.bunifuGradientPanel1.Controls.Add(this.mini);
            this.bunifuGradientPanel1.Controls.Add(this.pctName);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.pct2);
            this.bunifuGradientPanel1.Controls.Add(this.pct1);
            this.bunifuGradientPanel1.Controls.Add(this.txtConfPass);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(565, 782);

        }

        private void link_Click(object sender, System.EventArgs e)
        {

            this.form.removePnl("PnlSignUp");
            this.form.Controls.Add(new PnlLogin(form));

        }

        private void close_Click(object sender, System.EventArgs e)
        {
            this.form.Close();
        }

        private void mini_Click(object sender, System.EventArgs e)
        {
            this.form.WindowState = FormWindowState.Minimized;
        }

        private void btnSignUp_Click(object sender, System.EventArgs e)
        {

            if (txtName.Text.Equals("Username") || txtPass.Text.Equals("Password") || txtName.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("Username/Password were not introduced!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (txtPass.Text.Equals(txtConfPass.Text))
                {
                    this.form.removePnl("PnlSignUp");
                    Client client = new Client(controllerClient.generareId(),txtName.Text,txtPass.Text,null,null);
                    controllerClient.save(controllerClient.generareId().ToString() + ";" + txtName.Text + ";" + txtPass.Text +";fav");
                    
                }
                else
                {
                    MessageBox.Show("They are not the same password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }


        }

    }
}
