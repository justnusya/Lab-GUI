
namespace Lab_GUI
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
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonRhomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(12, 436);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(185, 88);
            this.buttonCircle.TabIndex = 0;
            this.buttonCircle.Text = "buttonCircle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonRhomb
            // 
            this.buttonRhomb.Location = new System.Drawing.Point(237, 436);
            this.buttonRhomb.Name = "buttonRhomb";
            this.buttonRhomb.Size = new System.Drawing.Size(185, 88);
            this.buttonRhomb.TabIndex = 1;
            this.buttonRhomb.Text = "buttonRhomb";
            this.buttonRhomb.UseVisualStyleBackColor = true;
            this.buttonRhomb.Click += new System.EventHandler(this.buttonRhomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 536);
            this.Controls.Add(this.buttonRhomb);
            this.Controls.Add(this.buttonCircle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonRhomb;
    }
}

