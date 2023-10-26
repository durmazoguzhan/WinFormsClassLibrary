namespace WinFormsReflectionClassLibrary
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
            label1 = new Label();
            label2 = new Label();
            numSayi1 = new NumericUpDown();
            numSayi2 = new NumericUpDown();
            button1 = new Button();
            lblSonuc = new Label();
            ((System.ComponentModel.ISupportInitialize)numSayi1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSayi2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 72);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Sayı 1 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 105);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Sayı 2 :";
            // 
            // numSayi1
            // 
            numSayi1.Location = new Point(142, 70);
            numSayi1.Name = "numSayi1";
            numSayi1.Size = new Size(150, 27);
            numSayi1.TabIndex = 2;
            // 
            // numSayi2
            // 
            numSayi2.Location = new Point(142, 103);
            numSayi2.Name = "numSayi2";
            numSayi2.Size = new Size(150, 27);
            numSayi2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(298, 68);
            button1.Name = "button1";
            button1.Size = new Size(94, 62);
            button1.TabIndex = 4;
            button1.Text = "TOPLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(194, 161);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(50, 20);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 236);
            Controls.Add(lblSonuc);
            Controls.Add(button1);
            Controls.Add(numSayi2);
            Controls.Add(numSayi1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numSayi1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSayi2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numSayi1;
        private NumericUpDown numSayi2;
        private Button button1;
        private Label lblSonuc;
    }
}