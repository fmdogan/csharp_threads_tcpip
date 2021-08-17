namespace TCPServer
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
            this.gelenMesajText = new System.Windows.Forms.RichTextBox();
            this.sonucText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IP_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gelenMesajText
            // 
            this.gelenMesajText.Enabled = false;
            this.gelenMesajText.Location = new System.Drawing.Point(93, 78);
            this.gelenMesajText.Name = "gelenMesajText";
            this.gelenMesajText.Size = new System.Drawing.Size(136, 24);
            this.gelenMesajText.TabIndex = 0;
            this.gelenMesajText.Text = "";
            // 
            // sonucText
            // 
            this.sonucText.Enabled = false;
            this.sonucText.Location = new System.Drawing.Point(235, 78);
            this.sonucText.Name = "sonucText";
            this.sonucText.Size = new System.Drawing.Size(136, 24);
            this.sonucText.TabIndex = 1;
            this.sonucText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gelen Mesaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sonuç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "İşlem bekleniyor.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sunucuyu başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client IP:";
            // 
            // IP_label
            // 
            this.IP_label.AutoSize = true;
            this.IP_label.Location = new System.Drawing.Point(82, 13);
            this.IP_label.Name = "IP_label";
            this.IP_label.Size = new System.Drawing.Size(52, 17);
            this.IP_label.TabIndex = 7;
            this.IP_label.Text = "0.0.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 179);
            this.Controls.Add(this.IP_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sonucText);
            this.Controls.Add(this.gelenMesajText);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox gelenMesajText;
        private System.Windows.Forms.RichTextBox sonucText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IP_label;
    }
}

