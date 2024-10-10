namespace GenericComparisonApp
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
            txtInput1 = new TextBox();
            txtInput2 = new TextBox();
            btnCompare = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtInput1
            // 
            txtInput1.Location = new Point(57, 64);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(175, 35);
            txtInput1.TabIndex = 0;
            // 
            // txtInput2
            // 
            txtInput2.Location = new Point(319, 62);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(175, 35);
            txtInput2.TabIndex = 1;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(588, 57);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(131, 40);
            btnCompare.TabIndex = 2;
            btnCompare.Text = "Compare";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(57, 134);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(68, 30);
            lblResult.TabIndex = 3;
            lblResult.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 229);
            Controls.Add(lblResult);
            Controls.Add(btnCompare);
            Controls.Add(txtInput2);
            Controls.Add(txtInput1);
            Name = "Form1";
            Text = "Generic Comparisson App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput1;
        private TextBox txtInput2;
        private Button btnCompare;
        private Label lblResult;
    }
}