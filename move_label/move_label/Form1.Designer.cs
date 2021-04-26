
namespace move_label
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
            this.label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.PapayaWhip;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(276, 67);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(200, 100);
            this.label.TabIndex = 0;
            this.label.Text = "Hello";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FloralWhite;
            this.button1.Font = new System.Drawing.Font("Traditional Arabic", 14F);
            this.button1.Location = new System.Drawing.Point(554, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "right";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FloralWhite;
            this.button2.Font = new System.Drawing.Font("Traditional Arabic", 14F);
            this.button2.Location = new System.Drawing.Point(317, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Up";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FloralWhite;
            this.button3.Font = new System.Drawing.Font("Traditional Arabic", 14F);
            this.button3.Location = new System.Drawing.Point(150, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "left";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FloralWhite;
            this.button4.Font = new System.Drawing.Font("Traditional Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(317, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 63);
            this.button4.TabIndex = 4;
            this.button4.Text = "down";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

