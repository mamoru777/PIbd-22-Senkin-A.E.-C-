namespace Lab1
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetGusmashina = new System.Windows.Forms.Button();
            this.buttonSetKran = new System.Windows.Forms.Button();
            this.buttonTakeKran = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxTakeKran = new System.Windows.Forms.GroupBox();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.buttonDelParking = new System.Windows.Forms.Button();
            this.labelParkings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakeKran.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(-9, -32);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(817, 491);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetGusmashina
            // 
            this.buttonSetGusmashina.Location = new System.Drawing.Point(694, 249);
            this.buttonSetGusmashina.Name = "buttonSetGusmashina";
            this.buttonSetGusmashina.Size = new System.Drawing.Size(104, 35);
            this.buttonSetGusmashina.TabIndex = 1;
            this.buttonSetGusmashina.Text = "Припарковать гусечную машину";
            this.buttonSetGusmashina.UseVisualStyleBackColor = true;
            this.buttonSetGusmashina.Click += new System.EventHandler(this.buttonSetGusmashina_Click);
            // 
            // buttonSetKran
            // 
            this.buttonSetKran.Location = new System.Drawing.Point(694, 290);
            this.buttonSetKran.Name = "buttonSetKran";
            this.buttonSetKran.Size = new System.Drawing.Size(104, 36);
            this.buttonSetKran.TabIndex = 2;
            this.buttonSetKran.Text = "Припарковать кран";
            this.buttonSetKran.UseVisualStyleBackColor = true;
            this.buttonSetKran.Click += new System.EventHandler(this.buttonSetKran_Click);
            // 
            // buttonTakeKran
            // 
            this.buttonTakeKran.Location = new System.Drawing.Point(18, 72);
            this.buttonTakeKran.Name = "buttonTakeKran";
            this.buttonTakeKran.Size = new System.Drawing.Size(67, 22);
            this.buttonTakeKran.TabIndex = 3;
            this.buttonTakeKran.Text = "Забрать";
            this.buttonTakeKran.UseVisualStyleBackColor = true;
            this.buttonTakeKran.Click += new System.EventHandler(this.buttonTakeKran_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(15, 49);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 4;
            this.labelPlace.Text = "Место:";
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(63, 46);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(22, 20);
            this.maskedTextBoxPlace.TabIndex = 5;
            // 
            // groupBoxTakeKran
            // 
            this.groupBoxTakeKran.Controls.Add(this.labelPlace);
            this.groupBoxTakeKran.Controls.Add(this.buttonTakeKran);
            this.groupBoxTakeKran.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTakeKran.Location = new System.Drawing.Point(694, 332);
            this.groupBoxTakeKran.Name = "groupBoxTakeKran";
            this.groupBoxTakeKran.Size = new System.Drawing.Size(104, 106);
            this.groupBoxTakeKran.TabIndex = 6;
            this.groupBoxTakeKran.TabStop = false;
            this.groupBoxTakeKran.Text = "Забрать гусечную машину";
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(694, 93);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(104, 69);
            this.listBoxParkings.TabIndex = 7;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(694, 25);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(104, 20);
            this.textBoxNewLevelName.TabIndex = 8;
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(694, 51);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(104, 36);
            this.buttonAddParking.TabIndex = 9;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // buttonDelParking
            // 
            this.buttonDelParking.Location = new System.Drawing.Point(694, 168);
            this.buttonDelParking.Name = "buttonDelParking";
            this.buttonDelParking.Size = new System.Drawing.Size(104, 36);
            this.buttonDelParking.TabIndex = 10;
            this.buttonDelParking.Text = "Удалить парковку";
            this.buttonDelParking.UseVisualStyleBackColor = true;
            this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // labelParkings
            // 
            this.labelParkings.AutoSize = true;
            this.labelParkings.Location = new System.Drawing.Point(719, 9);
            this.labelParkings.Name = "labelParkings";
            this.labelParkings.Size = new System.Drawing.Size(60, 13);
            this.labelParkings.TabIndex = 11;
            this.labelParkings.Text = "Парковки:";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelParkings);
            this.Controls.Add(this.buttonDelParking);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBoxTakeKran);
            this.Controls.Add(this.buttonSetKran);
            this.Controls.Add(this.buttonSetGusmashina);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakeKran.ResumeLayout(false);
            this.groupBoxTakeKran.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetGusmashina;
        private System.Windows.Forms.Button buttonSetKran;
        private System.Windows.Forms.Button buttonTakeKran;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.GroupBox groupBoxTakeKran;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.MaskedTextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.Button buttonDelParking;
        private System.Windows.Forms.Label labelParkings;
    }
}