namespace color_system
{
    partial class Form2
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
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(150, 327);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(136, 60);
            this.btn4.TabIndex = 19;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Visible = false;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(150, 242);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(136, 60);
            this.btn3.TabIndex = 18;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Visible = false;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(150, 153);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(136, 60);
            this.btn2.TabIndex = 17;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Visible = false;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(150, 66);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(136, 60);
            this.btn1.TabIndex = 16;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Visible = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 409);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btn1;
        public System.Windows.Forms.Button btn2;
        public System.Windows.Forms.Button btn4;
        public System.Windows.Forms.Button btn3;
    }
}