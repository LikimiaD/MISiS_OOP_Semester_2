namespace _6_lab_level_1
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
            this.main_textbox = new System.Windows.Forms.RichTextBox();
            this.kicked_textbox = new System.Windows.Forms.RichTextBox();
            this.generate_button = new System.Windows.Forms.Button();
            this.filter_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main_textbox
            // 
            this.main_textbox.Location = new System.Drawing.Point(12, 46);
            this.main_textbox.Name = "main_textbox";
            this.main_textbox.Size = new System.Drawing.Size(522, 290);
            this.main_textbox.TabIndex = 0;
            this.main_textbox.Text = "";
            // 
            // kicked_textbox
            // 
            this.kicked_textbox.Location = new System.Drawing.Point(556, 46);
            this.kicked_textbox.Name = "kicked_textbox";
            this.kicked_textbox.Size = new System.Drawing.Size(217, 290);
            this.kicked_textbox.TabIndex = 1;
            this.kicked_textbox.Text = "";
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(304, 363);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(122, 51);
            this.generate_button.TabIndex = 2;
            this.generate_button.Text = "Generate";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // filter_button
            // 
            this.filter_button.Location = new System.Drawing.Point(610, 363);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(122, 51);
            this.filter_button.TabIndex = 3;
            this.filter_button.Text = "Filter";
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filter_button);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.kicked_textbox);
            this.Controls.Add(this.main_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox main_textbox;
        private RichTextBox kicked_textbox;
        private Button generate_button;
        private Button filter_button;
    }
}