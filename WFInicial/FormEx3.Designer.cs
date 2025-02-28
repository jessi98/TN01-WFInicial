namespace WFInicial
{
    partial class FormEx3
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
            btnMaior = new Button();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            lblNum1 = new Label();
            LblNum2 = new Label();
            SuspendLayout();
            // 
            // btnMaior
            // 
            btnMaior.Location = new Point(66, 136);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(126, 23);
            btnMaior.TabIndex = 0;
            btnMaior.Text = "Mostrar Maior";
            btnMaior.UseVisualStyleBackColor = true;
            btnMaior.Click += btnMaior_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(110, 40);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(110, 86);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 2;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(44, 43);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(60, 15);
            lblNum1.TabIndex = 3;
            lblNum1.Text = "Número 1";
            lblNum1.Click += label1_Click;
            // 
            // LblNum2
            // 
            LblNum2.AutoSize = true;
            LblNum2.Location = new Point(44, 89);
            LblNum2.Name = "LblNum2";
            LblNum2.Size = new Size(60, 15);
            LblNum2.TabIndex = 4;
            LblNum2.Text = "Número 2";
            // 
            // FormEx3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 205);
            Controls.Add(LblNum2);
            Controls.Add(lblNum1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(btnMaior);
            Name = "FormEx3";
            Text = "FormEx3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMaior;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label lblNum1;
        private Label LblNum2;
    }
}