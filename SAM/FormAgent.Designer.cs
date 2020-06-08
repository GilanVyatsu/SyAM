namespace SAM
{
    partial class FormAgent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDeal = new System.Windows.Forms.TextBox();
            this.textBoxShare = new System.Windows.Forms.TextBox();
            this.labelDeal = new System.Windows.Forms.Label();
            this.labelShare = new System.Windows.Forms.Label();
            this.listViewAgent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(34, 475);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 46);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(184, 475);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(96, 46);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(328, 475);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 46);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxDeal
            // 
            this.textBoxDeal.Location = new System.Drawing.Point(8, 59);
            this.textBoxDeal.Name = "textBoxDeal";
            this.textBoxDeal.Size = new System.Drawing.Size(145, 20);
            this.textBoxDeal.TabIndex = 3;
            // 
            // textBoxShare
            // 
            this.textBoxShare.Location = new System.Drawing.Point(8, 117);
            this.textBoxShare.Name = "textBoxShare";
            this.textBoxShare.Size = new System.Drawing.Size(145, 20);
            this.textBoxShare.TabIndex = 4;
            // 
            // labelDeal
            // 
            this.labelDeal.AutoSize = true;
            this.labelDeal.Location = new System.Drawing.Point(9, 43);
            this.labelDeal.Name = "labelDeal";
            this.labelDeal.Size = new System.Drawing.Size(53, 13);
            this.labelDeal.TabIndex = 5;
            this.labelDeal.Text = "Сделка с";
            // 
            // labelShare
            // 
            this.labelShare.AutoSize = true;
            this.labelShare.Location = new System.Drawing.Point(9, 101);
            this.labelShare.Name = "labelShare";
            this.labelShare.Size = new System.Drawing.Size(34, 13);
            this.labelShare.TabIndex = 6;
            this.labelShare.Text = "Доля";
            // 
            // listViewAgent
            // 
            this.listViewAgent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewAgent.FullRowSelect = true;
            this.listViewAgent.GridLines = true;
            this.listViewAgent.HideSelection = false;
            this.listViewAgent.Location = new System.Drawing.Point(172, 43);
            this.listViewAgent.Name = "listViewAgent";
            this.listViewAgent.Size = new System.Drawing.Size(283, 397);
            this.listViewAgent.TabIndex = 7;
            this.listViewAgent.UseCompatibleStateImageBehavior = false;
            this.listViewAgent.View = System.Windows.Forms.View.Details;
            this.listViewAgent.SelectedIndexChanged += new System.EventHandler(this.listViewDealShare_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Сделка с";
            this.columnHeader1.Width = 183;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Доля";
            this.columnHeader2.Width = 97;
            // 
            // FormAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 544);
            this.Controls.Add(this.listViewAgent);
            this.Controls.Add(this.labelShare);
            this.Controls.Add(this.labelDeal);
            this.Controls.Add(this.textBoxShare);
            this.Controls.Add(this.textBoxDeal);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormAgent";
            this.Text = "FormAgent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxDeal;
        private System.Windows.Forms.TextBox textBoxShare;
        private System.Windows.Forms.Label labelDeal;
        private System.Windows.Forms.Label labelShare;
        private System.Windows.Forms.ListView listViewAgent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}