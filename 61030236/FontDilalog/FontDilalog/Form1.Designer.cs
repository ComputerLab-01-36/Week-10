namespace FontDilalog
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.bntFontDialog = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.btnUpdateRichTextBox1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntFontDialog
            // 
            this.bntFontDialog.Location = new System.Drawing.Point(52, 12);
            this.bntFontDialog.Name = "bntFontDialog";
            this.bntFontDialog.Size = new System.Drawing.Size(80, 30);
            this.bntFontDialog.TabIndex = 0;
            this.bntFontDialog.Text = "Font Dialog";
            this.bntFontDialog.UseVisualStyleBackColor = true;
            this.bntFontDialog.Click += new System.EventHandler(this.bntFontDialog_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(463, 29);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.fontDialog1;
            this.propertyGrid1.Size = new System.Drawing.Size(308, 309);
            this.propertyGrid1.TabIndex = 1;
            // 
            // btnUpdateRichTextBox1
            // 
            this.btnUpdateRichTextBox1.Location = new System.Drawing.Point(52, 122);
            this.btnUpdateRichTextBox1.Name = "btnUpdateRichTextBox1";
            this.btnUpdateRichTextBox1.Size = new System.Drawing.Size(76, 28);
            this.btnUpdateRichTextBox1.TabIndex = 2;
            this.btnUpdateRichTextBox1.Text = "Update text";
            this.btnUpdateRichTextBox1.UseVisualStyleBackColor = true;
            this.btnUpdateRichTextBox1.Click += new System.EventHandler(this.btnUpdateRichTextBox1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(84, 62);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(176, 34);
            this.TextBox1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(84, 166);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(176, 42);
            this.richTextBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.btnUpdateRichTextBox1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.bntFontDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button bntFontDialog;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btnUpdateRichTextBox1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox richTextBox1;
    }
}

