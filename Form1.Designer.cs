namespace GrammarChecker
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
            this.GrammerLabel = new System.Windows.Forms.Label();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GrammerLabel
            // 
            this.GrammerLabel.AutoSize = true;
            this.GrammerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GrammerLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.GrammerLabel.Location = new System.Drawing.Point(12, 9);
            this.GrammerLabel.Name = "GrammerLabel";
            this.GrammerLabel.Size = new System.Drawing.Size(107, 105);
            this.GrammerLabel.TabIndex = 0;
            this.GrammerLabel.Text = "E → TB\r\nB → \'+\' TB | ε\r\nT → FC\r\nC → \'*\' FC | ε\r\nF → \'(\' E \')\' | id";
            // 
            // inputTB
            // 
            this.inputTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.inputTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.inputTB.ForeColor = System.Drawing.Color.Gainsboro;
            this.inputTB.Location = new System.Drawing.Point(151, 12);
            this.inputTB.Multiline = true;
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(225, 175);
            this.inputTB.TabIndex = 1;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.resultLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.resultLabel.Location = new System.Drawing.Point(407, 9);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(121, 42);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Input #1: Accept\r\nInput #2: Reject";
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.checkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBtn.Location = new System.Drawing.Point(242, 193);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(70, 32);
            this.checkBtn.TabIndex = 3;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(540, 237);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.GrammerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Grammer Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GrammerLabel;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button checkBtn;
    }
}

