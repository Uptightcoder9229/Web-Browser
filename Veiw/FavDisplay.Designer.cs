namespace CW1_IP.Veiw
{
    partial class FavDisplay
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
            this.FavDisp = new System.Windows.Forms.RichTextBox();
            this.EditFav = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveDis = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UrlFav = new System.Windows.Forms.TextBox();
            this.NameFav = new System.Windows.Forms.TextBox();
            this.ModifyFav = new System.Windows.Forms.Button();
            this.RemoveFav = new System.Windows.Forms.Button();
            this.CloseBut = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FavDisp
            // 
            this.FavDisp.Location = new System.Drawing.Point(63, 93);
            this.FavDisp.Name = "FavDisp";
            this.FavDisp.ReadOnly = true;
            this.FavDisp.Size = new System.Drawing.Size(622, 329);
            this.FavDisp.TabIndex = 0;
            this.FavDisp.Text = "";
            this.FavDisp.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.FavDisp_LinkClicked);
            this.FavDisp.TextChanged += new System.EventHandler(this.FavDisp_TextChanged);
            // 
            // EditFav
            // 
            this.EditFav.Location = new System.Drawing.Point(597, 30);
            this.EditFav.Name = "EditFav";
            this.EditFav.Size = new System.Drawing.Size(88, 38);
            this.EditFav.TabIndex = 1;
            this.EditFav.Text = "Edit";
            this.EditFav.UseVisualStyleBackColor = true;
            this.EditFav.Click += new System.EventHandler(this.EditFav_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemoveDis);
            this.panel2.Location = new System.Drawing.Point(63, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 0);
            this.panel2.TabIndex = 3;
            // 
            // RemoveDis
            // 
            this.RemoveDis.Location = new System.Drawing.Point(3, 3);
            this.RemoveDis.Name = "RemoveDis";
            this.RemoveDis.Size = new System.Drawing.Size(569, 305);
            this.RemoveDis.TabIndex = 0;
            this.RemoveDis.Text = "";
            this.RemoveDis.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RemoveDis_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseBut);
            this.panel1.Controls.Add(this.UrlFav);
            this.panel1.Controls.Add(this.NameFav);
            this.panel1.Controls.Add(this.ModifyFav);
            this.panel1.Controls.Add(this.RemoveFav);
            this.panel1.Location = new System.Drawing.Point(41, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 0);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UrlFav
            // 
            this.UrlFav.Location = new System.Drawing.Point(22, 32);
            this.UrlFav.Name = "UrlFav";
            this.UrlFav.Size = new System.Drawing.Size(348, 20);
            this.UrlFav.TabIndex = 6;
            this.UrlFav.TextChanged += new System.EventHandler(this.UrlFav_TextChanged);
            // 
            // NameFav
            // 
            this.NameFav.Location = new System.Drawing.Point(22, 6);
            this.NameFav.Name = "NameFav";
            this.NameFav.Size = new System.Drawing.Size(348, 20);
            this.NameFav.TabIndex = 5;
            this.NameFav.TextChanged += new System.EventHandler(this.NameFav_TextChanged);
            // 
            // ModifyFav
            // 
            this.ModifyFav.Location = new System.Drawing.Point(391, 30);
            this.ModifyFav.Name = "ModifyFav";
            this.ModifyFav.Size = new System.Drawing.Size(75, 23);
            this.ModifyFav.TabIndex = 1;
            this.ModifyFav.Text = "Modify";
            this.ModifyFav.UseVisualStyleBackColor = true;
            this.ModifyFav.Click += new System.EventHandler(this.ModifyFav_Click);
            // 
            // RemoveFav
            // 
            this.RemoveFav.Location = new System.Drawing.Point(391, 6);
            this.RemoveFav.Name = "RemoveFav";
            this.RemoveFav.Size = new System.Drawing.Size(75, 23);
            this.RemoveFav.TabIndex = 0;
            this.RemoveFav.Text = "Remove";
            this.RemoveFav.UseVisualStyleBackColor = true;
            this.RemoveFav.Click += new System.EventHandler(this.RemoveFav_Click);
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(472, 22);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(46, 29);
            this.CloseBut.TabIndex = 7;
            this.CloseBut.Text = "Close";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // FavDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EditFav);
            this.Controls.Add(this.FavDisp);
            this.Name = "FavDisplay";
            this.Text = "Favourite";
            this.Load += new System.EventHandler(this.FavDisplay_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox FavDisp;
        private System.Windows.Forms.Button EditFav;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox RemoveDis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ModifyFav;
        private System.Windows.Forms.Button RemoveFav;
        private System.Windows.Forms.TextBox NameFav;
        private System.Windows.Forms.TextBox UrlFav;
        private System.Windows.Forms.Button CloseBut;
    }
}