namespace Restoranv0
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
            this.yenilebutton = new System.Windows.Forms.Button();
            this.musteriDataGridView = new System.Windows.Forms.DataGridView();
            this.masalarDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_masayamusterial = new System.Windows.Forms.Button();
            this.garsonlarDataGridView = new System.Windows.Forms.DataGridView();
            this.lbl_kasabakiye = new System.Windows.Forms.Label();
            this.asciDataGridView = new System.Windows.Forms.DataGridView();
            this.kasaDataGridView = new System.Windows.Forms.DataGridView();
            this.musteriSayisiTextBox = new System.Windows.Forms.TextBox();
            this.btn_problem2 = new System.Windows.Forms.Button();
            this.btn_problem2_sureli = new System.Windows.Forms.Button();
            this.musteriPeriyoduTextBox = new System.Windows.Forms.TextBox();
            this.simulasyonSuresiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_kazanc = new System.Windows.Forms.Label();
            this.lbl_ascisayisi = new System.Windows.Forms.Label();
            this.lbl_garsonsayisi = new System.Windows.Forms.Label();
            this.lbl_masasayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masalarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garsonlarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asciDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // yenilebutton
            // 
            this.yenilebutton.Location = new System.Drawing.Point(120, 352);
            this.yenilebutton.Name = "yenilebutton";
            this.yenilebutton.Size = new System.Drawing.Size(112, 23);
            this.yenilebutton.TabIndex = 1;
            this.yenilebutton.Text = "Anlık Durumu Göster";
            this.yenilebutton.UseVisualStyleBackColor = true;
            this.yenilebutton.Click += new System.EventHandler(this.yenilebutton_Click);
            // 
            // musteriDataGridView
            // 
            this.musteriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriDataGridView.Location = new System.Drawing.Point(366, 21);
            this.musteriDataGridView.Name = "musteriDataGridView";
            this.musteriDataGridView.Size = new System.Drawing.Size(258, 501);
            this.musteriDataGridView.TabIndex = 2;
            // 
            // masalarDataGridView
            // 
            this.masalarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masalarDataGridView.Location = new System.Drawing.Point(11, 160);
            this.masalarDataGridView.Name = "masalarDataGridView";
            this.masalarDataGridView.Size = new System.Drawing.Size(349, 184);
            this.masalarDataGridView.TabIndex = 3;
            // 
            // btn_masayamusterial
            // 
            this.btn_masayamusterial.Location = new System.Drawing.Point(12, 352);
            this.btn_masayamusterial.Name = "btn_masayamusterial";
            this.btn_masayamusterial.Size = new System.Drawing.Size(102, 23);
            this.btn_masayamusterial.TabIndex = 4;
            this.btn_masayamusterial.Text = "Masaya Müşteri Al";
            this.btn_masayamusterial.UseVisualStyleBackColor = true;
            this.btn_masayamusterial.Click += new System.EventHandler(this.btn_masayamusterial_Click);
            // 
            // garsonlarDataGridView
            // 
            this.garsonlarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.garsonlarDataGridView.Location = new System.Drawing.Point(11, 21);
            this.garsonlarDataGridView.Name = "garsonlarDataGridView";
            this.garsonlarDataGridView.Size = new System.Drawing.Size(349, 120);
            this.garsonlarDataGridView.TabIndex = 5;
            // 
            // lbl_kasabakiye
            // 
            this.lbl_kasabakiye.AutoSize = true;
            this.lbl_kasabakiye.Location = new System.Drawing.Point(238, 357);
            this.lbl_kasabakiye.Name = "lbl_kasabakiye";
            this.lbl_kasabakiye.Size = new System.Drawing.Size(37, 13);
            this.lbl_kasabakiye.TabIndex = 6;
            this.lbl_kasabakiye.Text = "Kasa :";
            // 
            // asciDataGridView
            // 
            this.asciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asciDataGridView.Location = new System.Drawing.Point(630, 21);
            this.asciDataGridView.Name = "asciDataGridView";
            this.asciDataGridView.Size = new System.Drawing.Size(350, 501);
            this.asciDataGridView.TabIndex = 7;
            // 
            // kasaDataGridView
            // 
            this.kasaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kasaDataGridView.Location = new System.Drawing.Point(986, 21);
            this.kasaDataGridView.Name = "kasaDataGridView";
            this.kasaDataGridView.Size = new System.Drawing.Size(245, 501);
            this.kasaDataGridView.TabIndex = 8;
            // 
            // musteriSayisiTextBox
            // 
            this.musteriSayisiTextBox.Location = new System.Drawing.Point(120, 380);
            this.musteriSayisiTextBox.Name = "musteriSayisiTextBox";
            this.musteriSayisiTextBox.Size = new System.Drawing.Size(72, 20);
            this.musteriSayisiTextBox.TabIndex = 9;
            // 
            // btn_problem2
            // 
            this.btn_problem2.Location = new System.Drawing.Point(198, 378);
            this.btn_problem2.Name = "btn_problem2";
            this.btn_problem2.Size = new System.Drawing.Size(63, 23);
            this.btn_problem2.TabIndex = 10;
            this.btn_problem2.Text = "Problem 2";
            this.btn_problem2.UseVisualStyleBackColor = true;
            this.btn_problem2.Click += new System.EventHandler(this.btn_problem2_Click);
            // 
            // btn_problem2_sureli
            // 
            this.btn_problem2_sureli.Location = new System.Drawing.Point(16, 470);
            this.btn_problem2_sureli.Name = "btn_problem2_sureli";
            this.btn_problem2_sureli.Size = new System.Drawing.Size(123, 23);
            this.btn_problem2_sureli.TabIndex = 12;
            this.btn_problem2_sureli.Text = "Problem 2 süreli çözüm";
            this.btn_problem2_sureli.UseVisualStyleBackColor = true;
            this.btn_problem2_sureli.Click += new System.EventHandler(this.btn_problem2_sureli_Click);
            // 
            // musteriPeriyoduTextBox
            // 
            this.musteriPeriyoduTextBox.Location = new System.Drawing.Point(281, 436);
            this.musteriPeriyoduTextBox.Name = "musteriPeriyoduTextBox";
            this.musteriPeriyoduTextBox.Size = new System.Drawing.Size(72, 20);
            this.musteriPeriyoduTextBox.TabIndex = 11;
            // 
            // simulasyonSuresiTextBox
            // 
            this.simulasyonSuresiTextBox.Location = new System.Drawing.Point(170, 407);
            this.simulasyonSuresiTextBox.Name = "simulasyonSuresiTextBox";
            this.simulasyonSuresiTextBox.Size = new System.Drawing.Size(72, 20);
            this.simulasyonSuresiTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Müşteri Sayısı Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Simülasyon İçin Dakika Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Müşterilerin Geliş Periyodunu Saniye Cinsinden Giriniz:";
            // 
            // lbl_kazanc
            // 
            this.lbl_kazanc.AutoSize = true;
            this.lbl_kazanc.Location = new System.Drawing.Point(15, 496);
            this.lbl_kazanc.Name = "lbl_kazanc";
            this.lbl_kazanc.Size = new System.Drawing.Size(49, 13);
            this.lbl_kazanc.TabIndex = 17;
            this.lbl_kazanc.Text = "Kazanç :";
            // 
            // lbl_ascisayisi
            // 
            this.lbl_ascisayisi.AutoSize = true;
            this.lbl_ascisayisi.Location = new System.Drawing.Point(117, 509);
            this.lbl_ascisayisi.Name = "lbl_ascisayisi";
            this.lbl_ascisayisi.Size = new System.Drawing.Size(66, 13);
            this.lbl_ascisayisi.TabIndex = 18;
            this.lbl_ascisayisi.Text = "Aşçı Sayısı : ";
            // 
            // lbl_garsonsayisi
            // 
            this.lbl_garsonsayisi.AutoSize = true;
            this.lbl_garsonsayisi.Location = new System.Drawing.Point(15, 509);
            this.lbl_garsonsayisi.Name = "lbl_garsonsayisi";
            this.lbl_garsonsayisi.Size = new System.Drawing.Size(77, 13);
            this.lbl_garsonsayisi.TabIndex = 19;
            this.lbl_garsonsayisi.Text = "Garson Sayısı :";
            // 
            // lbl_masasayisi
            // 
            this.lbl_masasayisi.AutoSize = true;
            this.lbl_masasayisi.Location = new System.Drawing.Point(117, 496);
            this.lbl_masasayisi.Name = "lbl_masasayisi";
            this.lbl_masasayisi.Size = new System.Drawing.Size(69, 13);
            this.lbl_masasayisi.TabIndex = 20;
            this.lbl_masasayisi.Text = "Masa Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Garsonlar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Masalar :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Müşteriler :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Aşçılar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(983, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Kasa :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 26);
            this.label9.TabIndex = 26;
            this.label9.Text = "Lütfen max 100 kişi olacak\r\n! ! ! şekilde giriş yapınız ! ! !";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 530);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_masasayisi);
            this.Controls.Add(this.lbl_garsonsayisi);
            this.Controls.Add(this.lbl_ascisayisi);
            this.Controls.Add(this.lbl_kazanc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simulasyonSuresiTextBox);
            this.Controls.Add(this.btn_problem2_sureli);
            this.Controls.Add(this.musteriPeriyoduTextBox);
            this.Controls.Add(this.btn_problem2);
            this.Controls.Add(this.musteriSayisiTextBox);
            this.Controls.Add(this.kasaDataGridView);
            this.Controls.Add(this.asciDataGridView);
            this.Controls.Add(this.lbl_kasabakiye);
            this.Controls.Add(this.garsonlarDataGridView);
            this.Controls.Add(this.btn_masayamusterial);
            this.Controls.Add(this.masalarDataGridView);
            this.Controls.Add(this.musteriDataGridView);
            this.Controls.Add(this.yenilebutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masalarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garsonlarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asciDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button yenilebutton;
        private System.Windows.Forms.DataGridView musteriDataGridView;
        private System.Windows.Forms.DataGridView masalarDataGridView;
        private System.Windows.Forms.Button btn_masayamusterial;
        private System.Windows.Forms.DataGridView garsonlarDataGridView;
        private System.Windows.Forms.Label lbl_kasabakiye;
        private System.Windows.Forms.DataGridView asciDataGridView;
        private System.Windows.Forms.DataGridView kasaDataGridView;
        private System.Windows.Forms.TextBox musteriSayisiTextBox;
        private System.Windows.Forms.Button btn_problem2;
        private System.Windows.Forms.Button btn_problem2_sureli;
        private System.Windows.Forms.TextBox musteriPeriyoduTextBox;
        private System.Windows.Forms.TextBox simulasyonSuresiTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_kazanc;
        private System.Windows.Forms.Label lbl_ascisayisi;
        private System.Windows.Forms.Label lbl_garsonsayisi;
        private System.Windows.Forms.Label lbl_masasayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}