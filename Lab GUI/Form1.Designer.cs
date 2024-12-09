
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
            this.MoveCircle = new System.Windows.Forms.Button();
            this.MoveRhomb = new System.Windows.Forms.Button();
            this.MoveSquare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoveCircle
            // 
            this.MoveCircle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MoveCircle.Location = new System.Drawing.Point(981, 174);
            this.MoveCircle.Name = "MoveCircle";
            this.MoveCircle.Size = new System.Drawing.Size(185, 88);
            this.MoveCircle.TabIndex = 0;
            this.MoveCircle.Text = "Move circle";
            this.MoveCircle.UseVisualStyleBackColor = false;
            this.MoveCircle.Click += new System.EventHandler(this.Move_circle);
            // 
            // MoveRhomb
            // 
            this.MoveRhomb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MoveRhomb.Location = new System.Drawing.Point(1183, 174);
            this.MoveRhomb.Name = "MoveRhomb";
            this.MoveRhomb.Size = new System.Drawing.Size(185, 88);
            this.MoveRhomb.TabIndex = 1;
            this.MoveRhomb.Text = "Move rhomb";
            this.MoveRhomb.UseVisualStyleBackColor = false;
            this.MoveRhomb.Click += new System.EventHandler(this.Move_rhomb);
            // 
            // MoveSquare
            // 
            this.MoveSquare.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MoveSquare.Location = new System.Drawing.Point(1384, 174);
            this.MoveSquare.Name = "MoveSquare";
            this.MoveSquare.Size = new System.Drawing.Size(185, 88);
            this.MoveSquare.TabIndex = 2;
            this.MoveSquare.Text = "Move square";
            this.MoveSquare.UseVisualStyleBackColor = false;
            this.MoveSquare.Click += new System.EventHandler(this.Move_square);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1625, 536);
            this.Controls.Add(this.MoveSquare);
            this.Controls.Add(this.MoveRhomb);
            this.Controls.Add(this.MoveCircle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MoveCircle;
        private System.Windows.Forms.Button MoveRhomb;
        private System.Windows.Forms.Button MoveSquare;
    }
}

