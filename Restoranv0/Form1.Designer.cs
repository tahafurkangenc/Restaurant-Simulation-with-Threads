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
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masalarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // yenilebutton
            // 
            this.yenilebutton.Location = new System.Drawing.Point(728, 193);
            this.yenilebutton.Name = "yenilebutton";
            this.yenilebutton.Size = new System.Drawing.Size(45, 23);
            this.yenilebutton.TabIndex = 1;
            this.yenilebutton.Text = "Yenile";
            this.yenilebutton.UseVisualStyleBackColor = true;
            // 
            // musteriDataGridView
            // 
            this.musteriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriDataGridView.Location = new System.Drawing.Point(414, 12);
            this.musteriDataGridView.Name = "musteriDataGridView";
            this.musteriDataGridView.Size = new System.Drawing.Size(359, 175);
            this.musteriDataGridView.TabIndex = 2;
            // 
            // masalarDataGridView
            // 
            this.masalarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masalarDataGridView.Location = new System.Drawing.Point(414, 222);
            this.masalarDataGridView.Name = "masalarDataGridView";
            this.masalarDataGridView.Size = new System.Drawing.Size(359, 175);
            this.masalarDataGridView.TabIndex = 3;
            // 
            // btn_masayamusterial
            // 
            this.btn_masayamusterial.Location = new System.Drawing.Point(414, 193);
            this.btn_masayamusterial.Name = "btn_masayamusterial";
            this.btn_masayamusterial.Size = new System.Drawing.Size(102, 23);
            this.btn_masayamusterial.TabIndex = 4;
            this.btn_masayamusterial.Text = "Masaya Müşteri Al";
            this.btn_masayamusterial.UseVisualStyleBackColor = true;
            this.btn_masayamusterial.Click += new System.EventHandler(this.btn_masayamusterial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 482);
            this.Controls.Add(this.btn_masayamusterial);
            this.Controls.Add(this.masalarDataGridView);
            this.Controls.Add(this.musteriDataGridView);
            this.Controls.Add(this.yenilebutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masalarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button yenilebutton;
        private System.Windows.Forms.DataGridView musteriDataGridView;
        private System.Windows.Forms.DataGridView masalarDataGridView;
        private System.Windows.Forms.Button btn_masayamusterial;
    }
}

