namespace SAM
{
    partial class SAM
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenPersonal = new System.Windows.Forms.Button();
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenAgents = new System.Windows.Forms.Button();
            this.buttonOpenSupply = new System.Windows.Forms.Button();
            this.buttonOpenDemand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenStore = new System.Windows.Forms.Button();
            this.buttonOpenDelivery = new System.Windows.Forms.Button();
            this.buttonOpenCatalog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenPersonal
            // 
            this.buttonOpenPersonal.Location = new System.Drawing.Point(32, 179);
            this.buttonOpenPersonal.Name = "buttonOpenPersonal";
            this.buttonOpenPersonal.Size = new System.Drawing.Size(119, 68);
            this.buttonOpenPersonal.TabIndex = 0;
            this.buttonOpenPersonal.Text = "Персонал";
            this.buttonOpenPersonal.UseVisualStyleBackColor = true;
            this.buttonOpenPersonal.Click += new System.EventHandler(this.buttonOpenPersonal_Click);
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.Location = new System.Drawing.Point(198, 179);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(119, 68);
            this.buttonOpenClients.TabIndex = 1;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = true;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenAgents
            // 
            this.buttonOpenAgents.Location = new System.Drawing.Point(362, 281);
            this.buttonOpenAgents.Name = "buttonOpenAgents";
            this.buttonOpenAgents.Size = new System.Drawing.Size(119, 68);
            this.buttonOpenAgents.TabIndex = 3;
            this.buttonOpenAgents.Text = "Агенты";
            this.buttonOpenAgents.UseVisualStyleBackColor = true;
            this.buttonOpenAgents.Click += new System.EventHandler(this.buttonOpenAgents_Click);
            // 
            // buttonOpenSupply
            // 
            this.buttonOpenSupply.Location = new System.Drawing.Point(32, 386);
            this.buttonOpenSupply.Name = "buttonOpenSupply";
            this.buttonOpenSupply.Size = new System.Drawing.Size(119, 68);
            this.buttonOpenSupply.TabIndex = 4;
            this.buttonOpenSupply.Text = "Поставки";
            this.buttonOpenSupply.UseVisualStyleBackColor = true;
            this.buttonOpenSupply.Click += new System.EventHandler(this.buttonOpenSupply_Click);
            // 
            // buttonOpenDemand
            // 
            this.buttonOpenDemand.Location = new System.Drawing.Point(198, 386);
            this.buttonOpenDemand.Name = "buttonOpenDemand";
            this.buttonOpenDemand.Size = new System.Drawing.Size(119, 68);
            this.buttonOpenDemand.TabIndex = 5;
            this.buttonOpenDemand.Text = "Требования";
            this.buttonOpenDemand.UseVisualStyleBackColor = true;
            this.buttonOpenDemand.Click += new System.EventHandler(this.buttonOpenDemand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Система Аниме-Магазина";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonOpenStore
            // 
            this.buttonOpenStore.Location = new System.Drawing.Point(32, 281);
            this.buttonOpenStore.Name = "buttonOpenStore";
            this.buttonOpenStore.Size = new System.Drawing.Size(119, 68);
            this.buttonOpenStore.TabIndex = 7;
            this.buttonOpenStore.Text = "Магазин";
            this.buttonOpenStore.UseVisualStyleBackColor = true;
            this.buttonOpenStore.Click += new System.EventHandler(this.buttonOpenStore_Click);
            // 
            // buttonOpenDelivery
            // 
            this.buttonOpenDelivery.Location = new System.Drawing.Point(198, 281);
            this.buttonOpenDelivery.Name = "buttonOpenDelivery";
            this.buttonOpenDelivery.Size = new System.Drawing.Size(119, 68);
            this.buttonOpenDelivery.TabIndex = 8;
            this.buttonOpenDelivery.Text = "Доставка";
            this.buttonOpenDelivery.UseVisualStyleBackColor = true;
            this.buttonOpenDelivery.Click += new System.EventHandler(this.buttonOpenDelivery_Click);
            // 
            // buttonOpenCatalog
            // 
            this.buttonOpenCatalog.Location = new System.Drawing.Point(362, 386);
            this.buttonOpenCatalog.Name = "buttonOpenCatalog";
            this.buttonOpenCatalog.Size = new System.Drawing.Size(119, 68);
            this.buttonOpenCatalog.TabIndex = 9;
            this.buttonOpenCatalog.Text = "Каталог";
            this.buttonOpenCatalog.UseVisualStyleBackColor = true;
            this.buttonOpenCatalog.Click += new System.EventHandler(this.buttonOpenCatalog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAM.Properties.Resources._1200px_Wikipe_tan_full_length_svg;
            this.pictureBox1.Location = new System.Drawing.Point(333, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // SAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOpenCatalog);
            this.Controls.Add(this.buttonOpenDelivery);
            this.Controls.Add(this.buttonOpenStore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenDemand);
            this.Controls.Add(this.buttonOpenSupply);
            this.Controls.Add(this.buttonOpenAgents);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.buttonOpenPersonal);
            this.Name = "SAM";
            this.Text = "SAM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenPersonal;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenAgents;
        private System.Windows.Forms.Button buttonOpenSupply;
        private System.Windows.Forms.Button buttonOpenDemand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenStore;
        private System.Windows.Forms.Button buttonOpenDelivery;
        private System.Windows.Forms.Button buttonOpenCatalog;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

