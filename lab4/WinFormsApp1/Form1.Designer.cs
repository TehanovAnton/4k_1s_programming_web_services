
namespace WinFormsApp1
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
            this.x_k = new System.Windows.Forms.TextBox();
            this.x_f = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.y_f = new System.Windows.Forms.TextBox();
            this.y_k = new System.Windows.Forms.TextBox();
            this.x_s = new System.Windows.Forms.TextBox();
            this.y_s = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // x_k
            // 
            this.x_k.Location = new System.Drawing.Point(170, 88);
            this.x_k.Name = "x_k";
            this.x_k.Size = new System.Drawing.Size(125, 27);
            this.x_k.TabIndex = 0;
            // 
            // x_f
            // 
            this.x_f.Location = new System.Drawing.Point(170, 121);
            this.x_f.Name = "x_f";
            this.x_f.Size = new System.Drawing.Size(125, 27);
            this.x_f.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(170, 154);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(125, 27);
            this.result.TabIndex = 2;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(313, 154);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(94, 29);
            this.sum.TabIndex = 4;
            this.sum.Text = "Sum";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.button2_Click);
            // 
            // y_f
            // 
            this.y_f.Location = new System.Drawing.Point(313, 121);
            this.y_f.Name = "y_f";
            this.y_f.Size = new System.Drawing.Size(125, 27);
            this.y_f.TabIndex = 5;
            this.y_f.TextChanged += new System.EventHandler(this.y_f_TextChanged);
            // 
            // y_k
            // 
            this.y_k.Location = new System.Drawing.Point(313, 88);
            this.y_k.Name = "y_k";
            this.y_k.Size = new System.Drawing.Size(125, 27);
            this.y_k.TabIndex = 6;
            // 
            // x_s
            // 
            this.x_s.Location = new System.Drawing.Point(170, 55);
            this.x_s.Name = "x_s";
            this.x_s.Size = new System.Drawing.Size(125, 27);
            this.x_s.TabIndex = 7;
            // 
            // y_s
            // 
            this.y_s.Location = new System.Drawing.Point(313, 55);
            this.y_s.Name = "y_s";
            this.y_s.Size = new System.Drawing.Size(125, 27);
            this.y_s.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.y_s);
            this.Controls.Add(this.x_s);
            this.Controls.Add(this.y_k);
            this.Controls.Add(this.y_f);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.result);
            this.Controls.Add(this.x_f);
            this.Controls.Add(this.x_k);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x_k;
        private System.Windows.Forms.TextBox x_f;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.TextBox y_f;
        private System.Windows.Forms.TextBox y_k;
        private System.Windows.Forms.TextBox x_s;
        private System.Windows.Forms.TextBox y_s;
    }
}

