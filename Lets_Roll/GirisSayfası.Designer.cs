
namespace Lets_Roll
{
    partial class GirisSayfası
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
            this.yetkiligirisibutonu = new System.Windows.Forms.Button();
            this.rolleyelimbutonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yetkiligirisibutonu
            // 
            this.yetkiligirisibutonu.BackColor = System.Drawing.Color.Aqua;
            this.yetkiligirisibutonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yetkiligirisibutonu.ForeColor = System.Drawing.Color.Black;
            this.yetkiligirisibutonu.Location = new System.Drawing.Point(83, 149);
            this.yetkiligirisibutonu.Name = "yetkiligirisibutonu";
            this.yetkiligirisibutonu.Size = new System.Drawing.Size(309, 180);
            this.yetkiligirisibutonu.TabIndex = 0;
            this.yetkiligirisibutonu.Text = "Yetkili Girişi";
            this.yetkiligirisibutonu.UseVisualStyleBackColor = false;
            this.yetkiligirisibutonu.Click += new System.EventHandler(this.yetkiligirisibutonu_Click);
            // 
            // rolleyelimbutonu
            // 
            this.rolleyelimbutonu.BackColor = System.Drawing.Color.Gold;
            this.rolleyelimbutonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rolleyelimbutonu.Location = new System.Drawing.Point(594, 149);
            this.rolleyelimbutonu.Name = "rolleyelimbutonu";
            this.rolleyelimbutonu.Size = new System.Drawing.Size(309, 180);
            this.rolleyelimbutonu.TabIndex = 1;
            this.rolleyelimbutonu.Text = "Rolleyelim";
            this.rolleyelimbutonu.UseVisualStyleBackColor = false;
            this.rolleyelimbutonu.Click += new System.EventHandler(this.rolleyelimbutonu_Click);
            // 
            // GirisSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1104, 570);
            this.Controls.Add(this.rolleyelimbutonu);
            this.Controls.Add(this.yetkiligirisibutonu);
            this.Name = "GirisSayfası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yetkiligirisibutonu;
        private System.Windows.Forms.Button rolleyelimbutonu;
    }
}

