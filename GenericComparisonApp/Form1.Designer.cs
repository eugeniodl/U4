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
            txtValue1 = new TextBox();
            txtValue2 = new TextBox();
            btnCompare = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtValue1
            // 
            txtValue1.Location = new Point(56, 50);
            txtValue1.Name = "txtValue1";
            txtValue1.Size = new Size(125, 27);
            txtValue1.TabIndex = 0;
            // 
            // txtValue2
            // 
            txtValue2.Location = new Point(249, 50);
            txtValue2.Name = "txtValue2";
            txtValue2.Size = new Size(125, 27);
            txtValue2.TabIndex = 1;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(447, 50);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(94, 29);
            btnCompare.TabIndex = 2;
            btnCompare.Text = "Compare";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(56, 105);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 3;
            lblResult.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 159);
            Controls.Add(lblResult);
            Controls.Add(btnCompare);
            Controls.Add(txtValue2);
            Controls.Add(txtValue1);
            Name = "Form1";
            Text = "Generic Comparison App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValue1;
        private TextBox txtValue2;
        private Button btnCompare;
        private Label lblResult;
    }
}