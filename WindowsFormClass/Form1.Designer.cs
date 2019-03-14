namespace WindowsFormClass
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtWord = new MetroFramework.Controls.MetroTextBox();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMin = new MetroFramework.Controls.MetroTextBox();
            this.txtMax = new MetroFramework.Controls.MetroTextBox();
            this.radioAlphabet = new MetroFramework.Controls.MetroRadioButton();
            this.radioNumbers = new MetroFramework.Controls.MetroRadioButton();
            this.radioAlphaNum = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(308, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(200, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "PASSWORD GENERATOR";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(308, 243);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(200, 23);
            this.txtWord.TabIndex = 8;
            this.txtWord.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(319, 296);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(421, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(307, 150);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Min Length :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(305, 194);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 25);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Max Length :";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(421, 152);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(87, 23);
            this.txtMin.TabIndex = 1;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(421, 196);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(87, 23);
            this.txtMax.TabIndex = 2;
            // 
            // radioAlphabet
            // 
            this.radioAlphabet.AutoSize = true;
            this.radioAlphabet.Location = new System.Drawing.Point(11, 38);
            this.radioAlphabet.Name = "radioAlphabet";
            this.radioAlphabet.Size = new System.Drawing.Size(76, 15);
            this.radioAlphabet.TabIndex = 3;
            this.radioAlphabet.TabStop = true;
            this.radioAlphabet.Text = "Alphabets";
            this.radioAlphabet.UseVisualStyleBackColor = true;
            // 
            // radioNumbers
            // 
            this.radioNumbers.AutoSize = true;
            this.radioNumbers.Location = new System.Drawing.Point(11, 70);
            this.radioNumbers.Name = "radioNumbers";
            this.radioNumbers.Size = new System.Drawing.Size(72, 15);
            this.radioNumbers.TabIndex = 4;
            this.radioNumbers.TabStop = true;
            this.radioNumbers.Text = "Numbers";
            this.radioNumbers.UseVisualStyleBackColor = true;
            // 
            // radioAlphaNum
            // 
            this.radioAlphaNum.AutoSize = true;
            this.radioAlphaNum.Location = new System.Drawing.Point(11, 105);
            this.radioAlphaNum.Name = "radioAlphaNum";
            this.radioAlphaNum.Size = new System.Drawing.Size(154, 15);
            this.radioAlphaNum.TabIndex = 5;
            this.radioAlphaNum.TabStop = true;
            this.radioAlphaNum.Text = "Alpha Numeric & Symbols";
            this.radioAlphaNum.UseVisualStyleBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.radioAlphaNum);
            this.metroPanel1.Controls.Add(this.radioNumbers);
            this.metroPanel1.Controls.Add(this.radioAlphabet);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(590, 130);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(172, 161);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OBI FESTUS CHINONSO";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtWord;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMin;
        private MetroFramework.Controls.MetroTextBox txtMax;
        private MetroFramework.Controls.MetroRadioButton radioAlphabet;
        private MetroFramework.Controls.MetroRadioButton radioNumbers;
        private MetroFramework.Controls.MetroRadioButton radioAlphaNum;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}

