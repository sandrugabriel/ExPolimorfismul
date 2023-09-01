namespace View.Mockups
{
    partial class MockupCard
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
            this.components = new System.ComponentModel.Container();
            this.pctDesign = new System.Windows.Forms.PictureBox();
            this.pctFavorite = new System.Windows.Forms.PictureBox();
            this.pctLike = new System.Windows.Forms.PictureBox();
            this.pctDesen = new System.Windows.Forms.PictureBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctDesign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDesen)).BeginInit();
            this.SuspendLayout();
            // 
            // pctDesign
            // 
            this.pctDesign.Location = new System.Drawing.Point(0, 196);
            this.pctDesign.Name = "pctDesign";
            this.pctDesign.Size = new System.Drawing.Size(332, 2);
            this.pctDesign.TabIndex = 12;
            this.pctDesign.TabStop = false;
            // 
            // pctFavorite
            // 
            this.pctFavorite.BackColor = System.Drawing.Color.Transparent;
            this.pctFavorite.Image = global::View.Properties.Resources.favorite__2_2;
            this.pctFavorite.Location = new System.Drawing.Point(199, 203);
            this.pctFavorite.Name = "pctFavorite";
            this.pctFavorite.Size = new System.Drawing.Size(56, 48);
            this.pctFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFavorite.TabIndex = 10;
            this.pctFavorite.TabStop = false;
            // 
            // pctLike
            // 
            this.pctLike.BackColor = System.Drawing.Color.Transparent;
            this.pctLike.Image = global::View.Properties.Resources.like__2_3;
            this.pctLike.Location = new System.Drawing.Point(78, 203);
            this.pctLike.Name = "pctLike";
            this.pctLike.Size = new System.Drawing.Size(56, 48);
            this.pctLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLike.TabIndex = 11;
            this.pctLike.TabStop = false;
            // 
            // pctDesen
            // 
            this.pctDesen.Location = new System.Drawing.Point(12, 12);
            this.pctDesen.Name = "pctDesen";
            this.pctDesen.Size = new System.Drawing.Size(308, 137);
            this.pctDesen.TabIndex = 13;
            this.pctDesen.TabStop = false;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.Color.Transparent;
            this.lblNume.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNume.Location = new System.Drawing.Point(86, 157);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(156, 27);
            this.lblNume.TabIndex = 14;
            this.lblNume.Text = "Nume Desen";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.pctDesen;
            // 
            // MockupCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::View.Properties.Resources.gradient__2_1;
            this.ClientSize = new System.Drawing.Size(332, 254);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.pctDesen);
            this.Controls.Add(this.pctDesign);
            this.Controls.Add(this.pctFavorite);
            this.Controls.Add(this.pctLike);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MockupCard";
            this.Text = "MockupCard";
            ((System.ComponentModel.ISupportInitialize)(this.pctDesign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDesen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctDesign;
        private System.Windows.Forms.PictureBox pctFavorite;
        private System.Windows.Forms.PictureBox pctLike;
        private System.Windows.Forms.PictureBox pctDesen;
        private System.Windows.Forms.Label lblNume;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}