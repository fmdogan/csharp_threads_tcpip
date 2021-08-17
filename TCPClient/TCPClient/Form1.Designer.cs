namespace TCPClient
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
            this.sayi1_text = new System.Windows.Forms.RichTextBox();
            this.sayi2_text = new System.Windows.Forms.RichTextBox();
            this.islemler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sonuc_text = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IP_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sayi1_text
            // 
            this.sayi1_text.Location = new System.Drawing.Point(68, 81);
            this.sayi1_text.Name = "sayi1_text";
            this.sayi1_text.Size = new System.Drawing.Size(70, 24);
            this.sayi1_text.TabIndex = 0;
            this.sayi1_text.Text = "";
            this.sayi1_text.TextChanged += new System.EventHandler(this.sayi1_text_TextChanged);
            // 
            // sayi2_text
            // 
            this.sayi2_text.Location = new System.Drawing.Point(250, 81);
            this.sayi2_text.Name = "sayi2_text";
            this.sayi2_text.Size = new System.Drawing.Size(70, 24);
            this.sayi2_text.TabIndex = 1;
            this.sayi2_text.Text = "";
            this.sayi2_text.Visible = false;
            this.sayi2_text.TextChanged += new System.EventHandler(this.sayi2_text_TextChanged);
            // 
            // islemler
            // 
            this.islemler.FormattingEnabled = true;
            this.islemler.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "faktoriyel",
            "fibonacci"});
            this.islemler.Location = new System.Drawing.Point(144, 81);
            this.islemler.Name = "islemler";
            this.islemler.Size = new System.Drawing.Size(100, 24);
            this.islemler.TabIndex = 2;
            this.islemler.Text = "İşlem seç";
            this.islemler.SelectedIndexChanged += new System.EventHandler(this.islemler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // sonuc_text
            // 
            this.sonuc_text.Enabled = false;
            this.sonuc_text.Location = new System.Drawing.Point(348, 81);
            this.sonuc_text.Name = "sonuc_text";
            this.sonuc_text.Size = new System.Drawing.Size(99, 24);
            this.sonuc_text.TabIndex = 4;
            this.sonuc_text.Text = "Sonuç";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(144, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server IP:";
            // 
            // IP_label
            // 
            this.IP_label.AutoSize = true;
            this.IP_label.Location = new System.Drawing.Point(89, 13);
            this.IP_label.Name = "IP_label";
            this.IP_label.Size = new System.Drawing.Size(52, 17);
            this.IP_label.TabIndex = 7;
            this.IP_label.Text = "0.0.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 226);
            this.Controls.Add(this.IP_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sonuc_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.islemler);
            this.Controls.Add(this.sayi2_text);
            this.Controls.Add(this.sayi1_text);
            this.Name = "Form1";
            this.Text = "Hesapla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox sayi1_text;
        private System.Windows.Forms.RichTextBox sayi2_text;
        private System.Windows.Forms.ComboBox islemler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox sonuc_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IP_label;
    }
}

