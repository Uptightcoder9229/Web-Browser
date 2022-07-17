namespace CW1_IP.Veiw
{
    partial class Browser
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
            this.URLEnter = new System.Windows.Forms.TextBox();
            this.GoBut = new System.Windows.Forms.Button();
            this.FavButt = new System.Windows.Forms.Button();
            this.DisplayMain = new System.Windows.Forms.RichTextBox();
            this.TitleDis = new System.Windows.Forms.TextBox();
            this.StatusDis = new System.Windows.Forms.TextBox();
            this.HomeButt = new System.Windows.Forms.Button();
            this.SettingsView = new System.Windows.Forms.Button();
            this.DropDon = new System.Windows.Forms.Panel();
            this.ExitSet = new System.Windows.Forms.Button();
            this.HomeSet = new System.Windows.Forms.Button();
            this.FavSet = new System.Windows.Forms.Button();
            this.HistSet = new System.Windows.Forms.Button();
            this.BackButt = new System.Windows.Forms.Button();
            this.ForButt = new System.Windows.Forms.Button();
            this.RefrButt = new System.Windows.Forms.Button();
            this.DropDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLEnter
            // 
            this.URLEnter.Location = new System.Drawing.Point(271, 49);
            this.URLEnter.Name = "URLEnter";
            this.URLEnter.Size = new System.Drawing.Size(497, 20);
            this.URLEnter.TabIndex = 0;
            // 
            // GoBut
            // 
            this.GoBut.Location = new System.Drawing.Point(774, 38);
            this.GoBut.Name = "GoBut";
            this.GoBut.Size = new System.Drawing.Size(40, 40);
            this.GoBut.TabIndex = 1;
            this.GoBut.UseVisualStyleBackColor = true;
            this.GoBut.Click += new System.EventHandler(this.GoButt_Click);
            // 
            // FavButt
            // 
            this.FavButt.Location = new System.Drawing.Point(820, 38);
            this.FavButt.Name = "FavButt";
            this.FavButt.Size = new System.Drawing.Size(40, 40);
            this.FavButt.TabIndex = 2;
            this.FavButt.UseVisualStyleBackColor = true;
            this.FavButt.Click += new System.EventHandler(this.FavButt_Click);
            // 
            // DisplayMain
            // 
            this.DisplayMain.Location = new System.Drawing.Point(50, 136);
            this.DisplayMain.Name = "DisplayMain";
            this.DisplayMain.ReadOnly = true;
            this.DisplayMain.Size = new System.Drawing.Size(844, 344);
            this.DisplayMain.TabIndex = 3;
            this.DisplayMain.Text = "";
            this.DisplayMain.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.DisplayMain_LinkClicked);
            // 
            // TitleDis
            // 
            this.TitleDis.Location = new System.Drawing.Point(360, 78);
            this.TitleDis.Name = "TitleDis";
            this.TitleDis.ReadOnly = true;
            this.TitleDis.Size = new System.Drawing.Size(129, 20);
            this.TitleDis.TabIndex = 4;
            // 
            // StatusDis
            // 
            this.StatusDis.Location = new System.Drawing.Point(591, 78);
            this.StatusDis.Name = "StatusDis";
            this.StatusDis.ReadOnly = true;
            this.StatusDis.Size = new System.Drawing.Size(129, 20);
            this.StatusDis.TabIndex = 5;
            this.StatusDis.TextChanged += new System.EventHandler(this.StatusDis_TextChanged);
            // 
            // HomeButt
            // 
            this.HomeButt.Location = new System.Drawing.Point(520, 78);
            this.HomeButt.Name = "HomeButt";
            this.HomeButt.Size = new System.Drawing.Size(40, 40);
            this.HomeButt.TabIndex = 6;
            this.HomeButt.UseVisualStyleBackColor = true;
            this.HomeButt.Click += new System.EventHandler(this.HomeButt_Click);
            // 
            // SettingsView
            // 
            this.SettingsView.Location = new System.Drawing.Point(0, 0);
            this.SettingsView.Name = "SettingsView";
            this.SettingsView.Size = new System.Drawing.Size(87, 40);
            this.SettingsView.TabIndex = 7;
            this.SettingsView.Text = "Veiw\r\n";
            this.SettingsView.UseVisualStyleBackColor = true;
            this.SettingsView.Click += new System.EventHandler(this.SettingsView_Click);
            // 
            // DropDon
            // 
            this.DropDon.Controls.Add(this.ExitSet);
            this.DropDon.Controls.Add(this.HomeSet);
            this.DropDon.Controls.Add(this.FavSet);
            this.DropDon.Controls.Add(this.SettingsView);
            this.DropDon.Controls.Add(this.HistSet);
            this.DropDon.Location = new System.Drawing.Point(12, 12);
            this.DropDon.Name = "DropDon";
            this.DropDon.Size = new System.Drawing.Size(87, 41);
            this.DropDon.TabIndex = 8;
            // 
            // ExitSet
            // 
            this.ExitSet.Location = new System.Drawing.Point(0, 184);
            this.ExitSet.Name = "ExitSet";
            this.ExitSet.Size = new System.Drawing.Size(87, 40);
            this.ExitSet.TabIndex = 9;
            this.ExitSet.Text = "Exit";
            this.ExitSet.UseVisualStyleBackColor = true;
            this.ExitSet.Click += new System.EventHandler(this.ExitSet_Click);
            // 
            // HomeSet
            // 
            this.HomeSet.Location = new System.Drawing.Point(0, 138);
            this.HomeSet.Name = "HomeSet";
            this.HomeSet.Size = new System.Drawing.Size(87, 40);
            this.HomeSet.TabIndex = 9;
            this.HomeSet.Text = "Add Home";
            this.HomeSet.UseVisualStyleBackColor = true;
            this.HomeSet.Click += new System.EventHandler(this.HomeSet_Click);
            // 
            // FavSet
            // 
            this.FavSet.Location = new System.Drawing.Point(0, 92);
            this.FavSet.Name = "FavSet";
            this.FavSet.Size = new System.Drawing.Size(87, 40);
            this.FavSet.TabIndex = 9;
            this.FavSet.Text = "Favourites";
            this.FavSet.UseVisualStyleBackColor = true;
            this.FavSet.Click += new System.EventHandler(this.FavSet_Click);
            // 
            // HistSet
            // 
            this.HistSet.Location = new System.Drawing.Point(0, 46);
            this.HistSet.Name = "HistSet";
            this.HistSet.Size = new System.Drawing.Size(87, 40);
            this.HistSet.TabIndex = 9;
            this.HistSet.Text = "History";
            this.HistSet.UseVisualStyleBackColor = true;
            this.HistSet.Click += new System.EventHandler(this.HistSet_Click);
            // 
            // BackButt
            // 
            this.BackButt.Location = new System.Drawing.Point(133, 38);
            this.BackButt.Name = "BackButt";
            this.BackButt.Size = new System.Drawing.Size(40, 40);
            this.BackButt.TabIndex = 9;
            this.BackButt.UseVisualStyleBackColor = true;
            this.BackButt.Click += new System.EventHandler(this.ForButt_Click);
            // 
            // ForButt
            // 
            this.ForButt.Location = new System.Drawing.Point(225, 38);
            this.ForButt.Name = "ForButt";
            this.ForButt.Size = new System.Drawing.Size(40, 40);
            this.ForButt.TabIndex = 10;
            this.ForButt.UseVisualStyleBackColor = true;
            this.ForButt.Click += new System.EventHandler(this.BackButt_Click);
            // 
            // RefrButt
            // 
            this.RefrButt.Location = new System.Drawing.Point(179, 38);
            this.RefrButt.Name = "RefrButt";
            this.RefrButt.Size = new System.Drawing.Size(40, 40);
            this.RefrButt.TabIndex = 11;
            this.RefrButt.UseVisualStyleBackColor = true;
            this.RefrButt.Click += new System.EventHandler(this.RefrButt_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 492);
            this.Controls.Add(this.RefrButt);
            this.Controls.Add(this.ForButt);
            this.Controls.Add(this.BackButt);
            this.Controls.Add(this.DropDon);
            this.Controls.Add(this.HomeButt);
            this.Controls.Add(this.StatusDis);
            this.Controls.Add(this.TitleDis);
            this.Controls.Add(this.DisplayMain);
            this.Controls.Add(this.FavButt);
            this.Controls.Add(this.GoBut);
            this.Controls.Add(this.URLEnter);
            this.Name = "Browser";
            this.Text = "Browser";
            this.Load += new System.EventHandler(this.Browser_Load);
            this.DropDon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLEnter;                  
        private System.Windows.Forms.Button GoBut;
        private System.Windows.Forms.Button FavButt;
        private System.Windows.Forms.RichTextBox DisplayMain;
        private System.Windows.Forms.TextBox TitleDis;
        private System.Windows.Forms.TextBox StatusDis;
        private System.Windows.Forms.Button HomeButt;
        private System.Windows.Forms.Button SettingsView;
        private System.Windows.Forms.Panel DropDon;
        private System.Windows.Forms.Button HistSet;
        private System.Windows.Forms.Button ExitSet;
        private System.Windows.Forms.Button HomeSet;
        private System.Windows.Forms.Button FavSet;
        private System.Windows.Forms.Button BackButt;
        private System.Windows.Forms.Button ForButt;
        private System.Windows.Forms.Button RefrButt;
    }
}