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
            btnIntSum.Location = new Point(61, 96);
            btnIntSum.Name = "btnIntSum";
            btnIntSum.Size = new Size(270, 72);
            btnIntSum.TabIndex = 0;
            btnIntSum.Text = "Integer Sum";
            btnIntSum.UseVisualStyleBackColor = true;
            // 
            // btnDecimalSubtract
            // 
            btnDecimalSubtract.Location = new Point(452, 96);
            btnDecimalSubtract.Name = "btnDecimalSubtract";
            btnDecimalSubtract.Size = new Size(270, 72);
            btnDecimalSubtract.TabIndex = 1;
            btnDecimalSubtract.Text = "Decimal Subtract";
            btnDecimalSubtract.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 261);
            Controls.Add(btnDecimalSubtract);
            Controls.Add(btnIntSum);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIntSum;
        private Button btnDecimalSubtract;
    }
}