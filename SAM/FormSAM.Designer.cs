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
            this.buttonOpenDeal = new System.Windows.Forms.Button();
            this.buttonOpenAgents = new System.Windows.Forms.Button();
            this.buttonOpenSupply = new System.Windows.Forms.Button();
            this.buttonOpenDemand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // buttonOpenDeal
            // 
            this.buttonOpenDeal.Location = new System.Drawing.Point(32, 281);
            this.buttonOpenDeal.Name = "buttonOpenDeal";
            this.buttonOpenDeal.Size = new System.Drawing.Size(119, 68);
            this.buttonOpenDeal.TabIndex = 2;
            this.buttonOpenDeal.Text = "Сделки";
            this.buttonOpenDeal.UseVisualStyleBackColor = true;
            // 
            // buttonOpenAgents
            // 
            this.buttonOpenAgents.Location = new System.Drawing.Point(198, 281);
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
            // 
            // buttonOpenDemand
            // 
            this.buttonOpenDemand.Location = new System.Drawing.Point(198, 386);
            this.buttonOpenDemand.Name = "buttonOpenDemand";
            this.buttonOpenDemand.Size = new System.Drawing.Size(119, 68);
            this.buttonOpenDemand.TabIndex = 5;
            this.buttonOpenDemand.Text = "Требования";
            this.buttonOpenDemand.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Система Аниме-Магазина";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenDemand);
            this.Controls.Add(this.buttonOpenSupply);
            this.Controls.Add(this.buttonOpenAgents);
            this.Controls.Add(this.buttonOpenDeal);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.buttonOpenPersonal);
            this.Name = "SAM";
            this.Text = "SAM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenPersonal;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenDeal;
        private System.Windows.Forms.Button buttonOpenAgents;
        private System.Windows.Forms.Button buttonOpenSupply;
        private System.Windows.Forms.Button buttonOpenDemand;
        private System.Windows.Forms.Label label1;
    }
}

