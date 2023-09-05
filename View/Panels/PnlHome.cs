using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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
        private Bunifu.Framework.UI.BunifuGradientPanel gradientPanel;

        private string path;

        PnlToateCardurile toateCardurile;

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
            this.btnAdd.Click += new EventHandler(btnAdd_Click);
            
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
            this.btnLike.Click += new EventHandler(btnLike_Click);

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
            this.btnFavorite.Click += new EventHandler(btnFavorite_Click);

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
            this.btnHome.Click += new EventHandler(btnHome_Click);

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
            
            // gradientPanel
            this.gradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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

            List<DetaliDesen> detaliDesens = controllerDetalii.getDesene();
            toateCardurile = new PnlToateCardurile(form,detaliDesens,client);

            this.Controls.Add(toateCardurile);

            toateCardurile.Location = new Point(260, 97);
           // toateCardurile.BackColor = Color.Gray;
        }
        public void removePnlHome(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.form.Close();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.form.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.btnHome.BackgroundImage = Image.FromFile(path + "gradient.png");
            this.btnFavorite.BackgroundImage = null;
            this.btnAdd.BackgroundImage = null;
            this.btnLike.BackgroundImage = null;
            this.removePnlHome("PnlCards");
            List<DetaliDesen> detaliDesens = controllerDetalii.getDesene();
            toateCardurile = new PnlToateCardurile(form, detaliDesens, client);
            this.Controls.Add(toateCardurile);
            toateCardurile.Location = new Point(260, 97);
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            this.btnFavorite.BackgroundImage = Image.FromFile(path + "gradient.png");
            this.btnHome.BackgroundImage = null;
            this.btnAdd.BackgroundImage = null;
            this.btnLike.BackgroundImage = null;
            List<DetaliDesen> detaliDesens = controllerDetalii.getFavo(controllerClient.getIdFav(client.Id));
            this.removePnlHome("PnlCards");
            toateCardurile = new PnlToateCardurile(form, detaliDesens, client);
            toateCardurile.Location = new Point(260, 97);
            this.Controls.Add(toateCardurile);
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            this.btnLike.BackgroundImage = Image.FromFile(path + "gradient.png");
            this.btnFavorite.BackgroundImage = null;
            this.btnAdd.BackgroundImage = null;
            this.btnHome.BackgroundImage = null;
            List<DetaliDesen> detaliDesens = controllerDetalii.getFavo(controllerClient.getIdLike(client.Id));
            this.removePnlHome("PnlCards");
            toateCardurile = new PnlToateCardurile(form, detaliDesens, client);
            toateCardurile.Location = new Point(260, 97);
            this.Controls.Add(toateCardurile);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.btnAdd.BackgroundImage = Image.FromFile(path + "gradient.png");
            this.btnFavorite.BackgroundImage = null;
            this.btnHome.BackgroundImage = null;
            this.btnLike.BackgroundImage = null;
            this.form.removePnl("PnlHome");
            this.form.Controls.Add(new PnlAdd(form,client));

        }

    }
}
