using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controllers;
using View.Models;

namespace View.Panels
{
    internal class PnlAdd : Panel
    {

        Form1 form;
        Client client;

        Bitmap bitmap;
        List<Figura> figuri;
        private int ct;
        private Figura figuraSelectata;
        ControllerFigura controllerFigura;
        ControllerDetalii controllerDetalii;
        int idClient;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.PictureBox pctDesen;
        private System.Windows.Forms.ComboBox cmbTranslatare;
        private System.Windows.Forms.Button btnTranCerc;
        private System.Windows.Forms.NumericUpDown tranCercY;
        private System.Windows.Forms.NumericUpDown tranCercX;
        private System.Windows.Forms.Button btnTranLinie;
        private System.Windows.Forms.NumericUpDown tranLinieY;
        private System.Windows.Forms.NumericUpDown tranLinieX;
        private System.Windows.Forms.Button btnTranDreptunghi;
        private System.Windows.Forms.Button btnDubLinie;
        private System.Windows.Forms.Button btnDuplCerc;
        private System.Windows.Forms.Button btnDubDreptunghi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private System.Windows.Forms.Button btnStergereDesen;
        private System.Windows.Forms.Button btnTranDesen;
        private System.Windows.Forms.NumericUpDown desenY;
        private System.Windows.Forms.NumericUpDown desenX;
        private System.Windows.Forms.Button btnSalvare;
        private ZBobb.AlphaBlendTextBox txtDesen;
        private System.Windows.Forms.Panel grpTranDreptunghi;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown tranDrepY;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown tranDrepX;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel grpTranCerc;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel grpTranLinie;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel grpDesen;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label37;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse9;
        private System.Windows.Forms.Panel grpDreptunghi;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ZBobb.AlphaBlendTextBox txtDrept;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown dreptY;
        private System.Windows.Forms.Button btnDreptunghi;
        private System.Windows.Forms.NumericUpDown dreptHeigth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown dreptWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown dreptX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel grpCerc;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnCerc;
        private ZBobb.AlphaBlendTextBox txtCerc;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown cercY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown cercX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown cercRaza;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel grpLinie;
        private System.Windows.Forms.PictureBox pictureBox7;
        private ZBobb.AlphaBlendTextBox txtLinie;
        private System.Windows.Forms.Button btnLinie;
        private System.Windows.Forms.NumericUpDown linieY1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown linieY;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown linieX1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown linieX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse10;
        private System.Windows.Forms.PictureBox pictureBox9;

        private string path;

        public PnlAdd(Form1 form1, Client client1)
        {

            form = form1;
            client = client1;
            this.form.Size = new System.Drawing.Size(1456, 749);

            path = Application.StartupPath + @"/data/imagini/";

            //PnlAdd
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::View.Properties.Resources.gradient__9_;
            this.Size = new System.Drawing.Size(1456, 749);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PnlAdd";

            idClient = client.Id;

            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse();
            this.pctDesen = new System.Windows.Forms.PictureBox();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse();
            this.grpCerc = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnCerc = new System.Windows.Forms.Button();
            this.txtCerc = new ZBobb.AlphaBlendTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cercY = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cercX = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cercRaza = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse();
            this.grpDreptunghi = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtDrept = new ZBobb.AlphaBlendTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.dreptY = new System.Windows.Forms.NumericUpDown();
            this.btnDreptunghi = new System.Windows.Forms.Button();
            this.dreptHeigth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dreptWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dreptX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse();
            this.grpLinie = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtLinie = new ZBobb.AlphaBlendTextBox();
            this.btnLinie = new System.Windows.Forms.Button();
            this.linieY1 = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.linieY = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.linieX1 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.linieX = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTranslatare = new System.Windows.Forms.ComboBox();
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse();
            this.grpTranCerc = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tranCercY = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.tranCercX = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.btnDuplCerc = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.btnTranCerc = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse();
            this.grpTranDreptunghi = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDubDreptunghi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTranDreptunghi = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.tranDrepY = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tranDrepX = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse();
            this.grpTranLinie = new System.Windows.Forms.Panel();
            this.tranLinieY = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.tranLinieX = new System.Windows.Forms.NumericUpDown();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnDubLinie = new System.Windows.Forms.Button();
            this.btnTranLinie = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtDesen = new ZBobb.AlphaBlendTextBox();
            this.bunifuElipse9 = new Bunifu.Framework.UI.BunifuElipse();
            this.grpDesen = new System.Windows.Forms.Panel();
            this.btnTranDesen = new System.Windows.Forms.Button();
            this.btnStergereDesen = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.desenY = new System.Windows.Forms.NumericUpDown();
            this.desenX = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse10 = new Bunifu.Framework.UI.BunifuElipse();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();

            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.grpDesen);
            this.Controls.Add(this.grpTranLinie);
            this.Controls.Add(this.grpTranCerc);
            this.Controls.Add(this.grpTranDreptunghi);
            this.Controls.Add(this.grpDreptunghi);
            this.Controls.Add(this.grpCerc);
            this.Controls.Add(this.grpLinie);
            this.Controls.Add(this.txtDesen);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbTranslatare);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pctDesen);

            // comboBox1
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
"Circle",
"Line",
"Rectangle"});
            this.comboBox1.Location = new System.Drawing.Point(72, 59);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 33);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            
            // bunifuElipse1
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
             
            // bunifuElipse2
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.pctDesen;
             
            // pctDesen
            this.pctDesen.BackColor = System.Drawing.SystemColors.Control;
            this.pctDesen.Location = new System.Drawing.Point(425, 79);
            this.pctDesen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pctDesen.Name = "pctDesen";
            this.pctDesen.Size = new System.Drawing.Size(1006, 649);
            this.pctDesen.TabIndex = 11;
            this.pctDesen.TabStop = false;
             
            // bunifuElipse3
            this.bunifuElipse3.ElipseRadius = 35;
            this.bunifuElipse3.TargetControl = this.grpCerc;
             
            // grpCerc
            this.grpCerc.BackgroundImage = Image.FromFile(path + "gradient3.png");
            this.grpCerc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpCerc.Controls.Add(this.pictureBox6);
            this.grpCerc.Controls.Add(this.btnCerc);
            this.grpCerc.Controls.Add(this.txtCerc);
            this.grpCerc.Controls.Add(this.label27);
            this.grpCerc.Controls.Add(this.cercY);
            this.grpCerc.Controls.Add(this.label11);
            this.grpCerc.Controls.Add(this.cercX);
            this.grpCerc.Controls.Add(this.label12);
            this.grpCerc.Controls.Add(this.cercRaza);
            this.grpCerc.Controls.Add(this.label9);
            this.grpCerc.Controls.Add(this.label8);
            this.grpCerc.ForeColor = System.Drawing.SystemColors.Control;
            this.grpCerc.Location = new System.Drawing.Point(19, 108);
            this.grpCerc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpCerc.Name = "grpCerc";
            this.grpCerc.Size = new System.Drawing.Size(361, 275);
            this.grpCerc.TabIndex = 14;
             
            // pictureBox6
            this.pictureBox6.Location = new System.Drawing.Point(-2, 45);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(360, 2);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
             
            // btnCerc
            this.btnCerc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCerc.BackgroundImage = Image.FromFile(path + "gradient2.png");
            this.btnCerc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerc.FlatAppearance.BorderSize = 0;
            this.btnCerc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerc.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerc.Location = new System.Drawing.Point(0, 226);
            this.btnCerc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCerc.Name = "btnCerc";
            this.btnCerc.Size = new System.Drawing.Size(361, 49);
            this.btnCerc.TabIndex = 5;
            this.btnCerc.Text = "Draw";
            this.btnCerc.UseVisualStyleBackColor = false;
            this.btnCerc.Click += new System.EventHandler(this.btns_Click);
             
            // txtCerc
            this.txtCerc.BackAlpha = 10;
            this.txtCerc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCerc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCerc.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCerc.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCerc.Location = new System.Drawing.Point(65, 180);
            this.txtCerc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCerc.Name = "txtCerc";
            this.txtCerc.Size = new System.Drawing.Size(241, 29);
            this.txtCerc.TabIndex = 13;
            this.txtCerc.Text = "Name of the Circle";
            this.txtCerc.Enter += new System.EventHandler(this.txtCerc_Enter);
            this.txtCerc.Leave += new System.EventHandler(this.txtCerc_Leve);
             
            // label27
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.Control;
            this.label27.Location = new System.Drawing.Point(136, 2);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(88, 37);
            this.label27.TabIndex = 3;
            this.label27.Text = "Circle";
             
            // cercY
            this.cercY.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cercY.Location = new System.Drawing.Point(106, 123);
            this.cercY.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cercY.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.cercY.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.cercY.Name = "cercY";
            this.cercY.Size = new System.Drawing.Size(58, 28);
            this.cercY.TabIndex = 4;
            
            // label11
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 27);
            this.label11.TabIndex = 3;
            this.label11.Text = "The point";
             
            // cercX
            this.cercX.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cercX.Location = new System.Drawing.Point(106, 84);
            this.cercX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cercX.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.cercX.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.cercX.Name = "cercX";
            this.cercX.Size = new System.Drawing.Size(58, 28);
            this.cercX.TabIndex = 4;
            
            // label12
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(60, 85);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 27);
            this.label12.TabIndex = 3;
            this.label12.Text = "X=";
             
            // cercRaza
            this.cercRaza.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cercRaza.Location = new System.Drawing.Point(205, 103);
            this.cercRaza.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cercRaza.Maximum = new decimal(new int[] {
1000,
0,
0,
0});
            this.cercRaza.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.cercRaza.Name = "cercRaza";
            this.cercRaza.Size = new System.Drawing.Size(58, 28);
            this.cercRaza.TabIndex = 4;
            
            // label9
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(204, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "Radius";
             
            // label8
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 27);
            this.label8.TabIndex = 3;
            this.label8.Text = "Y=";
             
            // bunifuElipse4
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this.grpDreptunghi;
             
            // grpDreptunghi
            this.grpDreptunghi.BackgroundImage = Image.FromFile(path + "gradient3.png");
            this.grpDreptunghi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpDreptunghi.Controls.Add(this.pictureBox4);
            this.grpDreptunghi.Controls.Add(this.txtDrept);
            this.grpDreptunghi.Controls.Add(this.label28);
            this.grpDreptunghi.Controls.Add(this.dreptY);
            this.grpDreptunghi.Controls.Add(this.btnDreptunghi);
            this.grpDreptunghi.Controls.Add(this.dreptHeigth);
            this.grpDreptunghi.Controls.Add(this.label3);
            this.grpDreptunghi.Controls.Add(this.dreptWidth);
            this.grpDreptunghi.Controls.Add(this.label1);
            this.grpDreptunghi.Controls.Add(this.dreptX);
            this.grpDreptunghi.Controls.Add(this.label5);
            this.grpDreptunghi.Controls.Add(this.label2);
            this.grpDreptunghi.Controls.Add(this.label19);
            this.grpDreptunghi.ForeColor = System.Drawing.SystemColors.Control;
            this.grpDreptunghi.Location = new System.Drawing.Point(19, 108);
            this.grpDreptunghi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpDreptunghi.Name = "grpDreptunghi";
            this.grpDreptunghi.Size = new System.Drawing.Size(361, 275);
            this.grpDreptunghi.TabIndex = 14;
             
            // pictureBox4
            this.pictureBox4.Location = new System.Drawing.Point(3, 45);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(360, 2);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
             
            // txtDrept
            this.txtDrept.BackAlpha = 10;
            this.txtDrept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDrept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDrept.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrept.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDrept.Location = new System.Drawing.Point(38, 180);
            this.txtDrept.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDrept.Name = "txtDrept";
            this.txtDrept.Size = new System.Drawing.Size(299, 29);
            this.txtDrept.TabIndex = 13;
            this.txtDrept.Text = "Name of the Rectangle";
            this.txtDrept.Enter += new System.EventHandler(this.txtDpret_Enter);
            this.txtDrept.Leave += new System.EventHandler(this.txtDrpet_Leve);
             
            // label28
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.Control;
            this.label28.Location = new System.Drawing.Point(92, 2);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(177, 37);
            this.label28.TabIndex = 3;
            this.label28.Text = "Rectangle";
             
            // dreptY
            this.dreptY.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dreptY.Location = new System.Drawing.Point(82, 129);
            this.dreptY.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dreptY.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.dreptY.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.dreptY.Name = "dreptY";
            this.dreptY.Size = new System.Drawing.Size(58, 28);
            this.dreptY.TabIndex = 4;
             
            // btnDreptunghi
            this.btnDreptunghi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDreptunghi.BackgroundImage = Image.FromFile(path + "gradient2.png");
            this.btnDreptunghi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDreptunghi.FlatAppearance.BorderSize = 0;
            this.btnDreptunghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDreptunghi.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDreptunghi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDreptunghi.Location = new System.Drawing.Point(0, 226);
            this.btnDreptunghi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDreptunghi.Name = "btnDreptunghi";
            this.btnDreptunghi.Size = new System.Drawing.Size(361, 49);
            this.btnDreptunghi.TabIndex = 5;
            this.btnDreptunghi.Text = "Draw";
            this.btnDreptunghi.UseVisualStyleBackColor = false;
            this.btnDreptunghi.Click += new System.EventHandler(this.btns_Click);
             
            // dreptHeigth
            this.dreptHeigth.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dreptHeigth.Location = new System.Drawing.Point(180, 123);
            this.dreptHeigth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dreptHeigth.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.dreptHeigth.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.dreptHeigth.Name = "dreptHeigth";
            this.dreptHeigth.Size = new System.Drawing.Size(58, 28);
            this.dreptHeigth.TabIndex = 4;
             
            // label3
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "The point";
             
            // dreptWidth
            this.dreptWidth.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dreptWidth.Location = new System.Drawing.Point(278, 124);
            this.dreptWidth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dreptWidth.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.dreptWidth.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.dreptWidth.Name = "dreptWidth";
            this.dreptWidth.Size = new System.Drawing.Size(58, 28);
            this.dreptWidth.TabIndex = 4;
             
            // label1
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "X=";
             
            // dreptX
            this.dreptX.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dreptX.Location = new System.Drawing.Point(82, 91);
            this.dreptX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dreptX.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.dreptX.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.dreptX.Name = "dreptX";
            this.dreptX.Size = new System.Drawing.Size(58, 28);
            this.dreptX.TabIndex = 4;
             
            // label5
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Height";
            
            // label2
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y=";
            
            // label19
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(176, 84);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 27);
            this.label19.TabIndex = 3;
            this.label19.Text = "Width";
             
            // bunifuElipse5
            this.bunifuElipse5.ElipseRadius = 30;
            this.bunifuElipse5.TargetControl = this.grpLinie;
             
            // grpLinie
            this.grpLinie.BackgroundImage = Image.FromFile(path + "gradient3.png");
            this.grpLinie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpLinie.Controls.Add(this.pictureBox7);
            this.grpLinie.Controls.Add(this.txtLinie);
            this.grpLinie.Controls.Add(this.btnLinie);
            this.grpLinie.Controls.Add(this.linieY1);
            this.grpLinie.Controls.Add(this.label23);
            this.grpLinie.Controls.Add(this.label13);
            this.grpLinie.Controls.Add(this.linieY);
            this.grpLinie.Controls.Add(this.label16);
            this.grpLinie.Controls.Add(this.linieX1);
            this.grpLinie.Controls.Add(this.label15);
            this.grpLinie.Controls.Add(this.linieX);
            this.grpLinie.Controls.Add(this.label14);
            this.grpLinie.Controls.Add(this.label7);
            this.grpLinie.Controls.Add(this.label10);
            this.grpLinie.ForeColor = System.Drawing.SystemColors.Control;
            this.grpLinie.Location = new System.Drawing.Point(19, 108);
            this.grpLinie.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpLinie.Name = "grpLinie";
            this.grpLinie.Size = new System.Drawing.Size(361, 275);
            this.grpLinie.TabIndex = 14;
             
            // pictureBox7
            this.pictureBox7.Location = new System.Drawing.Point(0, 45);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(360, 2);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
             
            // txtLinie
            this.txtLinie.BackAlpha = 10;
            this.txtLinie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLinie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLinie.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinie.ForeColor = System.Drawing.SystemColors.Control;
            this.txtLinie.Location = new System.Drawing.Point(60, 180);
            this.txtLinie.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLinie.Name = "txtLinie";
            this.txtLinie.Size = new System.Drawing.Size(241, 29);
            this.txtLinie.TabIndex = 13;
            this.txtLinie.Text = "Name of the Line";
            this.txtLinie.Enter += new System.EventHandler(this.txtLinie_enter);
            this.txtLinie.Leave += new System.EventHandler(this.txtLinie_Leve);
             
            // btnLinie
            this.btnLinie.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLinie.BackgroundImage = Image.FromFile(path + "gradient2.png");
            this.btnLinie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLinie.FlatAppearance.BorderSize = 0;
            this.btnLinie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinie.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinie.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLinie.Location = new System.Drawing.Point(0, 226);
            this.btnLinie.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLinie.Name = "btnLinie";
            this.btnLinie.Size = new System.Drawing.Size(361, 49);
            this.btnLinie.TabIndex = 5;
            this.btnLinie.Text = "Draw";
            this.btnLinie.UseVisualStyleBackColor = false;
            this.btnLinie.Click += new System.EventHandler(this.btns_Click);
             
            // linieY1
            this.linieY1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linieY1.Location = new System.Drawing.Point(246, 136);
            this.linieY1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.linieY1.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.linieY1.Minimum = new decimal(new int[] {
10000,
0,
0,
-2147483648});
            this.linieY1.Name = "linieY1";
            this.linieY1.Size = new System.Drawing.Size(58, 28);
            this.linieY1.TabIndex = 4;
             
            // label23
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.Control;
            this.label23.Location = new System.Drawing.Point(140, 2);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 37);
            this.label23.TabIndex = 3;
            this.label23.Text = "Line";
             
            // label13
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(203, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 27);
            this.label13.TabIndex = 3;
            this.label13.Text = "Point 2";
             
            // linieY
            this.linieY.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linieY.Location = new System.Drawing.Point(103, 133);
            this.linieY.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.linieY.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.linieY.Minimum = new decimal(new int[] {
10000,
0,
0,
-2147483648});
            this.linieY.Name = "linieY";
            this.linieY.Size = new System.Drawing.Size(58, 28);
            this.linieY.TabIndex = 4;
             
            // label16
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(58, 94);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 27);
            this.label16.TabIndex = 3;
            this.label16.Text = "X=";
             
            // linieX1
            this.linieX1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linieX1.Location = new System.Drawing.Point(246, 91);
            this.linieX1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.linieX1.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.linieX1.Minimum = new decimal(new int[] {
10000,
0,
0,
-2147483648});
            this.linieX1.Name = "linieX1";
            this.linieX1.Size = new System.Drawing.Size(58, 28);
            this.linieX1.TabIndex = 4;
            
            // label15
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(60, 50);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 27);
            this.label15.TabIndex = 3;
            this.label15.Text = "Point 1";
             
            // linieX
            this.linieX.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linieX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.linieX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linieX.Location = new System.Drawing.Point(103, 94);
            this.linieX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.linieX.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.linieX.Minimum = new decimal(new int[] {
10000,
0,
0,
-2147483648});
            this.linieX.Name = "linieX";
            this.linieX.Size = new System.Drawing.Size(58, 28);
            this.linieX.TabIndex = 4;
            
            // label14
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(200, 94);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 27);
            this.label14.TabIndex = 3;
            this.label14.Text = "X=";
             
            // label7
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(200, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 27);
            this.label7.TabIndex = 3;
            this.label7.Text = "Y=";
             
            // label10
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(58, 133);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 27);
            this.label10.TabIndex = 3;
            this.label10.Text = "Y=";
            
            // cmbTranslatare
            this.cmbTranslatare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTranslatare.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.cmbTranslatare.FormattingEnabled = true;
            this.cmbTranslatare.Location = new System.Drawing.Point(72, 428);
            this.cmbTranslatare.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTranslatare.Name = "cmbTranslatare";
            this.cmbTranslatare.Size = new System.Drawing.Size(261, 33);
            this.cmbTranslatare.TabIndex = 6;
            this.cmbTranslatare.Visible = false;
            this.cmbTranslatare.SelectedIndexChanged += new System.EventHandler(this.cmbTranslatare_SelectedIndexChanged);
             
            // bunifuElipse6
            this.bunifuElipse6.ElipseRadius = 30;
            this.bunifuElipse6.TargetControl = this.grpTranCerc;
             
            // grpTranCerc
            this.grpTranCerc.BackgroundImage = Image.FromFile(path + "gradient3.png");
            this.grpTranCerc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpTranCerc.Controls.Add(this.pictureBox3);
            this.grpTranCerc.Controls.Add(this.tranCercY);
            this.grpTranCerc.Controls.Add(this.button1);
            this.grpTranCerc.Controls.Add(this.tranCercX);
            this.grpTranCerc.Controls.Add(this.label26);
            this.grpTranCerc.Controls.Add(this.btnDuplCerc);
            this.grpTranCerc.Controls.Add(this.label29);
            this.grpTranCerc.Controls.Add(this.btnTranCerc);
            this.grpTranCerc.Controls.Add(this.label30);
            this.grpTranCerc.Controls.Add(this.label34);
            this.grpTranCerc.ForeColor = System.Drawing.SystemColors.Control;
            this.grpTranCerc.Location = new System.Drawing.Point(22, 490);
            this.grpTranCerc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpTranCerc.Name = "grpTranCerc";
            this.grpTranCerc.Size = new System.Drawing.Size(361, 238);
            this.grpTranCerc.TabIndex = 14;
            this.grpTranCerc.Visible = false;
             
            // pictureBox3
            this.pictureBox3.Location = new System.Drawing.Point(0, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(360, 2);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
             
            // tranCercY
            this.tranCercY.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tranCercY.Location = new System.Drawing.Point(245, 85);
            this.tranCercY.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tranCercY.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.tranCercY.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.tranCercY.Name = "tranCercY";
            this.tranCercY.Size = new System.Drawing.Size(58, 28);
            this.tranCercY.TabIndex = 4;
            
            // button1
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(182, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnsStergere_Click);
             
            // tranCercX
            this.tranCercX.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tranCercX.Location = new System.Drawing.Point(107, 87);
            this.tranCercX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tranCercX.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.tranCercX.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.tranCercX.Name = "tranCercX";
            this.tranCercX.Size = new System.Drawing.Size(58, 28);
            this.tranCercX.TabIndex = 4;
             
            // label26
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.Control;
            this.label26.Location = new System.Drawing.Point(136, 2);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(88, 37);
            this.label26.TabIndex = 3;
            this.label26.Text = "Circle";
             
            // btnDuplCerc
            this.btnDuplCerc.BackColor = System.Drawing.Color.Transparent;
            this.btnDuplCerc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuplCerc.FlatAppearance.BorderSize = 0;
            this.btnDuplCerc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuplCerc.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuplCerc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDuplCerc.Location = new System.Drawing.Point(0, 160);
            this.btnDuplCerc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDuplCerc.Name = "btnDuplCerc";
            this.btnDuplCerc.Size = new System.Drawing.Size(184, 40);
            this.btnDuplCerc.TabIndex = 6;
            this.btnDuplCerc.Text = "Duplicate";
            this.btnDuplCerc.UseVisualStyleBackColor = false;
            this.btnDuplCerc.Click += new System.EventHandler(this.btnsDublicare_Click);
             
            // label29
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(55, 53);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(95, 27);
            this.label29.TabIndex = 3;
            this.label29.Text = "The point";
             
            // btnTranCerc
            this.btnTranCerc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTranCerc.BackgroundImage = Image.FromFile(path + "gradient2.png");
            this.btnTranCerc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTranCerc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTranCerc.FlatAppearance.BorderSize = 0;
            this.btnTranCerc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranCerc.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranCerc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTranCerc.Location = new System.Drawing.Point(0, 198);
            this.btnTranCerc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTranCerc.Name = "btnTranCerc";
            this.btnTranCerc.Size = new System.Drawing.Size(361, 40);
            this.btnTranCerc.TabIndex = 5;
            this.btnTranCerc.Text = "Translation";
            this.btnTranCerc.UseVisualStyleBackColor = false;
            this.btnTranCerc.Click += new System.EventHandler(this.btnsTran_Click);
            
            // label30
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(55, 87);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 27);
            this.label30.TabIndex = 3;
            this.label30.Text = "X=";
             
            // label34
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(201, 86);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(40, 27);
            this.label34.TabIndex = 3;
            this.label34.Text = "Y=";
             
            // bunifuElipse7
            this.bunifuElipse7.ElipseRadius = 30;
            this.bunifuElipse7.TargetControl = this.grpTranDreptunghi;

            // grpTranDreptunghi
            this.grpTranDreptunghi.BackgroundImage = Image.FromFile(path + "gradient3.png");
            this.grpTranDreptunghi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpTranDreptunghi.Controls.Add(this.pictureBox2);
            this.grpTranDreptunghi.Controls.Add(this.btnDubDreptunghi);
            this.grpTranDreptunghi.Controls.Add(this.button3);
            this.grpTranDreptunghi.Controls.Add(this.btnTranDreptunghi);
            this.grpTranDreptunghi.Controls.Add(this.label31);
            this.grpTranDreptunghi.Controls.Add(this.tranDrepY);
            this.grpTranDreptunghi.Controls.Add(this.label32);
            this.grpTranDreptunghi.Controls.Add(this.label33);
            this.grpTranDreptunghi.Controls.Add(this.tranDrepX);
            this.grpTranDreptunghi.Controls.Add(this.label35);
            this.grpTranDreptunghi.ForeColor = System.Drawing.SystemColors.Control;
            this.grpTranDreptunghi.Location = new System.Drawing.Point(22, 490);
            this.grpTranDreptunghi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpTranDreptunghi.Name = "grpTranDreptunghi";
            this.grpTranDreptunghi.Size = new System.Drawing.Size(361, 238);
            this.grpTranDreptunghi.TabIndex = 14;
            this.grpTranDreptunghi.Visible = false;
             
            // pictureBox2
            this.pictureBox2.Location = new System.Drawing.Point(0, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 2);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
             
            // btnDubDreptunghi
            this.btnDubDreptunghi.BackColor = System.Drawing.Color.Transparent;
            this.btnDubDreptunghi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDubDreptunghi.FlatAppearance.BorderSize = 0;
            this.btnDubDreptunghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDubDreptunghi.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDubDreptunghi.Location = new System.Drawing.Point(0, 156);
            this.btnDubDreptunghi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDubDreptunghi.Name = "btnDubDreptunghi";
            this.btnDubDreptunghi.Size = new System.Drawing.Size(181, 40);
            this.btnDubDreptunghi.TabIndex = 6;
            this.btnDubDreptunghi.Text = "Duplicate";
            this.btnDubDreptunghi.UseVisualStyleBackColor = false;
            this.btnDubDreptunghi.Click += new System.EventHandler(this.btnsDublicare_Click);
             
            // button3
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(185, 156);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnsStergere_Click);
            
            // btnTranDreptunghi
            this.btnTranDreptunghi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTranDreptunghi.BackgroundImage = Image.FromFile(path + "gradient2.png");
            this.btnTranDreptunghi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTranDreptunghi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTranDreptunghi.FlatAppearance.BorderSize = 0;
            this.btnTranDreptunghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranDreptunghi.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranDreptunghi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTranDreptunghi.Location = new System.Drawing.Point(0, 198);
            this.btnTranDreptunghi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTranDreptunghi.Name = "btnTranDreptunghi";
            this.btnTranDreptunghi.Size = new System.Drawing.Size(361, 40);
            this.btnTranDreptunghi.TabIndex = 5;
            this.btnTranDreptunghi.Text = "Translation";
            this.btnTranDreptunghi.UseVisualStyleBackColor = false;
            this.btnTranDreptunghi.Click += new System.EventHandler(this.btnsTran_Click);
             
            // label31
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.Control;
            this.label31.Location = new System.Drawing.Point(92, 4);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(177, 37);
            this.label31.TabIndex = 3;
            this.label31.Text = "Rectangle";
             
            // tranDrepY
            this.tranDrepY.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tranDrepY.Location = new System.Drawing.Point(244, 86);
            this.tranDrepY.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tranDrepY.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.tranDrepY.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.tranDrepY.Name = "tranDrepY";
            this.tranDrepY.Size = new System.Drawing.Size(58, 28);
            this.tranDrepY.TabIndex = 4;
            
            // label32
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(55, 53);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 27);
            this.label32.TabIndex = 3;
            this.label32.Text = "The point";
             
            // label33
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(55, 87);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(42, 27);
            this.label33.TabIndex = 3;
            this.label33.Text = "X=";
             
            // tranDrepX
            this.tranDrepX.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tranDrepX.Location = new System.Drawing.Point(102, 87);
            this.tranDrepX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tranDrepX.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.tranDrepX.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.tranDrepX.Name = "tranDrepX";
            this.tranDrepX.Size = new System.Drawing.Size(58, 28);
            this.tranDrepX.TabIndex = 4;
             
            // label35
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(201, 86);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(40, 27);
            this.label35.TabIndex = 3;
            this.label35.Text = "Y=";
             
            // bunifuElipse8
            this.bunifuElipse8.ElipseRadius = 30;
            this.bunifuElipse8.TargetControl = this.grpTranLinie;
             
            // grpTranLinie
            this.grpTranLinie.BackgroundImage = Image.FromFile(path + "gradient3.png");
            this.grpTranLinie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpTranLinie.Controls.Add(this.tranLinieY);
            this.grpTranLinie.Controls.Add(this.button2);
            this.grpTranLinie.Controls.Add(this.tranLinieX);
            this.grpTranLinie.Controls.Add(this.pictureBox5);
            this.grpTranLinie.Controls.Add(this.btnDubLinie);
            this.grpTranLinie.Controls.Add(this.btnTranLinie);
            this.grpTranLinie.Controls.Add(this.label4);
            this.grpTranLinie.Controls.Add(this.label17);
            this.grpTranLinie.Controls.Add(this.label18);
            this.grpTranLinie.Controls.Add(this.label36);
            this.grpTranLinie.ForeColor = System.Drawing.SystemColors.Control;
            this.grpTranLinie.Location = new System.Drawing.Point(22, 490);
            this.grpTranLinie.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpTranLinie.Name = "grpTranLinie";
            this.grpTranLinie.Size = new System.Drawing.Size(361, 238);
            this.grpTranLinie.TabIndex = 14;
            this.grpTranLinie.Visible = false;
            
            // tranLinieY
            this.tranLinieY.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tranLinieY.Location = new System.Drawing.Point(245, 87);
            this.tranLinieY.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tranLinieY.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.tranLinieY.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.tranLinieY.Name = "tranLinieY";
            this.tranLinieY.Size = new System.Drawing.Size(58, 28);
            this.tranLinieY.TabIndex = 4;
            
            // button2
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(177, 160);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnsStergere_Click);
            
            // tranLinieX
            this.tranLinieX.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tranLinieX.Location = new System.Drawing.Point(101, 88);
            this.tranLinieX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tranLinieX.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.tranLinieX.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.tranLinieX.Name = "tranLinieX";
            this.tranLinieX.Size = new System.Drawing.Size(58, 28);
            this.tranLinieX.TabIndex = 4;
             
            // pictureBox5
            this.pictureBox5.Location = new System.Drawing.Point(0, 46);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(360, 2);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            
            // btnDubLinie
            this.btnDubLinie.BackColor = System.Drawing.Color.Transparent;
            this.btnDubLinie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDubLinie.FlatAppearance.BorderSize = 0;
            this.btnDubLinie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDubLinie.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDubLinie.Location = new System.Drawing.Point(0, 160);
            this.btnDubLinie.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDubLinie.Name = "btnDubLinie";
            this.btnDubLinie.Size = new System.Drawing.Size(184, 40);
            this.btnDubLinie.TabIndex = 6;
            this.btnDubLinie.Text = "Duplicate";
            this.btnDubLinie.UseVisualStyleBackColor = false;
            this.btnDubLinie.Click += new System.EventHandler(this.btnsDublicare_Click);
            
            // btnTranLinie
            this.btnTranLinie.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTranLinie.BackgroundImage = Image.FromFile(path + "gradient2.png");
            this.btnTranLinie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTranLinie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTranLinie.FlatAppearance.BorderSize = 0;
            this.btnTranLinie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranLinie.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranLinie.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTranLinie.Location = new System.Drawing.Point(0, 198);
            this.btnTranLinie.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTranLinie.Name = "btnTranLinie";
            this.btnTranLinie.Size = new System.Drawing.Size(361, 40);
            this.btnTranLinie.TabIndex = 5;
            this.btnTranLinie.Text = "Translation";
            this.btnTranLinie.UseVisualStyleBackColor = false;
            this.btnTranLinie.Click += new System.EventHandler(this.btnsTran_Click);
             
            // label4
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(140, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Line";
             
            // label17
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(55, 53);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 27);
            this.label17.TabIndex = 3;
            this.label17.Text = "The point";
            
            // label18
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(55, 87);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 27);
            this.label18.TabIndex = 3;
            this.label18.Text = "X=";
             
            // label36
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(201, 86);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(40, 27);
            this.label36.TabIndex = 3;
            this.label36.Text = "Y=";
             
            // txtDesen
            this.txtDesen.BackAlpha = 10;
            this.txtDesen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDesen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesen.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDesen.Location = new System.Drawing.Point(557, 18);
            this.txtDesen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDesen.Name = "txtDesen";
            this.txtDesen.Size = new System.Drawing.Size(374, 37);
            this.txtDesen.TabIndex = 13;
            this.txtDesen.Text = "Name of the Drawing";
            this.txtDesen.Enter += new System.EventHandler(this.txtDesen_enter);
            this.txtDesen.Leave += new System.EventHandler(this.txtDesen_Leve);
             
            // bunifuElipse9
            this.bunifuElipse9.ElipseRadius = 30;
            this.bunifuElipse9.TargetControl = this.grpDesen;
             
            // grpDesen
            this.grpDesen.BackgroundImage = Image.FromFile(path + "gradient3.png");
            this.grpDesen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpDesen.Controls.Add(this.btnTranDesen);
            this.grpDesen.Controls.Add(this.btnStergereDesen);
            this.grpDesen.Controls.Add(this.pictureBox8);
            this.grpDesen.Controls.Add(this.desenY);
            this.grpDesen.Controls.Add(this.desenX);
            this.grpDesen.Controls.Add(this.label21);
            this.grpDesen.Controls.Add(this.label24);
            this.grpDesen.Controls.Add(this.label25);
            this.grpDesen.Controls.Add(this.label37);
            this.grpDesen.ForeColor = System.Drawing.SystemColors.Control;
            this.grpDesen.Location = new System.Drawing.Point(22, 490);
            this.grpDesen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpDesen.Name = "grpDesen";
            this.grpDesen.Size = new System.Drawing.Size(361, 238);
            this.grpDesen.TabIndex = 14;
            this.grpDesen.Visible = false;
             
            // btnTranDesen
            this.btnTranDesen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTranDesen.BackgroundImage = Image.FromFile(path + "gradient2.png");
            this.btnTranDesen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTranDesen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTranDesen.FlatAppearance.BorderSize = 0;
            this.btnTranDesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranDesen.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranDesen.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTranDesen.Location = new System.Drawing.Point(0, 198);
            this.btnTranDesen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTranDesen.Name = "btnTranDesen";
            this.btnTranDesen.Size = new System.Drawing.Size(361, 40);
            this.btnTranDesen.TabIndex = 5;
            this.btnTranDesen.Text = "Translation";
            this.btnTranDesen.UseVisualStyleBackColor = false;
            this.btnTranDesen.Click += new System.EventHandler(this.btnTranslatare_Click);
             
            // btnStergereDesen
            this.btnStergereDesen.BackColor = System.Drawing.Color.Transparent;
            this.btnStergereDesen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStergereDesen.FlatAppearance.BorderSize = 0;
            this.btnStergereDesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergereDesen.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergereDesen.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStergereDesen.Location = new System.Drawing.Point(0, 158);
            this.btnStergereDesen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStergereDesen.Name = "btnStergereDesen";
            this.btnStergereDesen.Size = new System.Drawing.Size(361, 40);
            this.btnStergereDesen.TabIndex = 7;
            this.btnStergereDesen.Text = "Clear";
            this.btnStergereDesen.UseVisualStyleBackColor = false;
            this.btnStergereDesen.Click += new System.EventHandler(this.btnStergere_Click);
            
            // pictureBox8
            this.pictureBox8.Location = new System.Drawing.Point(0, 46);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(360, 2);
             
            // desenY
            this.desenY.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.desenY.Location = new System.Drawing.Point(245, 86);
            this.desenY.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.desenY.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.desenY.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.desenY.Name = "desenY";
            this.desenY.Size = new System.Drawing.Size(58, 28);
            this.desenY.TabIndex = 4;
             
            // desenX
            this.desenX.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.desenX.Location = new System.Drawing.Point(101, 85);
            this.desenX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.desenX.Maximum = new decimal(new int[] {
10000,
0,
0,
0});
            this.desenX.Minimum = new decimal(new int[] {
1000,
0,
0,
-2147483648});
            this.desenX.Name = "desenX";
            this.desenX.Size = new System.Drawing.Size(58, 28);
            this.desenX.TabIndex = 4;
             
            // label21
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.Location = new System.Drawing.Point(114, 2);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 37);
            this.label21.TabIndex = 3;
            this.label21.Text = "Drawing";
             
            // label24
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(55, 53);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 27);
            this.label24.TabIndex = 3;
            this.label24.Text = "The point";
             
            // label25
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(55, 87);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 27);
            this.label25.TabIndex = 3;
            this.label25.Text = "X=";
             
            // label37
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(201, 86);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(40, 27);
            this.label37.TabIndex = 3;
            this.label37.Text = "Y=";
             
            // btnSalvare
            this.btnSalvare.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalvare.BackgroundImage = Image.FromFile(path + "gradient2.png");
            this.btnSalvare.FlatAppearance.BorderSize = 0;
            this.btnSalvare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvare.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvare.Location = new System.Drawing.Point(1143, 9);
            this.btnSalvare.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(202, 59);
            this.btnSalvare.TabIndex = 12;
            this.btnSalvare.Text = "Save drawing";
            this.btnSalvare.UseVisualStyleBackColor = false;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvareDesen_Click);
             
            // pictureBox1
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = Image.FromFile(path + "close.png");
            this.pictureBox1.Location = new System.Drawing.Point(1411, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);

            // bunifuElipse10
            this.bunifuElipse10.ElipseRadius = 20;
            this.bunifuElipse10.TargetControl = this.btnSalvare;

            // pictureBox9
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox9.Location = new System.Drawing.Point(557, 61);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(374, 2);

            this.comboBox1.SelectedIndex = 0;
            bitmap = new Bitmap(pctDesen.Width, pctDesen.Height);
            figuri = new List<Figura>();
            ct = 0;

            controllerFigura = new ControllerFigura();
            controllerDetalii = new ControllerDetalii();

        }

        private void btns_Click(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(bitmap);

            cmbTranslatare.Items.Clear();

            int semn = 0;

            if (comboBox1.SelectedItem.ToString() == "Circle")
            {
                if (txtCerc.Text != "Name of the Circle")
                {
                    int x = int.Parse(cercX.Value.ToString());
                    int y = int.Parse(cercY.Value.ToString());
                    int raza = int.Parse(cercRaza.Value.ToString());

                    Punct punct = new Punct(x, y);
                    Cerc cerc = new Cerc("cerc", controllerFigura.generareId(), raza, punct, txtCerc.Text);
                    // MessageBox.Show("Name: "+cerc.Name);
                    cerc.culoare = Color.Black;
                    cerc.draw(pctDesen, graphics);
                    figuri.Add(cerc);
                    semn = 1;
                }
                else
                {
                    MessageBox.Show("You have not entered the name of the circle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //ct++;
            }
            else if (comboBox1.SelectedItem.ToString() == "Line")
            {
                if (txtLinie.Text != "Name of the Line")
                {
                    int x = int.Parse(linieX.Value.ToString());
                    int y = int.Parse(linieY.Value.ToString());
                    int x1 = int.Parse(linieX1.Value.ToString());
                    int y1 = int.Parse(linieY1.Value.ToString());

                    Punct punct = new Punct(x, y);
                    Punct punct1 = new Punct(x1, y1);

                    Linie linie = new Linie("linie", controllerFigura.generareId(), punct, punct1, txtLinie.Text);
                    linie.culoare = Color.Black;
                    linie.draw(pctDesen, graphics);
                    figuri.Add(linie);
                    semn = 1;
                }
                else
                {
                    MessageBox.Show("You have not entered the name of the line", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // ct++;
            }
            else if (comboBox1.SelectedItem.ToString() == "Rectangle")
            {
                if (txtDrept.Text != "Name of the Rectangle") {
                    int x = int.Parse(dreptX.Value.ToString());
                    int y = int.Parse(dreptY.Value.ToString());
                    int width = int.Parse(dreptWidth.Value.ToString());
                    int height = int.Parse(dreptHeigth.Value.ToString());

                    Punct punct = new Punct(x, y);
                    Dreptunghi dreptunghi = new Dreptunghi("dreptunghi", controllerFigura.generareId(), punct, width, height, txtDrept.Text);
                    dreptunghi.culoare = Color.Black;
                    dreptunghi.draw(pctDesen, graphics);

                    figuri.Add(dreptunghi);
                    semn = 1;
                }
                else
                {
                    MessageBox.Show("You have not entered the name of the rectangle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //ct ++;
            }

            if (semn == 1)
            {
                pctDesen.BackgroundImage = bitmap;

                for (int i = 0; i < figuri.Count; i++)
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


                if (ct >= 2)
                    this.cmbTranslatare.Items.Add("Drawing");

            }
          

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

        private void btnsDublicare_Click(object sender, EventArgs e)
        {

            Graphics graphics = Graphics.FromImage(bitmap);


            if (figuraSelectata is Cerc)
            {
                Cerc cerc = (Cerc)figuraSelectata;
                Cerc cerc1 = new Cerc("cerc", controllerFigura.generareId(), cerc.Raza, cerc.Punct, "cerc" + ct.ToString());
                cerc1.draw(pctDesen, graphics);
                figuri.Add(cerc1);
            }
            else if (figuraSelectata is Linie)
            {
                Linie l = (Linie)figuraSelectata;
                Linie l1 = new Linie("linie", controllerFigura.generareId(), l.Punct1, l.Punct2, "linie" + ct.ToString());
                l1.draw(pctDesen, graphics);
                figuri.Add(l1);
            }
            else if (figuraSelectata is Dreptunghi)
            {
                Dreptunghi d = (Dreptunghi)figuraSelectata;
                Dreptunghi d1 = new Dreptunghi("dreptunghi", controllerFigura.generareId(), d.Punct1, d.Width, d.Height, "dreptunghi" + ct.ToString());
                d1.draw(pctDesen, graphics);
                figuri.Add(d1);
            }

            cmbTranslatare.Items.Add(figuri[figuri.Count - 1]);
            MessageBox.Show("S-a duplicat");
            RefreshPictureBox();
            ct++;
        }

        private void btnsStergere_Click(object sender, EventArgs e)
        {

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
            this.form.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                // this.grpLinie.BringToFront();
                this.grpLinie.Visible = true;
                this.grpCerc.Visible = false;
                this.grpDreptunghi.Visible = false;
                // this.grpLinie.BringToFront();
                grpLinie.Visible = true;

            }
            else if (comboBox1.SelectedItem.ToString() == "Circle")
            {
                this.grpCerc.Visible = true;
                this.grpDreptunghi.Visible = false;
                this.grpLinie.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Rectangle")
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

            foreach (Figura figura1 in figuri)
            {
                figura1.culoare = Color.Black;
            }

            foreach (Figura figura in figuri)
            {
                if (figura.Nume == select)
                {
                    figuraSelectata = figura;
                    figuraSelectata.culoare = Color.Red;
                    RefreshPictureBox();

                    if (figuraSelectata.Type == "cerc")
                    {
                        this.grpTranLinie.Visible = false;
                        this.grpTranCerc.Visible = true;
                        this.grpTranDreptunghi.Visible = false;
                        this.grpDesen.Visible = false;

                    }
                    else if (figuraSelectata.Type == "linie")
                    {
                        this.grpTranCerc.Visible = false;
                        this.grpTranDreptunghi.Visible = false;
                        this.grpTranLinie.Visible = true;
                        this.grpDesen.Visible = false;
                    }
                    else if (figuraSelectata.Type == "dreptunghi")
                    {
                        this.grpTranCerc.Visible = false;
                        this.grpTranDreptunghi.Visible = true;
                        this.grpTranLinie.Visible = false;
                        this.grpDesen.Visible = false;
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

            if (select.Equals("Drawing"))
            {

                foreach (Figura fig in figuri)
                {
                    fig.culoare = Color.Red;
                    RefreshPictureBox();

                }


                this.grpTranCerc.Visible = false;
                this.grpTranDreptunghi.Visible = false;
                this.grpTranLinie.Visible = false;
                this.grpDesen.Visible = true;

            }

            RefreshPictureBox();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {

            this.figuri.Clear();

            this.cmbTranslatare.Items.Clear();

            RefreshPictureBox();

            this.grpDesen.Visible = false;
            this.cmbTranslatare.Visible = false;
        }

        private void btnTranslatare_Click(Object sender, EventArgs e)
        {

            foreach (Figura fig in figuri)
            {
                figuraSelectata = fig;
                int x = int.Parse(desenX.Value.ToString());
                int y = int.Parse(desenY.Value.ToString());

                if (fig is Cerc)
                {

                    Cerc cerc = (Cerc)fig;

                    translate(x, y);

                }
                else if (fig is Linie)
                {

                    Linie linie = (Linie)fig;

                    translate(x, y);
                }
                else if (fig is Dreptunghi)
                {
                    Dreptunghi dreptunghi = (Dreptunghi)fig;

                    translate(x, y);
                }
            }

            RefreshPictureBox();
        }

        private void txtLinie_enter(object sender, EventArgs e)
        {
            if (txtLinie.Text == "Name of the line")
            {
                this.txtLinie.ForeColor = SystemColors.Control;
                this.txtLinie.Text = "";
            }

            // MessageBox.Show("Asda");

        }

        private void txtLinie_Leve(object sender, EventArgs e)
        {
            if (txtLinie.Text.Equals(""))
            {
                this.txtLinie.Text = "Name of the line";
                this.txtLinie.ForeColor = SystemColors.Control;
            }
        }

        private void txtDesen_enter(object sender, EventArgs e)
        {
            if (txtDesen.Text == "Name of the Drawing")
            {
                this.txtDesen.ForeColor = Color.Black;
                this.txtDesen.Text = "";
            }
            // MessageBox.Show("Asda");

        }

        private void txtDesen_Leve(object sender, EventArgs e)
        {
            if (txtDesen.Text.Equals(""))
            {
                this.txtDesen.Text = "Name of the Drawing";
                this.txtDesen.ForeColor = Color.Black;
            }
        }

        private void txtCerc_Enter(object sender, EventArgs e)
        {
            if (txtCerc.Text == "Name of the Circle")
            {
                this.txtCerc.ForeColor = SystemColors.Control;
                this.txtCerc.Text = "";
            }
        }

        private void txtCerc_Leve(object sender, EventArgs e)
        {
            if (txtCerc.Text.Equals(""))
            {
                this.txtCerc.Text = "Name of the Circle";
                this.txtCerc.ForeColor = SystemColors.Control;
            }

        }

        private void txtDpret_Enter(object sender, EventArgs e)
        {
            if (txtDrept.Text == "Name of the Rectangle")
            {
                this.txtDrept.ForeColor = SystemColors.Control;
                this.txtDrept.Text = "";
            }

        }

        private void txtDrpet_Leve(object sender, EventArgs e)
        {

            if (txtDrept.Text.Equals(""))
            {
                this.txtDrept.Text = "Name of the Rectangle";
                this.txtDrept.ForeColor = SystemColors.Control;
            }
        }

        private void btnSalvareDesen_Click(object sender, EventArgs e)
        {
            if (txtDesen.Text != "Name of the Drawing")
            {
                for (int i = 0; i < figuri.Count; i++)
                {
                    string text = "";

                    if (figuri[i].Type.Equals("cerc"))
                    {
                        Cerc cerc = (Cerc)figuri[i];
                        text = $"cerc;{cerc.Id};{cerc.Nume};{cerc.Raza};{cerc.Punct.X};{cerc.Punct.Y}";
                    }
                    else if (figuri[i].Type.Equals("linie"))
                    {
                        Linie linie = (Linie)figuri[i];
                        text = $"linie;{linie.Id};{linie.Nume};{linie.Punct1.X};{linie.Punct1.Y};{linie.Punct2.X};{linie.Punct2.Y}";
                    }
                    else if (figuri[i].Type.Equals("dreptunghi"))
                    {
                        Dreptunghi drept = (Dreptunghi)figuri[i];
                        text = $"dreptunghi;{drept.Id};{drept.Nume};{drept.Punct1.X};{drept.Punct1.Y};{drept.Width};{drept.Height}";
                    }

                    controllerFigura.save(text);
                }

                string detali = $"{controllerDetalii.generareId()};{idClient};{txtDesen.Text};";
                for (int i = 0; i < figuri.Count; i++)
                {
                    if (i == figuri.Count - 1)
                    {
                        detali += figuri[i].Id;
                    }
                    else
                        detali += figuri[i].Id + ";";
                }

                controllerDetalii.save(detali);

            }
            else
            {
                MessageBox.Show("You have not entered the name of the drawing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
