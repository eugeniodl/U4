namespace GenericClassForm
{
    partial class MainForm
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
            btnIntSum = new Button();
            btnDecimalSubtract = new Button();
            SuspendLayout();
            // 
            // btnIntSum
            // 
            btnIntSum.Location = new Point(36, 48);
            btnIntSum.Margin = new Padding(2);
            btnIntSum.Name = "btnIntSum";
            btnIntSum.Size = new Size(158, 36);
            btnIntSum.TabIndex = 0;
            btnIntSum.Text = "Integer Sum";
            btnIntSum.UseVisualStyleBackColor = true;
            btnIntSum.Click += btnIntSum_Click;
            // 
            // btnDecimalSubtract
            // 
            btnDecimalSubtract.Location = new Point(264, 48);
            btnDecimalSubtract.Margin = new Padding(2);
            btnDecimalSubtract.Name = "btnDecimalSubtract";
            btnDecimalSubtract.Size = new Size(158, 36);
            btnDecimalSubtract.TabIndex = 1;
            btnDecimalSubtract.Text = "Decimal Subtract";
            btnDecimalSubtract.UseVisualStyleBackColor = true;
            btnDecimalSubtract.Click += btnDecimalSubtract_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 130);
            Controls.Add(btnDecimalSubtract);
            Controls.Add(btnIntSum);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIntSum;
        private Button btnDecimalSubtract;
    }
}