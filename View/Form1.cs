using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Models;

namespace View
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        List<Figura> figuri;
        private int ct;
        private Figura figuraSelectata;
        public Form1()
        {
            InitializeComponent();
            this.comboBox1.SelectedIndex = 0;
            bitmap = new Bitmap(pctDesen.Width, pctDesen.Height);
            figuri = new List<Figura>();
            ct = 0;
        }

        private void btns_Click(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(bitmap);

            cmbTranslatare.Items.Clear();

            if(comboBox1.SelectedItem.ToString() == "Cerc")
            {
                int x = int.Parse(cercX.Value.ToString());
                int y = int.Parse(cercY.Value.ToString());
                int raza = int.Parse(cercRaza.Value.ToString());

                Punct punct = new Punct(x, y);
                Cerc cerc = new Cerc(raza, punct,"cerc"+ct.ToString());
               // MessageBox.Show("Name: "+cerc.Name);
                cerc.culoare = Color.Black;
                cerc.draw(pctDesen, graphics);
                figuri.Add(cerc);
                //ct++;
            }
            else if(comboBox1.SelectedItem.ToString() == "Linie")
            {

                int x = int.Parse(linieX.Value.ToString());
                int y = int.Parse(linieY.Value.ToString());
                int x1 = int.Parse(linieX1.Value.ToString());
                int y1 = int.Parse(linieY1.Value.ToString());

                Punct punct = new Punct(x, y);
                Punct punct1 = new Punct(x1, y1);

                Linie linie = new Linie(punct , punct1, "linie" + ct.ToString());
                linie.culoare = Color.Black;
                linie.draw(pctDesen, graphics);
                figuri.Add(linie);
               // ct++;
            }
            else if(comboBox1.SelectedItem.ToString() == "Dreptunghi")
            {

                int x = int.Parse(dreptX.Value.ToString());
                int y = int.Parse(dreptY.Value.ToString());
                int width = int.Parse(dreptWidth.Value.ToString());
                int height = int.Parse(dreptHeigth.Value.ToString());

                Punct punct = new Punct(x,y);
                Dreptunghi dreptunghi = new Dreptunghi(punct , width, height, "dreptunghi" + ct.ToString());
                dreptunghi.culoare = Color.Black;
                dreptunghi.draw(pctDesen,graphics);

                figuri.Add(dreptunghi);
                //ct ++;
            }

            pctDesen.BackgroundImage = bitmap;

            for(int i = 0; i < figuri.Count; i++)
            {
                cmbTranslatare.Items.Add(figuri[i].Nume);
                //MessageBox.Show(figuri[i].Nume);
            }

            if (ct >= 0)
            {
                this.cmbTranslatare.Visible = true;
                this.cmbTranslatare.SelectedIndex = 0;
            }
            ct++;
        }

        private void translate(int X, int Y) 
        { 
            if (figuraSelectata != null)
            {
                figuraSelectata.translatare(X, Y);
                RefreshPictureBox();
            }
        }

        private void btnsTran_Click(object sender, EventArgs e)
        {
            int x, y;
            if (figuraSelectata is Cerc)
            {
                Cerc cerc = (Cerc)figuraSelectata;

                x = int.Parse(tranCercX.Text);
                y = int.Parse(tranCercY.Text);
                translate(x, y);
            }
            else if (figuraSelectata is Linie)
            {
                Linie linie = (Linie)figuraSelectata;

                x = int.Parse(tranLinieX.Text);
                y = int.Parse(tranLinieY.Text);
                translate(x, y);
            }
            else if (figuraSelectata is Dreptunghi)
            {
                Dreptunghi d = (Dreptunghi)figuraSelectata;

                x = int.Parse(tranDrepX.Text);
                y = int.Parse(tranDrepY.Text);
                translate(x, y);
            }

           RefreshPictureBox();

        }

        private void btnsDublicare_Click(object sender, EventArgs e) {

            Graphics graphics = Graphics.FromImage(bitmap);


            if (figuraSelectata is Cerc)
            {
                Cerc cerc = (Cerc)figuraSelectata;
                Cerc cerc1 = new Cerc(cerc.Raza,cerc.Punct, "cerc" + ct.ToString());
                cerc1.draw(pctDesen, graphics);
                figuri.Add(cerc1);
            }
            else if (figuraSelectata is Linie)
            {
                Linie l = (Linie)figuraSelectata;
                Linie l1 = new Linie(l.Punct1,l.Punct2,"linie" + ct.ToString());
                l1.draw(pctDesen, graphics);
                figuri.Add(l1);
            }
            else if (figuraSelectata is Dreptunghi)
            {
                Dreptunghi d = (Dreptunghi)figuraSelectata;
                Dreptunghi d1 = new Dreptunghi(d.Punct1,d.Width,d.Height,"dreptunghi" + ct.ToString());
                d1.draw(pctDesen, graphics);
                figuri.Add(d1);
            }

            cmbTranslatare.Items.Add(figuri[figuri.Count - 1]);
            MessageBox.Show("S-a duplicat");
            RefreshPictureBox();
            ct++;
        }

        private void btnsStergere_Click(object sender, EventArgs e) {

            cmbTranslatare.Items.Clear();

            figuri.Remove(figuraSelectata);
            for (int i = 0; i < figuri.Count; i++)
            {
                cmbTranslatare.Items.Add(figuri[i].Nume);
                //MessageBox.Show(figuri[i].Nume);
            }
            RefreshPictureBox();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 1)
            {
               // this.grpLinie.BringToFront();
                this.grpLinie.Visible = true;
                this.grpCerc.Visible = false;
                this.grpDreptunghi.Visible = false;
               // this.grpLinie.BringToFront();
                grpLinie.Visible = true;

            }
            else if(comboBox1.SelectedItem.ToString() == "Cerc")
            {
                this.grpCerc.Visible = true;
                this.grpDreptunghi.Visible = false;
                this.grpLinie.Visible = false;
            }
            else if(comboBox1.SelectedItem.ToString() == "Dreptunghi")
            {
                this.grpCerc.Visible = false;
                this.grpDreptunghi.Visible = true;
                this.grpLinie.Visible = false;

            }
        }

        private void RefreshPictureBox()
        {
            bitmap = new Bitmap(pctDesen.Width, pctDesen.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            foreach (Figura figura in figuri)
            {
                 // MessageBox.Show(figura.Nume.ToString());
                if (figura is Cerc)
                {
                    Cerc cerc = (Cerc)figura;
                    cerc.draw(pctDesen, graphics);
                }
                else if (figura is Linie)
                {
                    Linie linie = (Linie)figura;
                    linie.draw(pctDesen, graphics);
                }
                else if (figura is Dreptunghi)
                {
                    Dreptunghi d = (Dreptunghi)figura;
                    d.draw(pctDesen, graphics);
                }
            }

            pctDesen.BackgroundImage = bitmap;
           // pctDesen.Refresh();
        }

        private void cmbTranslatare_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cmbTranslatare.SelectedItem.ToString();

            foreach (Figura figura in figuri)
            {
              // MessageBox.Show(figura.Nume + "  " + figuraSelectataString);
                if (figura.Nume == select)
                { 
                    figuraSelectata = figura;
                   // MessageBox.Show(figura.Nume);
                    figuraSelectata.culoare = Color.Red;
                    RefreshPictureBox();

                    if (select.Remove(4) == "cerc")
                    {
                        this.grpTranLinie.Visible = false;
                        this.grpTranCerc.Visible = true;
                        this.grpTranDreptunghi.Visible = false;

                    }
                    else if (select.Remove(5) == "linie")
                    {
                        this.grpTranCerc.Visible = false;
                        this.grpTranDreptunghi.Visible = false;
                        this.grpTranLinie.Visible = true;
                    }
                    else if (select.Remove(10) == "dreptunghi")
                    {
                        this.grpTranCerc.Visible = false;
                        this.grpTranDreptunghi.Visible = true;
                        this.grpTranLinie.Visible = false;

                    }

                    for (int i = 0; i < figuri.Count; i++)
                    {
                        if (figuri[i] != figuraSelectata)
                        {
                            figuri[i].culoare = Color.Black;
                        }
                    }
                    RefreshPictureBox();
                    break;
                }
            }

            RefreshPictureBox();
        }

    }
}
