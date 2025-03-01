namespace WFInicial
{
    partial class FormEx6
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
            btnCalcule = new Button();
            lblNome = new Label();
            lblquantidadeHoras = new Label();
            lblvalorHora = new Label();
            txtNome = new TextBox();
            txtquantidadeHoras = new TextBox();
            txtvalorHora = new TextBox();
            SuspendLayout();
            // 
            // btnCalcule
            // 
            btnCalcule.Location = new Point(103, 175);
            btnCalcule.Name = "btnCalcule";
            btnCalcule.Size = new Size(75, 23);
            btnCalcule.TabIndex = 0;
            btnCalcule.Text = "Calcular";
            btnCalcule.UseVisualStyleBackColor = true;
            btnCalcule.Click += btnCalcule_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(60, 46);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblquantidadeHoras
            // 
            lblquantidadeHoras.AutoSize = true;
            lblquantidadeHoras.Location = new Point(1, 93);
            lblquantidadeHoras.Name = "lblquantidadeHoras";
            lblquantidadeHoras.Size = new Size(119, 15);
            lblquantidadeHoras.TabIndex = 2;
            lblquantidadeHoras.Text = "Quantidade de Horas";
            lblquantidadeHoras.Click += lblquantidadeHoras_Click;
            // 
            // lblvalorHora
            // 
            lblvalorHora.AutoSize = true;
            lblvalorHora.Location = new Point(60, 134);
            lblvalorHora.Name = "lblvalorHora";
            lblvalorHora.Size = new Size(62, 15);
            lblvalorHora.TabIndex = 3;
            lblvalorHora.Text = "Valor Hora";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(126, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 4;
            // 
            // txtquantidadeHoras
            // 
            txtquantidadeHoras.Location = new Point(126, 90);
            txtquantidadeHoras.Name = "txtquantidadeHoras";
            txtquantidadeHoras.Size = new Size(100, 23);
            txtquantidadeHoras.TabIndex = 5;
            // 
            // txtvalorHora
            // 
            txtvalorHora.Location = new Point(126, 131);
            txtvalorHora.Name = "txtvalorHora";
            txtvalorHora.Size = new Size(100, 23);
            txtvalorHora.TabIndex = 6;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 232);
            Controls.Add(txtvalorHora);
            Controls.Add(txtquantidadeHoras);
            Controls.Add(txtNome);
            Controls.Add(lblvalorHora);
            Controls.Add(lblquantidadeHoras);
            Controls.Add(lblNome);
            Controls.Add(btnCalcule);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcule;
        private Label lblNome;
        private Label lblquantidadeHoras;
        private Label lblvalorHora;
        private TextBox txtNome;
        private TextBox txtquantidadeHoras;
        private TextBox txtvalorHora;
    }
}