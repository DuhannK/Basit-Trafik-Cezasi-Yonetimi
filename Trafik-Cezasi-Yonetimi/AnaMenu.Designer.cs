namespace Trafik_Cezasi_Yonetimi
{
    partial class AnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            this.btnCezaSorgulama = new System.Windows.Forms.Button();
            this.btnCezaIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCezaSorgulama
            // 
            this.btnCezaSorgulama.BackColor = System.Drawing.Color.IndianRed;
            this.btnCezaSorgulama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCezaSorgulama.Location = new System.Drawing.Point(310, 143);
            this.btnCezaSorgulama.Name = "btnCezaSorgulama";
            this.btnCezaSorgulama.Size = new System.Drawing.Size(180, 47);
            this.btnCezaSorgulama.TabIndex = 0;
            this.btnCezaSorgulama.Text = "Ceza Sorgulama";
            this.btnCezaSorgulama.UseVisualStyleBackColor = false;
            this.btnCezaSorgulama.Click += new System.EventHandler(this.btnCezaSorgulama_Click);
            // 
            // btnCezaIslemleri
            // 
            this.btnCezaIslemleri.BackColor = System.Drawing.Color.IndianRed;
            this.btnCezaIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCezaIslemleri.Location = new System.Drawing.Point(310, 196);
            this.btnCezaIslemleri.Name = "btnCezaIslemleri";
            this.btnCezaIslemleri.Size = new System.Drawing.Size(180, 47);
            this.btnCezaIslemleri.TabIndex = 1;
            this.btnCezaIslemleri.Text = "Ceza İşlemleri";
            this.btnCezaIslemleri.UseVisualStyleBackColor = false;
            this.btnCezaIslemleri.Click += new System.EventHandler(this.btnCezaIslemleri_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCezaIslemleri);
            this.Controls.Add(this.btnCezaSorgulama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaMenu";
            this.Text = "AnaMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCezaSorgulama;
        private System.Windows.Forms.Button btnCezaIslemleri;
    }
}