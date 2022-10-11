namespace RememberMyPassword
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtplatform = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncel = new System.Windows.Forms.Button();
            this.datamız = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRMP = new System.Windows.Forms.TextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.btngöster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnoner = new System.Windows.Forms.Button();
            this.lbloneri = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datamız)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Platform";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(7, 327);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(87, 42);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtplatform
            // 
            this.txtplatform.Location = new System.Drawing.Point(155, 162);
            this.txtplatform.Name = "txtplatform";
            this.txtplatform.Size = new System.Drawing.Size(100, 22);
            this.txtplatform.TabIndex = 3;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(155, 220);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(100, 22);
            this.txtsifre.TabIndex = 4;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(100, 327);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(87, 42);
            this.btnsil.TabIndex = 5;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncel
            // 
            this.btnguncel.Location = new System.Drawing.Point(193, 327);
            this.btnguncel.Name = "btnguncel";
            this.btnguncel.Size = new System.Drawing.Size(98, 42);
            this.btnguncel.TabIndex = 6;
            this.btnguncel.Text = "Güncelle";
            this.btnguncel.UseVisualStyleBackColor = true;
            this.btnguncel.Click += new System.EventHandler(this.btnguncel_Click);
            // 
            // datamız
            // 
            this.datamız.AllowUserToAddRows = false;
            this.datamız.AllowUserToDeleteRows = false;
            this.datamız.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamız.Location = new System.Drawing.Point(308, 92);
            this.datamız.Name = "datamız";
            this.datamız.ReadOnly = true;
            this.datamız.RowHeadersWidth = 51;
            this.datamız.RowTemplate.Height = 24;
            this.datamız.Size = new System.Drawing.Size(897, 397);
            this.datamız.TabIndex = 7;
            this.datamız.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datamız_CellDoubleClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 495);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 42);
            this.button4.TabIndex = 8;
            this.button4.Text = "Ayarlar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(583, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifreler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "RMP Şifresi";
            // 
            // txtRMP
            // 
            this.txtRMP.Location = new System.Drawing.Point(155, 278);
            this.txtRMP.Name = "txtRMP";
            this.txtRMP.PasswordChar = '*';
            this.txtRMP.Size = new System.Drawing.Size(100, 22);
            this.txtRMP.TabIndex = 11;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Location = new System.Drawing.Point(305, 71);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(141, 18);
            this.lblsifre.TabIndex = 12;
            this.lblsifre.Text = "SEÇİLEN SİFRE: ";
            // 
            // btngöster
            // 
            this.btngöster.Location = new System.Drawing.Point(80, 375);
            this.btngöster.Name = "btngöster";
            this.btngöster.Size = new System.Drawing.Size(123, 72);
            this.btngöster.TabIndex = 13;
            this.btngöster.Text = "Şifre Görüntüle";
            this.btngöster.UseVisualStyleBackColor = true;
            this.btngöster.Click += new System.EventHandler(this.btngöster_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnoner
            // 
            this.btnoner.Location = new System.Drawing.Point(33, 37);
            this.btnoner.Name = "btnoner";
            this.btnoner.Size = new System.Drawing.Size(87, 42);
            this.btnoner.TabIndex = 15;
            this.btnoner.Text = "Şifre Öner";
            this.btnoner.UseVisualStyleBackColor = true;
            this.btnoner.Click += new System.EventHandler(this.btnoner_Click);
            // 
            // lbloneri
            // 
            this.lbloneri.Location = new System.Drawing.Point(155, 47);
            this.lbloneri.Name = "lbloneri";
            this.lbloneri.Size = new System.Drawing.Size(100, 22);
            this.lbloneri.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1217, 549);
            this.Controls.Add(this.lbloneri);
            this.Controls.Add(this.btnoner);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngöster);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.txtRMP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.datamız);
            this.Controls.Add(this.btnguncel);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtplatform);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datamız)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtplatform;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncel;
        private System.Windows.Forms.DataGridView datamız;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRMP;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Button btngöster;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnoner;
        private System.Windows.Forms.TextBox lbloneri;
    }
}