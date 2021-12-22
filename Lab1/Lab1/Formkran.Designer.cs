namespace Lab1
{
    partial class Formkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formkran));
            this.pictureBoxkran = new System.Windows.Forms.PictureBox();
            this.buttonCreateGusmashina = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonKran = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxkran)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxkran
            // 
            this.pictureBoxkran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxkran.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxkran.Name = "pictureBoxkran";
            this.pictureBoxkran.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxkran.TabIndex = 0;
            this.pictureBoxkran.TabStop = false;
            // 
            // buttonCreateGusmashina
            // 
            this.buttonCreateGusmashina.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateGusmashina.Name = "buttonCreateGusmashina";
            this.buttonCreateGusmashina.Size = new System.Drawing.Size(167, 32);
            this.buttonCreateGusmashina.TabIndex = 1;
            this.buttonCreateGusmashina.Text = "Создать гусечную машину";
            this.buttonCreateGusmashina.UseVisualStyleBackColor = true;
            this.buttonCreateGusmashina.Click += new System.EventHandler(this.buttonCreateGusmashina_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(818, 395);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(818, 431);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(854, 431);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(782, 431);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonKran
            // 
            this.buttonKran.Location = new System.Drawing.Point(197, -1);
            this.buttonKran.Name = "buttonKran";
            this.buttonKran.Size = new System.Drawing.Size(185, 33);
            this.buttonKran.TabIndex = 6;
            this.buttonKran.Text = "Создать кран";
            this.buttonKran.UseVisualStyleBackColor = true;
            this.buttonKran.Click += new System.EventHandler(this.buttonCreateKran_Click);
            // 
            // Formkran
            // 
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonKran);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateGusmashina);
            this.Controls.Add(this.pictureBoxkran);
            this.Name = "Formkran";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxkran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxkran;
        private System.Windows.Forms.Button buttonCreateGusmashina;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonKran;
    }
}

