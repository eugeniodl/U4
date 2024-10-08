namespace GenericClassForm
{
    partial class MathOperation
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
            txtInput1.Location = new Point(32, 52);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(175, 35);
            txtInput1.TabIndex = 0;
            // 
            // txtInput2
            // 
            txtInput2.Location = new Point(235, 52);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(175, 35);
            txtInput2.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(460, 50);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(131, 40);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(32, 115);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(68, 30);
            lblResult.TabIndex = 3;
            lblResult.Text = "label1";
            // 
            // MathOperation
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 197);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtInput2);
            Controls.Add(txtInput1);
            Name = "MathOperation";
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