﻿namespace WFInicial
{
    partial class FormEx10
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(45, 28);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(115, 25);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            txtNumero.Leave += textNumero_Leave;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(75, 83);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(213, 113);
            txtResultado.TabIndex = 2;
            // 
            // FormEx10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 230);
            Controls.Add(txtResultado);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "FormEx10";
            Text = "FormEx10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtResultado;
    }
}