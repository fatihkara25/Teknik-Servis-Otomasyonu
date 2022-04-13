
namespace Teknik_Servis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.btn_Kayit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Giris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // linkSifremiUnuttum
            // 
            this.linkSifremiUnuttum.AutoSize = true;
            this.linkSifremiUnuttum.Location = new System.Drawing.Point(196, 349);
            this.linkSifremiUnuttum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkSifremiUnuttum.Name = "linkSifremiUnuttum";
            this.linkSifremiUnuttum.Size = new System.Drawing.Size(78, 13);
            this.linkSifremiUnuttum.TabIndex = 57;
            this.linkSifremiUnuttum.TabStop = true;
            this.linkSifremiUnuttum.Text = "SifremiUnuttum";
            // 
            // btn_Kayit
            // 
            this.btn_Kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kayit.Location = new System.Drawing.Point(412, 319);
            this.btn_Kayit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Kayit.Name = "btn_Kayit";
            this.btn_Kayit.Size = new System.Drawing.Size(110, 37);
            this.btn_Kayit.TabIndex = 56;
            this.btn_Kayit.Text = "Kayıt Ol";
            this.btn_Kayit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(297, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 31);
            this.label3.TabIndex = 55;
            this.label3.Text = "Teknik Servis Otomasyonu";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(355, 198);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(239, 28);
            this.txt_sifre.TabIndex = 54;
            this.txt_sifre.Text = "1907";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Email.Location = new System.Drawing.Point(355, 140);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(239, 28);
            this.txt_Email.TabIndex = 53;
            this.txt_Email.Text = "igazi696@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(298, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(298, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Email:";
            // 
            // btn_Giris
            // 
            this.btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.Location = new System.Drawing.Point(412, 258);
            this.btn_Giris.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(110, 37);
            this.btn_Giris.TabIndex = 50;
            this.btn_Giris.Text = "Giriş Yap";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkSifremiUnuttum);
            this.Controls.Add(this.btn_Kayit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Giris);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkSifremiUnuttum;
        private System.Windows.Forms.Button btn_Kayit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Giris;
    }
}

