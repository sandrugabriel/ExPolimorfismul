﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controllers;
using View.Models;

namespace View.Panels
{
    internal class PnlCard : Panel
    {

        private System.Windows.Forms.PictureBox pctDesign;
        private System.Windows.Forms.PictureBox pctFavorite;
        private System.Windows.Forms.PictureBox pctLike;
        private System.Windows.Forms.PictureBox pctDesen;
        private System.Windows.Forms.Label lblNume;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;

        Form1 form;
        DetaliDesen detaliDesen;
        ControllerDetalii controllerDetalii;
        ControllerFigura controllerFigura;
        ControllerClient controllerClient;

        string path;
        Client client;
        public PnlCard(Form1 form1, DetaliDesen detaliDesen1, Client client1)
        {
            form = form1;
            detaliDesen = detaliDesen1;
            controllerClient = new ControllerClient();
            controllerDetalii = new ControllerDetalii();
            controllerFigura = new ControllerFigura();
            client = client1;

            path = Application.StartupPath + @"/data/imagini/";

            //PnlCard
            this.BackgroundImage = Image.FromFile(path + "gradient1.png");
            this.ClientSize = new System.Drawing.Size(332, 254);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PnlCard";

            this.pctDesign = new System.Windows.Forms.PictureBox();
            this.pctFavorite = new System.Windows.Forms.PictureBox();
            this.pctLike = new System.Windows.Forms.PictureBox();
            this.pctDesen = new System.Windows.Forms.PictureBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse();

            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.pctDesen);
            this.Controls.Add(this.pctDesign);
            this.Controls.Add(this.pctFavorite);
            this.Controls.Add(this.pctLike);

            // pctDesign
            this.pctDesign.Location = new System.Drawing.Point(0, 196);
            this.pctDesign.Name = "pctDesign";
            this.pctDesign.Size = new System.Drawing.Size(332, 2);

            // pctFavorite
            this.pctFavorite.BackColor = System.Drawing.Color.Transparent;
            if (controllerClient.validFav(detaliDesen.Id, client.Id))
                this.pctFavorite.Image = Image.FromFile(path + "star.png");
            else
                this.pctFavorite.Image = Image.FromFile(path + "fav.png");
        
            this.pctFavorite.Location = new System.Drawing.Point(199, 203);
            this.pctFavorite.Name = "pctFavorite";
            this.pctFavorite.Size = new System.Drawing.Size(56, 48);
            this.pctFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
             
            // pctLike
            this.pctLike.BackColor = System.Drawing.Color.Transparent;

            if (controllerClient.validFav(detaliDesen.Id, client.Id))
                this.pctLike.Image = Image.FromFile(path + "heart.png");
            else
                this.pctLike.Image = Image.FromFile(path + "lik.png");

            this.pctLike.Location = new System.Drawing.Point(78, 203);
            this.pctLike.Name = "pctLike";
            this.pctLike.Size = new System.Drawing.Size(56, 48);
            this.pctLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
             
            // pctDesen
            this.pctDesen.Location = new System.Drawing.Point(12, 12);
            this.pctDesen.Name = "pctDesen";
            this.pctDesen.Size = new System.Drawing.Size(308, 137);
             
            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.Color.Transparent;
            this.lblNume.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNume.Location = new System.Drawing.Point(86, 157);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(156, 27);
            this.lblNume.TabIndex = 14;
            this.lblNume.Text = detaliDesen.Name;
             
            // bunifuElipse1
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            
            // bunifuElipse2
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.pctDesen;

            RedrawShapesInSmallPictureBox();
        }

        private void ResizeCerc(Cerc shape,float scaleX, float scaleY)
        {
            shape.Punct.X = Convert.ToInt32(shape.Punct.X * scaleX);
            shape.Punct.Y = Convert.ToInt32(shape.Punct.Y * scaleY);
            shape.Raza =Convert.ToInt32(shape.Raza * scaleX);
        }

        private void ResizeLinie(Linie shape, float scaleX, float scaleY)
        {
            shape.Punct1.X = Convert.ToInt32(shape.Punct1.X * scaleX);
            shape.Punct1.Y = Convert.ToInt32(shape.Punct1.Y * scaleY);
            shape.Punct2.X = Convert.ToInt32(shape.Punct2.X * scaleX);
            shape.Punct2.Y = Convert.ToInt32(shape.Punct2.Y * scaleY);
        }
        private void ResizeDrept(Dreptunghi shape, float scaleX, float scaleY)
        {
            shape.Punct1.X = Convert.ToInt32(shape.Punct1.X * scaleX);
            shape.Punct1.Y = Convert.ToInt32(shape.Punct1.Y * scaleY);
            shape.Width = Convert.ToInt32(shape.Width * scaleX);
            shape.Height = Convert.ToInt32(shape.Height * scaleY);
        }

        private void RedrawShapesInSmallPictureBox()
        {

            float scaleX = (float)pctDesen.Width / (float)1006;
            float scaleY = (float)pctDesen.Height / (float)649;

            List<int> shapes = detaliDesen.IdFiguri;

            List<Figura> figuras = controllerFigura.getFigures(shapes);
            Bitmap bitmap = new Bitmap(pctDesen.Width, pctDesen.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                foreach (Figura figura in figuras)
                {
                    if (figura.Type == "cerc")
                    {
                        Cerc cerc = (Cerc)figura;
                        ResizeCerc(cerc, scaleX, scaleY);
                        g.DrawEllipse(Pens.Black, cerc.Punct.X - cerc.Raza, cerc.Punct.Y - cerc.Raza, 2 * cerc.Raza, 2 * cerc.Raza);
                    }
                    else if (figura.Type == "linie")
                    {
                        Linie linie = (Linie)figura;
                        ResizeLinie(linie, scaleX, scaleY);
                        g.DrawLine(Pens.Black,linie.Punct1.X,linie.Punct1.Y,linie.Punct2.X,linie.Punct2.Y);
                    }
                    else if (figura.Type == "dreptunghi")
                    {
                        Dreptunghi dreptunghi = (Dreptunghi)figura;
                        ResizeDrept(dreptunghi, scaleX, scaleY);
                        g.DrawRectangle(Pens.Black, dreptunghi.Punct1.X, dreptunghi.Punct1.Y, dreptunghi.Width, dreptunghi.Height);
                    }
                }
            }

            pctDesen.Image = bitmap;
        }


    }
}