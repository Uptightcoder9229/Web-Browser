namespace CW1_IP.Veiw
{
    partial class AddHomePG
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
            this.AddHg = new System.Windows.Forms.Button();
            this.HomeEnter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddHg
            // 
            this.AddHg.Location = new System.Drawing.Point(314, 43);
            this.AddHg.Name = "AddHg";
            this.AddHg.Size = new System.Drawing.Size(94, 24);
            this.AddHg.TabIndex = 0;
            this.AddHg.Text = "Change HomePage";
            this.AddHg.UseVisualStyleBackColor = true;
            this.AddHg.Click += new System.EventHandler(this.AddHg_Click);
            // 
            // HomeEnter
            // 
            this.HomeEnter.Location = new System.Drawing.Point(12, 43);
            this.HomeEnter.Name = "HomeEnter";
            this.HomeEnter.Size = new System.Drawing.Size(296, 20);
            this.HomeEnter.TabIndex = 1;
            this.HomeEnter.TextChanged += new System.EventHandler(this.HomeEnter_TextChanged);
            // 
            // AddHomePG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 100);
            this.Controls.Add(this.HomeEnter);
            this.Controls.Add(this.AddHg);
            this.Name = "AddHomePG";
            this.Text = "AddHomePG";
            this.Load += new System.EventHandler(this.AddHomePG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddHg;
        private System.Windows.Forms.TextBox HomeEnter;
    }
}