﻿namespace WindowsFormClass
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.txtTheme = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnSiteAdd = new MetroFramework.Controls.MetroButton();
            this.btnViewPasswords = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.lblSites = new MetroFramework.Controls.MetroLabel();
            this.comboSites = new MetroFramework.Controls.MetroComboBox();
            this.btnDark = new MetroFramework.Controls.MetroButton();
            this.btnLight = new MetroFramework.Controls.MetroButton();
            this.button1 = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.radioAlphaNum = new MetroFramework.Controls.MetroRadioButton();
            this.radioNumbers = new MetroFramework.Controls.MetroRadioButton();
            this.radioAlphabet = new MetroFramework.Controls.MetroRadioButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.txtMax = new MetroFramework.Controls.MetroTextBox();
            this.txtMin = new MetroFramework.Controls.MetroTextBox();
            this.txtWord = new MetroFramework.Controls.MetroTextBox();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(306, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(200, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "PASSWORD GENERATOR";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(307, 167);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(110, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Min Length :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(305, 211);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 25);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Max Length :";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // txtTheme
            // 
            this.txtTheme.AutoSize = true;
            this.txtTheme.FontSize = MetroFramework.MetroLabelSize.Small;
            this.txtTheme.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txtTheme.Location = new System.Drawing.Point(570, 10);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.Size = new System.Drawing.Size(90, 15);
            this.txtTheme.TabIndex = 1;
            this.txtTheme.Text = "Change Theme";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnSiteAdd);
            this.metroPanel2.Controls.Add(this.btnViewPasswords);
            this.metroPanel2.Controls.Add(this.btnSave);
            this.metroPanel2.Controls.Add(this.lblSites);
            this.metroPanel2.Controls.Add(this.comboSites);
            this.metroPanel2.Controls.Add(this.btnDark);
            this.metroPanel2.Controls.Add(this.btnLight);
            this.metroPanel2.Controls.Add(this.button1);
            this.metroPanel2.Controls.Add(this.metroPanel1);
            this.metroPanel2.Controls.Add(this.btnClear);
            this.metroPanel2.Controls.Add(this.btnGenerate);
            this.metroPanel2.Controls.Add(this.txtMax);
            this.metroPanel2.Controls.Add(this.txtMin);
            this.metroPanel2.Controls.Add(this.txtWord);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.txtTheme);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(-1, 50);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(802, 402);
            this.metroPanel2.TabIndex = 11;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnSiteAdd
            // 
            this.btnSiteAdd.Location = new System.Drawing.Point(588, 353);
            this.btnSiteAdd.Name = "btnSiteAdd";
            this.btnSiteAdd.Size = new System.Drawing.Size(65, 24);
            this.btnSiteAdd.TabIndex = 15;
            this.btnSiteAdd.Text = "Add Site";
            this.btnSiteAdd.Click += new System.EventHandler(this.btnSiteAdd_Click);
            // 
            // btnViewPasswords
            // 
            this.btnViewPasswords.Location = new System.Drawing.Point(666, 353);
            this.btnViewPasswords.Name = "btnViewPasswords";
            this.btnViewPasswords.Size = new System.Drawing.Size(94, 24);
            this.btnViewPasswords.TabIndex = 14;
            this.btnViewPasswords.Text = "View Passwords";
            this.btnViewPasswords.Click += new System.EventHandler(this.btnViewPasswords_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(462, 314);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 22);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSites
            // 
            this.lblSites.AutoSize = true;
            this.lblSites.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSites.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSites.Location = new System.Drawing.Point(308, 131);
            this.lblSites.Name = "lblSites";
            this.lblSites.Size = new System.Drawing.Size(58, 25);
            this.lblSites.TabIndex = 12;
            this.lblSites.Text = "Sites :";
            // 
            // comboSites
            // 
            this.comboSites.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteBindingSource, "SiteName", true));
            this.comboSites.FormattingEnabled = true;
            this.comboSites.ItemHeight = 23;
            this.comboSites.Location = new System.Drawing.Point(370, 130);
            this.comboSites.Name = "comboSites";
            this.comboSites.Size = new System.Drawing.Size(148, 29);
            this.comboSites.TabIndex = 11;
            // 
            // btnDark
            // 
            this.btnDark.Location = new System.Drawing.Point(719, 6);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(47, 25);
            this.btnDark.TabIndex = 10;
            this.btnDark.Text = "Dark";
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
            // 
            // btnLight
            // 
            this.btnLight.Location = new System.Drawing.Point(666, 6);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(47, 25);
            this.btnLight.TabIndex = 10;
            this.btnLight.Text = "Light";
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(485, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.radioAlphaNum);
            this.metroPanel1.Controls.Add(this.radioNumbers);
            this.metroPanel1.Controls.Add(this.radioAlphabet);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(588, 121);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(172, 161);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(388, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(309, 313);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(65, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(421, 213);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(97, 23);
            this.txtMax.TabIndex = 2;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(421, 169);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(97, 23);
            this.txtMin.TabIndex = 1;
            // 
            // txtWord
            // 
            this.txtWord.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteBindingSource, "Password", true));
            this.txtWord.Location = new System.Drawing.Point(308, 260);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(167, 33);
            this.txtWord.TabIndex = 8;
            this.txtWord.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataSource = typeof(WindowsFormClass.Site);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "OBI FESTUS CHINONSO";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel txtTheme;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnDark;
        private MetroFramework.Controls.MetroButton btnLight;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton radioAlphaNum;
        private MetroFramework.Controls.MetroRadioButton radioNumbers;
        private MetroFramework.Controls.MetroRadioButton radioAlphabet;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private MetroFramework.Controls.MetroTextBox txtMax;
        private MetroFramework.Controls.MetroTextBox txtMin;
        private MetroFramework.Controls.MetroTextBox txtWord;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel lblSites;
        private MetroFramework.Controls.MetroComboBox comboSites;
        private MetroFramework.Controls.MetroButton btnSiteAdd;
        private MetroFramework.Controls.MetroButton btnViewPasswords;
        private System.Windows.Forms.BindingSource siteBindingSource;
    }
}

