namespace Dialog
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFile = new System.Windows.Forms.Button();
            this.changeColour = new System.Windows.Forms.Button();
            this.nextForm = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(40, 49);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(192, 47);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Open a Text File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // changeColour
            // 
            this.changeColour.Location = new System.Drawing.Point(40, 173);
            this.changeColour.Name = "changeColour";
            this.changeColour.Size = new System.Drawing.Size(192, 47);
            this.changeColour.TabIndex = 1;
            this.changeColour.Text = "Change Background Colour";
            this.changeColour.UseVisualStyleBackColor = true;
            this.changeColour.Click += new System.EventHandler(this.changeColour_Click);
            // 
            // nextForm
            // 
            this.nextForm.Location = new System.Drawing.Point(40, 295);
            this.nextForm.Name = "nextForm";
            this.nextForm.Size = new System.Drawing.Size(192, 47);
            this.nextForm.TabIndex = 2;
            this.nextForm.Text = "Go to Next Form";
            this.nextForm.UseVisualStyleBackColor = true;
            this.nextForm.Click += new System.EventHandler(this.nextForm_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(292, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 171);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 395);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.nextForm);
            this.Controls.Add(this.changeColour);
            this.Controls.Add(this.openFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button changeColour;
        private System.Windows.Forms.Button nextForm;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

