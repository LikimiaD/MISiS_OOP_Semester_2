namespace _6_lab_level_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main = new System.Windows.Forms.RichTextBox();
            this.legit = new System.Windows.Forms.RichTextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Location = new System.Drawing.Point(12, 12);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(323, 348);
            this.main.TabIndex = 0;
            this.main.Text = "";
            // 
            // legit
            // 
            this.legit.Location = new System.Drawing.Point(465, 12);
            this.legit.Name = "legit";
            this.legit.Size = new System.Drawing.Size(323, 348);
            this.legit.TabIndex = 1;
            this.legit.Text = "";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(341, 366);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(118, 72);
            this.button.TabIndex = 2;
            this.button.Text = "button1";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button);
            this.Controls.Add(this.legit);
            this.Controls.Add(this.main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox main;
        private RichTextBox legit;
        private Button button;
    }
}