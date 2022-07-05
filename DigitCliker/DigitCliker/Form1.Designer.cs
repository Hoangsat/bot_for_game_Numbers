namespace DigitCliker
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
            this.text_x = new System.Windows.Forms.TextBox();
            this.text_y = new System.Windows.Forms.TextBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_repeat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_x
            // 
            this.text_x.BackColor = System.Drawing.Color.Cornsilk;
            this.text_x.Location = new System.Drawing.Point(24, 32);
            this.text_x.Multiline = true;
            this.text_x.Name = "text_x";
            this.text_x.ReadOnly = true;
            this.text_x.Size = new System.Drawing.Size(105, 193);
            this.text_x.TabIndex = 0;
            // 
            // text_y
            // 
            this.text_y.BackColor = System.Drawing.Color.Cornsilk;
            this.text_y.Location = new System.Drawing.Point(144, 32);
            this.text_y.Multiline = true;
            this.text_y.Name = "text_y";
            this.text_y.ReadOnly = true;
            this.text_y.Size = new System.Drawing.Size(102, 193);
            this.text_y.TabIndex = 1;
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.Location = new System.Drawing.Point(267, 32);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(176, 53);
            this.button_reset.TabIndex = 2;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(267, 107);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(176, 53);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Add cordination";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_repeat
            // 
            this.button_repeat.Location = new System.Drawing.Point(267, 166);
            this.button_repeat.Name = "button_repeat";
            this.button_repeat.Size = new System.Drawing.Size(176, 53);
            this.button_repeat.TabIndex = 4;
            this.button_repeat.Text = "9 time";
            this.button_repeat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 263);
            this.Controls.Add(this.button_repeat);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.text_y);
            this.Controls.Add(this.text_x);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Autocliker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_x;
        private System.Windows.Forms.TextBox text_y;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_repeat;
    }
}

