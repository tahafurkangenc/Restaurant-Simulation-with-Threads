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
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masalarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garsonlarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asciDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // yenilebutton
            // 
            this.yenilebutton.Location = new System.Drawing.Point(120, 328);
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
            this.musteriDataGridView.Location = new System.Drawing.Point(367, 12);
            this.musteriDataGridView.Name = "musteriDataGridView";
            this.musteriDataGridView.Size = new System.Drawing.Size(258, 397);
            this.musteriDataGridView.TabIndex = 2;
            // 
            // masalarDataGridView
            // 
            this.masalarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masalarDataGridView.Location = new System.Drawing.Point(12, 138);
            this.masalarDataGridView.Name = "masalarDataGridView";
            this.masalarDataGridView.Size = new System.Drawing.Size(349, 184);
            this.masalarDataGridView.TabIndex = 3;
            // 
            // btn_masayamusterial
            // 
            this.btn_masayamusterial.Location = new System.Drawing.Point(12, 328);
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
            this.garsonlarDataGridView.Location = new System.Drawing.Point(12, 12);
            this.garsonlarDataGridView.Name = "garsonlarDataGridView";
            this.garsonlarDataGridView.Size = new System.Drawing.Size(349, 120);
            this.garsonlarDataGridView.TabIndex = 5;
            // 
            // lbl_kasabakiye
            // 
            this.lbl_kasabakiye.AutoSize = true;
            this.lbl_kasabakiye.Location = new System.Drawing.Point(238, 333);
            this.lbl_kasabakiye.Name = "lbl_kasabakiye";
            this.lbl_kasabakiye.Size = new System.Drawing.Size(37, 13);
            this.lbl_kasabakiye.TabIndex = 6;
            this.lbl_kasabakiye.Text = "Kasa :";
            // 
            // asciDataGridView
            // 
            this.asciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asciDataGridView.Location = new System.Drawing.Point(631, 12);
            this.asciDataGridView.Name = "asciDataGridView";
            this.asciDataGridView.Size = new System.Drawing.Size(350, 397);
            this.asciDataGridView.TabIndex = 7;
            // 
            // kasaDataGridView
            // 
            this.kasaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kasaDataGridView.Location = new System.Drawing.Point(987, 12);
            this.kasaDataGridView.Name = "kasaDataGridView";
            this.kasaDataGridView.Size = new System.Drawing.Size(245, 397);
            this.kasaDataGridView.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 418);
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
    }
}