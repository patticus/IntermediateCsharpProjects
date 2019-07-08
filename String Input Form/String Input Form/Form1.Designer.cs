namespace String_Input_Form
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
            this.txtAllStrings = new System.Windows.Forms.RichTextBox();
            this.lblTypeInBox = new System.Windows.Forms.Label();
            this.btnDisplayInfo = new System.Windows.Forms.Button();
            this.lblLetters = new System.Windows.Forms.Label();
            this.lblSpaces = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLetterCount = new System.Windows.Forms.Label();
            this.lblSpacesCount = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblCharacterCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAllStrings
            // 
            this.txtAllStrings.Location = new System.Drawing.Point(35, 87);
            this.txtAllStrings.Name = "txtAllStrings";
            this.txtAllStrings.Size = new System.Drawing.Size(451, 299);
            this.txtAllStrings.TabIndex = 0;
            this.txtAllStrings.Text = "";
            this.txtAllStrings.TextChanged += new System.EventHandler(this.txtAllStrings_TextChanged);
            // 
            // lblTypeInBox
            // 
            this.lblTypeInBox.AutoSize = true;
            this.lblTypeInBox.Location = new System.Drawing.Point(32, 67);
            this.lblTypeInBox.Name = "lblTypeInBox";
            this.lblTypeInBox.Size = new System.Drawing.Size(245, 17);
            this.lblTypeInBox.TabIndex = 1;
            this.lblTypeInBox.Text = "Type anything you want into this box: ";
            // 
            // btnDisplayInfo
            // 
            this.btnDisplayInfo.Location = new System.Drawing.Point(164, 392);
            this.btnDisplayInfo.Name = "btnDisplayInfo";
            this.btnDisplayInfo.Size = new System.Drawing.Size(184, 29);
            this.btnDisplayInfo.TabIndex = 2;
            this.btnDisplayInfo.Text = "Display Info";
            this.btnDisplayInfo.UseVisualStyleBackColor = true;
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Location = new System.Drawing.Point(573, 87);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(159, 17);
            this.lblLetters.TabIndex = 3;
            this.lblLetters.Text = "Number of Each Letter: ";
            // 
            // lblSpaces
            // 
            this.lblSpaces.AutoSize = true;
            this.lblSpaces.Location = new System.Drawing.Point(599, 308);
            this.lblSpaces.Name = "lblSpaces";
            this.lblSpaces.Size = new System.Drawing.Size(133, 17);
            this.lblSpaces.TabIndex = 4;
            this.lblSpaces.Text = "Number of Spaces: ";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(605, 340);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(127, 17);
            this.lblWords.TabIndex = 5;
            this.lblWords.Text = "Number of Words: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Characters: ";
            // 
            // lblLetterCount
            // 
            this.lblLetterCount.AutoSize = true;
            this.lblLetterCount.Location = new System.Drawing.Point(758, 87);
            this.lblLetterCount.Name = "lblLetterCount";
            this.lblLetterCount.Size = new System.Drawing.Size(16, 17);
            this.lblLetterCount.TabIndex = 7;
            this.lblLetterCount.Text = "0";
            // 
            // lblSpacesCount
            // 
            this.lblSpacesCount.AutoSize = true;
            this.lblSpacesCount.Location = new System.Drawing.Point(758, 308);
            this.lblSpacesCount.Name = "lblSpacesCount";
            this.lblSpacesCount.Size = new System.Drawing.Size(16, 17);
            this.lblSpacesCount.TabIndex = 8;
            this.lblSpacesCount.Text = "0";
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(758, 340);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(16, 17);
            this.lblWordCount.TabIndex = 9;
            this.lblWordCount.Text = "0";
            // 
            // lblCharacterCount
            // 
            this.lblCharacterCount.AutoSize = true;
            this.lblCharacterCount.Location = new System.Drawing.Point(758, 369);
            this.lblCharacterCount.Name = "lblCharacterCount";
            this.lblCharacterCount.Size = new System.Drawing.Size(16, 17);
            this.lblCharacterCount.TabIndex = 10;
            this.lblCharacterCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 459);
            this.Controls.Add(this.lblCharacterCount);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.lblSpacesCount);
            this.Controls.Add(this.lblLetterCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.lblSpaces);
            this.Controls.Add(this.lblLetters);
            this.Controls.Add(this.btnDisplayInfo);
            this.Controls.Add(this.lblTypeInBox);
            this.Controls.Add(this.txtAllStrings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAllStrings;
        private System.Windows.Forms.Label lblTypeInBox;
        private System.Windows.Forms.Button btnDisplayInfo;
        private System.Windows.Forms.Label lblLetters;
        private System.Windows.Forms.Label lblSpaces;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLetterCount;
        private System.Windows.Forms.Label lblSpacesCount;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblCharacterCount;
    }
}

