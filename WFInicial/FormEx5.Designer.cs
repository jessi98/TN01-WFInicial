﻿namespace WFInicial
{
    partial class FormEx5
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
            txtNum3 = new TextBox();
            lblNum3 = new Label();
            txtNum2 = new TextBox();
            lblNum2 = new Label();
            txtNum1 = new TextBox();
            lblNum1 = new Label();
            btnMaiorMenor = new Button();
            SuspendLayout();
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(135, 157);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 23);
            txtNum3.TabIndex = 13;
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(66, 160);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(60, 15);
            lblNum3.TabIndex = 12;
            lblNum3.Text = "Número 3";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(135, 113);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 11;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(66, 116);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(60, 15);
            lblNum2.TabIndex = 10;
            lblNum2.Text = "Número 2";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(135, 69);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 9;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(66, 72);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(60, 15);
            lblNum1.TabIndex = 8;
            lblNum1.Text = "Número 1";
            // 
            // btnMaiorMenor
            // 
            btnMaiorMenor.Location = new Point(66, 202);
            btnMaiorMenor.Name = "btnMaiorMenor";
            btnMaiorMenor.Size = new Size(155, 23);
            btnMaiorMenor.TabIndex = 14;
            btnMaiorMenor.Text = "Mostrar Maior e Menor";
            btnMaiorMenor.UseVisualStyleBackColor = true;
            btnMaiorMenor.Click += btnMaiorMenor_Click_1;
            // 
            // FormEx5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 274);
            Controls.Add(btnMaiorMenor);
            Controls.Add(txtNum3);
            Controls.Add(lblNum3);
            Controls.Add(txtNum2);
            Controls.Add(lblNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum1);
            Name = "FormEx5";
            Text = "FormEx5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum3;
        private Label lblNum3;
        private TextBox txtNum2;
        private Label lblNum2;
        private TextBox txtNum1;
        private Label lblNum1;
        private Button btnMaiorMenor;
    }
}