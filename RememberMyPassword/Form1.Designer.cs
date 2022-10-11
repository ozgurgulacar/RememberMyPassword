namespace RememberMyPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtadı = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.btnemail = new System.Windows.Forms.Button();
            this.btnkaydol = new System.Windows.Forms.Button();
            this.btnunut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail Adresiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(86, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mailinize Gelen Kodu Giriniz";
            this.label3.Visible = false;
            // 
            // txtadı
            // 
            this.txtadı.Location = new System.Drawing.Point(239, 64);
            this.txtadı.Name = "txtadı";
            this.txtadı.Size = new System.Drawing.Size(122, 22);
            this.txtadı.TabIndex = 3;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(239, 119);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(122, 22);
            this.txtsifre.TabIndex = 4;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(144, 304);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(108, 22);
            this.txtemail.TabIndex = 5;
            this.txtemail.Visible = false;
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(111, 158);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(88, 42);
            this.btngiris.TabIndex = 6;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // btnemail
            // 
            this.btnemail.Location = new System.Drawing.Point(156, 353);
            this.btnemail.Name = "btnemail";
            this.btnemail.Size = new System.Drawing.Size(88, 42);
            this.btnemail.TabIndex = 7;
            this.btnemail.Text = "Doğrula";
            this.btnemail.UseVisualStyleBackColor = true;
            this.btnemail.Visible = false;
            this.btnemail.Click += new System.EventHandler(this.btnemail_Click);
            // 
            // btnkaydol
            // 
            this.btnkaydol.Location = new System.Drawing.Point(216, 158);
            this.btnkaydol.Name = "btnkaydol";
            this.btnkaydol.Size = new System.Drawing.Size(88, 42);
            this.btnkaydol.TabIndex = 8;
            this.btnkaydol.Text = "Kaydol";
            this.btnkaydol.UseVisualStyleBackColor = true;
            this.btnkaydol.Click += new System.EventHandler(this.btnkaydol_Click);
            // 
            // btnunut
            // 
            this.btnunut.Location = new System.Drawing.Point(159, 206);
            this.btnunut.Name = "btnunut";
            this.btnunut.Size = new System.Drawing.Size(88, 42);
            this.btnunut.TabIndex = 9;
            this.btnunut.Text = "Şifremi Unuttum";
            this.btnunut.UseVisualStyleBackColor = true;
            this.btnunut.Click += new System.EventHandler(this.btnunut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(399, 434);
            this.Controls.Add(this.btnunut);
            this.Controls.Add(this.btnkaydol);
            this.Controls.Add(this.btnemail);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtadı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtadı;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button btnemail;
        private System.Windows.Forms.Button btnkaydol;
        private System.Windows.Forms.Button btnunut;
    }
}

