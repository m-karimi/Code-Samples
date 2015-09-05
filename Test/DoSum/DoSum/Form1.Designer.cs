namespace DoSum
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
            this.Number1 = new System.Windows.Forms.TextBox();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.SumBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(37, 29);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(100, 20);
            this.Number1.TabIndex = 0;
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(162, 29);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(100, 20);
            this.Number2.TabIndex = 1;
            // 
            // SumBTN
            // 
            this.SumBTN.Location = new System.Drawing.Point(111, 77);
            this.SumBTN.Name = "SumBTN";
            this.SumBTN.Size = new System.Drawing.Size(75, 23);
            this.SumBTN.TabIndex = 2;
            this.SumBTN.Text = "Sum";
            this.SumBTN.UseVisualStyleBackColor = true;
            this.SumBTN.Click += new System.EventHandler(this.SumBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 112);
            this.Controls.Add(this.SumBTN);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.TextBox Number2;
        private System.Windows.Forms.Button SumBTN;
    }
}

