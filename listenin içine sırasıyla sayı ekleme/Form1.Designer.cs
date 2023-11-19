namespace listenin_içine_sırasıyla_sayı_ekleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSaydir = new System.Windows.Forms.ListBox();
            this.btnSay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSaydir
            // 
            this.lbSaydir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSaydir.FormattingEnabled = true;
            this.lbSaydir.ItemHeight = 16;
            this.lbSaydir.Location = new System.Drawing.Point(12, 12);
            this.lbSaydir.Name = "lbSaydir";
            this.lbSaydir.Size = new System.Drawing.Size(241, 340);
            this.lbSaydir.TabIndex = 0;
            // 
            // btnSay
            // 
            this.btnSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSay.Location = new System.Drawing.Point(282, 12);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(154, 149);
            this.btnSay.TabIndex = 1;
            this.btnSay.Text = "10 ar saydır";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSay);
            this.Controls.Add(this.lbSaydir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSaydir;
        private System.Windows.Forms.Button btnSay;
    }
}

