using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using View.Controllers;
using View.Models;
using View.Properties;

namespace View.Panels
{
    internal class PnlHome : Panel
    {

        Form1 form;
        Client client;
        ControllerClient controllerClient;
        ControllerDetalii controllerDetalii;
        ControllerFigura controllerFigura;

        private System.Windows.Forms.PictureBox pctMeniu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox mini;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox pctProfile;
        private System.Windows.Forms.Label lblClientNume;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pctDesign1;
        private ZBobb.AlphaBlendTextBox txtSearch;
        private System.Windows.Forms.PictureBox pctSearch;
        private Bunifu.Framework.UI.BunifuGradientPanel gradientPanel;

        private string path;

        public PnlHome(Form1 form1, Client client1)
        {

            form = form1;
            this.client = client1;
            controllerClient = new ControllerClient();
            controllerDetalii = new ControllerDetalii();
            controllerFigura = new ControllerFigura();

            path = Application.StartupPath + @"/data/imagini/";

            this.form.Size = new System.Drawing.Size(1479, 749);
            this.form.Location = new Point(35,35);

            //PnlHome
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Size = new System.Drawing.Size(1479, 749);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PnlHome";

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pctMeniu = new System.Windows.Forms.PictureBox();
            this.mini = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.pctProfile = new System.Windows.Forms.PictureBox();
            this.lblClientNume = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctDesign1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new ZBobb.AlphaBlendTextBox();
            this.pctSearch = new System.Windows.Forms.PictureBox();
            this.gradientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pctMeniu);
            this.Controls.Add(this.gradientPanel);
             
            // btnAdd
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = Image.FromFile(path + "gallery.png");
            this.btnAdd.Location = new System.Drawing.Point(-121, 442);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(375, 120);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "                  Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            
            // btnLike
            this.btnLike.FlatAppearance.BorderSize = 0;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLike.Image = Image.FromFile(path + "like.png");
            this.btnLike.Location = new System.Drawing.Point(-121, 326);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(375, 120);
            this.btnLike.TabIndex = 2;
            this.btnLike.Text = "                  Liked";
            this.btnLike.UseVisualStyleBackColor = true;
            
            // btnFavorite
            this.btnFavorite.FlatAppearance.BorderSize = 0;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorite.Image = Image.FromFile(path + "favorite.png");
            this.btnFavorite.Location = new System.Drawing.Point(-121, 212);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(375, 120);
            this.btnFavorite.TabIndex = 2;
            this.btnFavorite.Text = "                       Favorites";
            this.btnFavorite.UseVisualStyleBackColor = true;

            // btnHome
            this.btnHome.BackgroundImage = Image.FromFile(path + "gradient.png");
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = Image.FromFile(path + "home.png");
            this.btnHome.Location = new System.Drawing.Point(-121, 97);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(375, 118);
            this.btnHome.Text = "                    Home";
            this.btnHome.UseVisualStyleBackColor = true;
             
            // pctMeniu
            this.pctMeniu.BackColor = System.Drawing.SystemColors.Control;
            this.pctMeniu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctMeniu.Location = new System.Drawing.Point(0, 97);
            this.pctMeniu.Name = "pctMeniu";
            this.pctMeniu.Size = new System.Drawing.Size(254, 652);
             
            // mini
            this.mini.BackColor = System.Drawing.Color.Transparent;
            this.mini.Image = Image.FromFile(path + "mini.png");
            this.mini.Location = new System.Drawing.Point(1391, 34);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(28, 29);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini.Click += new EventHandler(mini_Click);
             
            // close
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = Image.FromFile(path + "close.png");
            this.close.Location = new System.Drawing.Point(1439, 33);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 29);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.Click += new EventHandler(close_Click);
             
            // pctProfile
            this.pctProfile.BackColor = System.Drawing.Color.Transparent;
            this.pctProfile.Location = new System.Drawing.Point(1171, 17);
            this.pctProfile.Name = "pctProfile";
            this.pctProfile.Size = new System.Drawing.Size(68, 59);
            this.pctProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
             
            // lblClientNume
            this.lblClientNume.AutoSize = true;
            this.lblClientNume.BackColor = System.Drawing.Color.Transparent;
            this.lblClientNume.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNume.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClientNume.Location = new System.Drawing.Point(1257, 33);
            this.lblClientNume.Name = "lblClientNume";
            this.lblClientNume.Size = new System.Drawing.Size(82, 27);
            this.lblClientNume.Text = client.Name ;
            
            // pctLogo
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = Image.FromFile(path + "picture.png");
            this.pctLogo.Location = new System.Drawing.Point(29, 10);
            this.pctLogo.Name = "pctDesen";
            this.pctLogo.Size = new System.Drawing.Size(114, 76);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            
            // pctDesign1
            this.pctDesign1.Location = new System.Drawing.Point(464, 63);
            this.pctDesign1.Name = "pctDesign1";
            this.pctDesign1.Size = new System.Drawing.Size(348, 2);
            this.pctDesign1.TabIndex = 9;
            this.pctDesign1.TabStop = false;
             
            // txtSearch
            this.txtSearch.BackAlpha = 0;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Location = new System.Drawing.Point(495, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(317, 37);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Text = " Search";
            this.txtSearch.Enter += new EventHandler(txtSearch_Enter);
            this.txtSearch.Leave += new EventHandler(txtSearch_Leve);
             
            // pctSearch
            this.pctSearch.BackColor = System.Drawing.Color.Transparent;
            this.pctSearch.Image = Image.FromFile(path + "search.png");
            this.pctSearch.Location = new System.Drawing.Point(464, 35);
            this.pctSearch.Name = "pctSearch";
            this.pctSearch.Size = new System.Drawing.Size(26, 24);
            this.pctSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
             
            // gradientPanel
            this.gradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel.Controls.Add(this.pctSearch);
            this.gradientPanel.Controls.Add(this.txtSearch);
            this.gradientPanel.Controls.Add(this.pctDesign1);
            this.gradientPanel.Controls.Add(this.pctLogo);
            this.gradientPanel.Controls.Add(this.lblClientNume);
            this.gradientPanel.Controls.Add(this.pctProfile);
            this.gradientPanel.Controls.Add(this.close);
            this.gradientPanel.Controls.Add(this.mini);
            this.gradientPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(250)))));
            this.gradientPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(78)))), ((int)(((byte)(214)))));
            this.gradientPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(250)))));
            this.gradientPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(78)))), ((int)(((byte)(214)))));
            this.gradientPanel.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel.Name = "gradientPanel";
            this.gradientPanel.Quality = 10;
            this.gradientPanel.Size = new System.Drawing.Size(1479, 97);
            

        }


        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(" Search"))
                this.txtSearch.Text = "";
        }

        private void txtSearch_Leve(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
                this.txtSearch.Text = " Search";

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.form.Close();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.form.WindowState = FormWindowState.Minimized;
        }

    }
}
