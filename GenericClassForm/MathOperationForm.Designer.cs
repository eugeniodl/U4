namespace GenericClassForm
{
    partial class MathOperationForm
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
            txtInput1 = new TextBox();
            txtInput2 = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtInput1
            // 
            txtInput1.Location = new Point(19, 26);
            txtInput1.Margin = new Padding(2);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(104, 23);
            txtInput1.TabIndex = 0;
            // 
            // txtInput2
            // 
            txtInput2.Location = new Point(137, 26);
            txtInput2.Margin = new Padding(2);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(104, 23);
            txtInput2.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(268, 25);
            btnCalculate.Margin = new Padding(2);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(76, 24);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(19, 58);
            lblResult.Margin = new Padding(2, 0, 2, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(45, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result: ";
            // 
            // MathOperationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 98);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtInput2);
            Controls.Add(txtInput1);
            Margin = new Padding(2);
            Name = "MathOperationForm";
            Text = "Generic Math Operation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput1;
        private TextBox txtInput2;
        private Button btnCalculate;
        private Label lblResult;
    }
}