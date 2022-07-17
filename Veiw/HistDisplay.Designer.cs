namespace CW1_IP.Veiw
{
    partial class HistDisplay
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
            this.HistDis = new System.Windows.Forms.RichTextBox();
            this.ClearHis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HistDis
            // 
            this.HistDis.Location = new System.Drawing.Point(70, 103);
            this.HistDis.Name = "HistDis";
            this.HistDis.ReadOnly = true;
            this.HistDis.Size = new System.Drawing.Size(694, 305);
            this.HistDis.TabIndex = 0;
            this.HistDis.Text = "";
            this.HistDis.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.HistDis_LinkClicked);
            // 
            // ClearHis
            // 
            this.ClearHis.Location = new System.Drawing.Point(644, 26);
            this.ClearHis.Name = "ClearHis";
            this.ClearHis.Size = new System.Drawing.Size(110, 41);
            this.ClearHis.TabIndex = 1;
            this.ClearHis.Text = "Clear History";
            this.ClearHis.UseVisualStyleBackColor = true;
            this.ClearHis.Click += new System.EventHandler(this.ClearHis_Click);
            // 
            // HistDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.ClearHis);
            this.Controls.Add(this.HistDis);
            this.Name = "HistDisplay";
            this.Text = "History";
            this.Load += new System.EventHandler(this.HistDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox HistDis;
        private System.Windows.Forms.Button ClearHis;
    }
}