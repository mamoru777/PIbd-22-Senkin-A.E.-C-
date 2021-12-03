namespace Lab1
{
    partial class FormKranConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSideOkna = new System.Windows.Forms.CheckBox();
            this.checkBoxKran = new System.Windows.Forms.CheckBox();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxKran = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelKran = new System.Windows.Forms.Label();
            this.labelGusmashina = new System.Windows.Forms.Label();
            this.panelTransport = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelDopColor2 = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBrown = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKran)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelTransport.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSideOkna);
            this.groupBox1.Controls.Add(this.checkBoxKran);
            this.groupBox1.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBox1.Controls.Add(this.numericUpDownWeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // checkBoxSideOkna
            // 
            this.checkBoxSideOkna.AutoSize = true;
            this.checkBoxSideOkna.Location = new System.Drawing.Point(148, 59);
            this.checkBoxSideOkna.Name = "checkBoxSideOkna";
            this.checkBoxSideOkna.Size = new System.Drawing.Size(52, 17);
            this.checkBoxSideOkna.TabIndex = 5;
            this.checkBoxSideOkna.Text = "Окна";
            this.checkBoxSideOkna.UseVisualStyleBackColor = true;
            // 
            // checkBoxKran
            // 
            this.checkBoxKran.AutoSize = true;
            this.checkBoxKran.Location = new System.Drawing.Point(148, 36);
            this.checkBoxKran.Name = "checkBoxKran";
            this.checkBoxKran.Size = new System.Drawing.Size(51, 17);
            this.checkBoxKran.TabIndex = 4;
            this.checkBoxKran.Text = "Кран";
            this.checkBoxKran.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(69, 55);
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownMaxSpeed.TabIndex = 3;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(69, 94);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownWeight.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес крана:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс. скорость:";
            // 
            // pictureBoxKran
            // 
            this.pictureBoxKran.Location = new System.Drawing.Point(16, 4);
            this.pictureBoxKran.Name = "pictureBoxKran";
            this.pictureBoxKran.Size = new System.Drawing.Size(120, 132);
            this.pictureBoxKran.TabIndex = 1;
            this.pictureBoxKran.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelKran);
            this.groupBox2.Controls.Add(this.labelGusmashina);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 141);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип кузова";
            // 
            // labelKran
            // 
            this.labelKran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKran.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKran.Location = new System.Drawing.Point(8, 82);
            this.labelKran.Name = "labelKran";
            this.labelKran.Size = new System.Drawing.Size(136, 46);
            this.labelKran.TabIndex = 1;
            this.labelKran.Text = "Кран";
            this.labelKran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKran.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelKran_MouseDown);
            // 
            // labelGusmashina
            // 
            this.labelGusmashina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGusmashina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGusmashina.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelGusmashina.Location = new System.Drawing.Point(8, 25);
            this.labelGusmashina.Name = "labelGusmashina";
            this.labelGusmashina.Size = new System.Drawing.Size(136, 49);
            this.labelGusmashina.TabIndex = 0;
            this.labelGusmashina.Text = "Гусечная машина";
            this.labelGusmashina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGusmashina.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelGusmashina_MouseDown);
            // 
            // panelTransport
            // 
            this.panelTransport.AllowDrop = true;
            this.panelTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransport.Controls.Add(this.pictureBoxKran);
            this.panelTransport.Location = new System.Drawing.Point(169, 12);
            this.panelTransport.Name = "panelTransport";
            this.panelTransport.Size = new System.Drawing.Size(153, 141);
            this.panelTransport.TabIndex = 3;
            this.panelTransport.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTransport_DragDrop);
            this.panelTransport.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTransport_DragEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelDopColor2);
            this.groupBox3.Controls.Add(this.labelDopColor);
            this.groupBox3.Controls.Add(this.labelBaseColor);
            this.groupBox3.Controls.Add(this.panelPurple);
            this.groupBox3.Controls.Add(this.panelRed);
            this.groupBox3.Controls.Add(this.panelYellow);
            this.groupBox3.Controls.Add(this.panelBlack);
            this.groupBox3.Controls.Add(this.panelGreen);
            this.groupBox3.Controls.Add(this.panelBrown);
            this.groupBox3.Controls.Add(this.panelAqua);
            this.groupBox3.Controls.Add(this.panelWhite);
            this.groupBox3.Location = new System.Drawing.Point(328, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 175);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвета";
            // 
            // labelDopColor2
            // 
            this.labelDopColor2.AllowDrop = true;
            this.labelDopColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor2.Location = new System.Drawing.Point(74, 45);
            this.labelDopColor2.Name = "labelDopColor2";
            this.labelDopColor2.Size = new System.Drawing.Size(81, 29);
            this.labelDopColor2.TabIndex = 10;
            this.labelDopColor2.Text = "Доп. цвет 2";
            this.labelDopColor2.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor2_DragDrop);
            this.labelDopColor2.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(117, 16);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(86, 29);
            this.labelDopColor.TabIndex = 9;
            this.labelDopColor.Text = "Доп. цвет 1";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(20, 16);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(86, 29);
            this.labelBaseColor.TabIndex = 8;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(171, 91);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(32, 32);
            this.panelPurple.TabIndex = 7;
            this.panelPurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(123, 132);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(32, 32);
            this.panelRed.TabIndex = 6;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(74, 132);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(32, 32);
            this.panelYellow.TabIndex = 5;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(22, 132);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(32, 32);
            this.panelBlack.TabIndex = 4;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(123, 91);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(32, 32);
            this.panelGreen.TabIndex = 3;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBrown
            // 
            this.panelBrown.BackColor = System.Drawing.Color.Brown;
            this.panelBrown.Location = new System.Drawing.Point(171, 129);
            this.panelBrown.Name = "panelBrown";
            this.panelBrown.Size = new System.Drawing.Size(32, 32);
            this.panelBrown.TabIndex = 2;
            this.panelBrown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelAqua
            // 
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.Location = new System.Drawing.Point(74, 91);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(32, 32);
            this.panelAqua.TabIndex = 1;
            this.panelAqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(22, 91);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(32, 32);
            this.panelWhite.TabIndex = 0;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(467, 205);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(87, 30);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(467, 247);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 29);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormKranConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 294);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelTransport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKranConfig";
            this.Text = "Выбор крана";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKran)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panelTransport.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSideOkna;
        private System.Windows.Forms.CheckBox checkBoxKran;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxKran;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelKran;
        private System.Windows.Forms.Label labelGusmashina;
        private System.Windows.Forms.Panel panelTransport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelDopColor2;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBrown;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}