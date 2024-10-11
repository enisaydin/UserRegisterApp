namespace KullaniciKayitApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            lblAd = new Label();
            lblSoyad = new Label();
            lblEmail = new Label();
            lblYas = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEmail = new TextBox();
            txtYas = new TextBox();
            btnKaydet = new Button();
            btnKayitGöster = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(83, 61);
            label5.Name = "label5";
            label5.Size = new Size(188, 38);
            label5.TabIndex = 8;
            label5.Text = "Kullanıcı Kayıt";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(101, 143);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 9;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(101, 186);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 10;
            lblSoyad.Text = "Soyad";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(101, 236);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Location = new Point(101, 283);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(30, 20);
            lblYas.TabIndex = 12;
            lblYas.Text = "Yas";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(194, 136);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(246, 27);
            txtAd.TabIndex = 13;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(194, 179);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(246, 27);
            txtSoyad.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(194, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(194, 276);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(246, 27);
            txtYas.TabIndex = 16;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(194, 337);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 17;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnKayitGöster
            // 
            btnKayitGöster.Location = new Point(317, 337);
            btnKayitGöster.Name = "btnKayitGöster";
            btnKayitGöster.Size = new Size(123, 29);
            btnKayitGöster.TabIndex = 18;
            btnKayitGöster.Text = "Kayıtları Göster";
            btnKayitGöster.UseVisualStyleBackColor = true;
            btnKayitGöster.Click += btnKayitGöster_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 424);
            Controls.Add(btnKayitGöster);
            Controls.Add(btnKaydet);
            Controls.Add(txtYas);
            Controls.Add(txtEmail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblYas);
            Controls.Add(lblEmail);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(label5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblEmail;
        private Label lblYas;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEmail;
        private TextBox txtYas;
        private Button btnKaydet;
        private Button btnKayitGöster;
    }
}
