namespace kronometre
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
            this.components = new System.ComponentModel.Container();
            this.kronometre = new System.Windows.Forms.Label();
            this.buton2Basla = new System.Windows.Forms.Button();
            this.butonBekle = new System.Windows.Forms.Button();
            this.butonTekrar = new System.Windows.Forms.Button();
            this.timer1Kronometre = new System.Windows.Forms.Timer(this.components);
            this.butonKaydet = new System.Windows.Forms.Button();
            this.listBoxKayıtlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // kronometre
            // 
            this.kronometre.AutoSize = true;
            this.kronometre.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kronometre.Location = new System.Drawing.Point(12, 9);
            this.kronometre.Name = "kronometre";
            this.kronometre.Size = new System.Drawing.Size(626, 91);
            this.kronometre.TabIndex = 0;
            this.kronometre.Text = "00:00:00:00:000";
            // 
            // buton2Basla
            // 
            this.buton2Basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton2Basla.Location = new System.Drawing.Point(41, 142);
            this.buton2Basla.Name = "buton2Basla";
            this.buton2Basla.Size = new System.Drawing.Size(110, 66);
            this.buton2Basla.TabIndex = 1;
            this.buton2Basla.Text = "BAŞLA";
            this.buton2Basla.UseVisualStyleBackColor = true;
            this.buton2Basla.Click += new System.EventHandler(this.buton2Basla_Click);
            // 
            // butonBekle
            // 
            this.butonBekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonBekle.Location = new System.Drawing.Point(171, 142);
            this.butonBekle.Name = "butonBekle";
            this.butonBekle.Size = new System.Drawing.Size(106, 66);
            this.butonBekle.TabIndex = 2;
            this.butonBekle.Text = "BEKLE";
            this.butonBekle.UseVisualStyleBackColor = true;
            this.butonBekle.Click += new System.EventHandler(this.butonBekle_Click);
            // 
            // butonTekrar
            // 
            this.butonTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonTekrar.Location = new System.Drawing.Point(306, 142);
            this.butonTekrar.Name = "butonTekrar";
            this.butonTekrar.Size = new System.Drawing.Size(108, 66);
            this.butonTekrar.TabIndex = 3;
            this.butonTekrar.Text = "TEKRAR";
            this.butonTekrar.UseVisualStyleBackColor = true;
            this.butonTekrar.Click += new System.EventHandler(this.butonTekrar_Click);
            // 
            // timer1Kronometre
            // 
            this.timer1Kronometre.Enabled = true;
            this.timer1Kronometre.Interval = 1;
            this.timer1Kronometre.Tick += new System.EventHandler(this.timer1Kronometre_Tick);
            // 
            // butonKaydet
            // 
            this.butonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonKaydet.Location = new System.Drawing.Point(443, 142);
            this.butonKaydet.Name = "butonKaydet";
            this.butonKaydet.Size = new System.Drawing.Size(108, 66);
            this.butonKaydet.TabIndex = 4;
            this.butonKaydet.Text = "KAYDET";
            this.butonKaydet.UseVisualStyleBackColor = true;
            this.butonKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxKayıtlar
            // 
            this.listBoxKayıtlar.FormattingEnabled = true;
            this.listBoxKayıtlar.ItemHeight = 16;
            this.listBoxKayıtlar.Location = new System.Drawing.Point(12, 239);
            this.listBoxKayıtlar.Name = "listBoxKayıtlar";
            this.listBoxKayıtlar.Size = new System.Drawing.Size(702, 164);
            this.listBoxKayıtlar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.listBoxKayıtlar);
            this.Controls.Add(this.butonKaydet);
            this.Controls.Add(this.butonTekrar);
            this.Controls.Add(this.butonBekle);
            this.Controls.Add(this.buton2Basla);
            this.Controls.Add(this.kronometre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kronometre;
        private System.Windows.Forms.Button buton2Basla;
        private System.Windows.Forms.Button butonBekle;
        private System.Windows.Forms.Button butonTekrar;
        private System.Windows.Forms.Timer timer1Kronometre;
        private System.Windows.Forms.Button butonKaydet;
        private System.Windows.Forms.ListBox listBoxKayıtlar;
    }
}

