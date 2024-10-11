using System;
using System.Linq;
using System.Windows.Forms;
using KullaniciKayitApp.Models;

namespace KullaniciKayitApp
{
    partial class Form2
    {
        
        
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
            components = new System.ComponentModel.Container();
            dataGridViewUsers = new DataGridView();
            lblAllUsers = new Label();
            notifyIcon1 = new NotifyIcon(components);
            btnYenile = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(52, 102);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(616, 336);
            dataGridViewUsers.TabIndex = 0;
            // 
            // lblAllUsers
            // 
            lblAllUsers.AutoSize = true;
            lblAllUsers.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAllUsers.Location = new Point(52, 48);
            lblAllUsers.Name = "lblAllUsers";
            lblAllUsers.Size = new Size(214, 30);
            lblAllUsers.TabIndex = 1;
            lblAllUsers.Text = "Kayıtlı Kullanıcılar ";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(272, 48);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(136, 40);
            btnYenile.TabIndex = 2;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // button1
            // 
            button1.Location = new Point(535, 48);
            button1.Name = "button1";
            button1.Size = new Size(133, 40);
            button1.TabIndex = 3;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 450);
            Controls.Add(button1);
            Controls.Add(btnYenile);
            Controls.Add(lblAllUsers);
            Controls.Add(dataGridViewUsers);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Label lblAllUsers;
        private NotifyIcon notifyIcon1;
        private Button btnYenile;
        private Button button1;
    }
}