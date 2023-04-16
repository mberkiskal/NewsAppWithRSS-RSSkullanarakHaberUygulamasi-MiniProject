namespace p22Rss
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
            this.btnCnnTurk = new System.Windows.Forms.Button();
            this.btnBBC = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCnn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnMilliyet = new System.Windows.Forms.Button();
            this.btnNTV = new System.Windows.Forms.Button();
            this.btnFox = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCnnTurk
            // 
            this.btnCnnTurk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCnnTurk.BackgroundImage")));
            this.btnCnnTurk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCnnTurk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCnnTurk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCnnTurk.Location = new System.Drawing.Point(1091, 12);
            this.btnCnnTurk.Name = "btnCnnTurk";
            this.btnCnnTurk.Size = new System.Drawing.Size(199, 120);
            this.btnCnnTurk.TabIndex = 0;
            this.btnCnnTurk.UseVisualStyleBackColor = true;
            this.btnCnnTurk.Click += new System.EventHandler(this.btnHurriyet_Click);
            // 
            // btnBBC
            // 
            this.btnBBC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBBC.BackgroundImage")));
            this.btnBBC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBBC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBBC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBBC.Location = new System.Drawing.Point(875, 157);
            this.btnBBC.Name = "btnBBC";
            this.btnBBC.Size = new System.Drawing.Size(199, 120);
            this.btnBBC.TabIndex = 2;
            this.btnBBC.UseVisualStyleBackColor = true;
            this.btnBBC.Click += new System.EventHandler(this.btnSabah_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(834, 604);
            this.listBox1.TabIndex = 6;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(44, 96);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(255, 33);
            this.txtLink.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(305, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCnn
            // 
            this.btnCnn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCnn.BackgroundImage")));
            this.btnCnn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCnn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCnn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCnn.Location = new System.Drawing.Point(875, 12);
            this.btnCnn.Name = "btnCnn";
            this.btnCnn.Size = new System.Drawing.Size(199, 120);
            this.btnCnn.TabIndex = 9;
            this.btnCnn.UseVisualStyleBackColor = true;
            this.btnCnn.Click += new System.EventHandler(this.btnCnn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-8, 628);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 628);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(811, 628);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(307, 181);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(544, 628);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(298, 181);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 18;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(1088, 628);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(298, 181);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            // 
            // btnMilliyet
            // 
            this.btnMilliyet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMilliyet.BackgroundImage")));
            this.btnMilliyet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMilliyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMilliyet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMilliyet.Location = new System.Drawing.Point(1105, 157);
            this.btnMilliyet.Name = "btnMilliyet";
            this.btnMilliyet.Size = new System.Drawing.Size(199, 120);
            this.btnMilliyet.TabIndex = 21;
            this.btnMilliyet.UseVisualStyleBackColor = true;
            this.btnMilliyet.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNTV
            // 
            this.btnNTV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNTV.BackgroundImage")));
            this.btnNTV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNTV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNTV.Location = new System.Drawing.Point(1105, 309);
            this.btnNTV.Name = "btnNTV";
            this.btnNTV.Size = new System.Drawing.Size(199, 120);
            this.btnNTV.TabIndex = 22;
            this.btnNTV.UseVisualStyleBackColor = true;
            this.btnNTV.Click += new System.EventHandler(this.btnNTV_Click);
            // 
            // btnFox
            // 
            this.btnFox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFox.BackgroundImage")));
            this.btnFox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFox.Location = new System.Drawing.Point(875, 309);
            this.btnFox.Name = "btnFox";
            this.btnFox.Size = new System.Drawing.Size(199, 120);
            this.btnFox.TabIndex = 23;
            this.btnFox.UseVisualStyleBackColor = true;
            this.btnFox.Click += new System.EventHandler(this.btnFox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(875, 448);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 168);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MANUEL RSS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "If you want to enter RSS:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 740);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFox);
            this.Controls.Add(this.btnNTV);
            this.Controls.Add(this.btnMilliyet);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCnn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnBBC);
            this.Controls.Add(this.btnCnnTurk);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCnnTurk;
        private System.Windows.Forms.Button btnBBC;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCnn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btnMilliyet;
        private System.Windows.Forms.Button btnNTV;
        private System.Windows.Forms.Button btnFox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

