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
            txtInput1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput1.Location = new Point(47, 51);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(175, 45);
            txtInput1.TabIndex = 0;
            // 
            // txtInput2
            // 
            txtInput2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput2.Location = new Point(292, 51);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(175, 45);
            txtInput2.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.Location = new Point(524, 48);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(155, 50);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(47, 150);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(106, 38);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result: ";
            // 
            // MathOperationForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 233);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtInput2);
            Controls.Add(txtInput1);
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