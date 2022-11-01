
namespace Petrus_simple_calculator
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
            this.Calculator = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Calculator.Location = new System.Drawing.Point(202, 127);
            this.Calculator.Multiline = true;
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(235, 38);
            this.Calculator.TabIndex = 0;
            this.Calculator.Text = "PETRUS  SIMPLE  CALCULATOR ";
            this.Calculator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(111, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "CLICK HERE TO GO TO OUR SIMPLE CALCULATOR APP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Petrus_simple_calculator.Properties.Resources.BACK_IMAGE;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Calculator);
            this.Name = "Form1";
            this.Text = "9";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Calculator;
        private System.Windows.Forms.Button button1;
    }
}

