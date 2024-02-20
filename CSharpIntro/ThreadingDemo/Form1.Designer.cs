namespace ThreadingDemo
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
            btnProcess1 = new Button();
            btnProcess2 = new Button();
            SuspendLayout();
            // 
            // btnProcess1
            // 
            btnProcess1.Font = new Font("Segoe UI", 12F);
            btnProcess1.Location = new Point(113, 54);
            btnProcess1.Name = "btnProcess1";
            btnProcess1.Size = new Size(85, 48);
            btnProcess1.TabIndex = 0;
            btnProcess1.Text = "işlem 1";
            btnProcess1.UseVisualStyleBackColor = true;
            btnProcess1.Click += btnProcess1_Click;
            // 
            // btnProcess2
            // 
            btnProcess2.Font = new Font("Segoe UI", 12F);
            btnProcess2.Location = new Point(248, 54);
            btnProcess2.Name = "btnProcess2";
            btnProcess2.Size = new Size(85, 48);
            btnProcess2.TabIndex = 1;
            btnProcess2.Tag = "";
            btnProcess2.Text = "işlem 2";
            btnProcess2.UseVisualStyleBackColor = true;
            btnProcess2.Click += btnProcess2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcess2);
            Controls.Add(btnProcess1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnProcess1;
        private Button btnProcess2;
    }
}
