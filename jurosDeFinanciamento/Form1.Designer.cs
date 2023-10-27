namespace jurosDeFinanciamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            btnCalcularButton = new Button();
            numeroDeParcelas = new TextBox();
            label3 = new Label();
            valorPago = new Label();
            totalJuros = new Label();
            resultadoFinal = new Label();
            taxaDeJurosAnual = new TextBox();
            principal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(284, 16);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 0;
            label1.Text = "Valor principal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(268, 62);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 3;
            label2.Text = "Taxa de Juros Anual";
            // 
            // btnCalcularButton
            // 
            btnCalcularButton.Anchor = AnchorStyles.Left;
            btnCalcularButton.BackgroundImage = (Image)resources.GetObject("btnCalcularButton.BackgroundImage");
            btnCalcularButton.BackgroundImageLayout = ImageLayout.None;
            btnCalcularButton.FlatStyle = FlatStyle.Flat;
            btnCalcularButton.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalcularButton.Location = new Point(268, 172);
            btnCalcularButton.Margin = new Padding(3, 2, 3, 2);
            btnCalcularButton.Name = "btnCalcularButton";
            btnCalcularButton.Size = new Size(154, 28);
            btnCalcularButton.TabIndex = 4;
            btnCalcularButton.Text = "Calcular";
            btnCalcularButton.UseVisualStyleBackColor = true;
            btnCalcularButton.Click += btnCalcularButton_Click;
            // 
            // numeroDeParcelas
            // 
            numeroDeParcelas.Location = new Point(284, 130);
            numeroDeParcelas.Margin = new Padding(3, 2, 3, 2);
            numeroDeParcelas.Name = "numeroDeParcelas";
            numeroDeParcelas.Size = new Size(121, 23);
            numeroDeParcelas.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(309, 107);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 7;
            label3.Text = "Parcelas";
            // 
            // valorPago
            // 
            valorPago.AutoSize = true;
            valorPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            valorPago.ForeColor = SystemColors.Highlight;
            valorPago.Location = new Point(272, 221);
            valorPago.Name = "valorPago";
            valorPago.Size = new Size(125, 21);
            valorPago.TabIndex = 8;
            valorPago.Text = "Valor Da Parcela:";
            // 
            // totalJuros
            // 
            totalJuros.AutoSize = true;
            totalJuros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalJuros.ForeColor = SystemColors.Highlight;
            totalJuros.Location = new Point(284, 242);
            totalJuros.Name = "totalJuros";
            totalJuros.Size = new Size(107, 21);
            totalJuros.TabIndex = 9;
            totalJuros.Text = "Total de Juros:";
            // 
            // resultadoFinal
            // 
            resultadoFinal.AutoSize = true;
            resultadoFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoFinal.ForeColor = SystemColors.Highlight;
            resultadoFinal.Location = new Point(296, 263);
            resultadoFinal.Name = "resultadoFinal";
            resultadoFinal.Size = new Size(83, 21);
            resultadoFinal.TabIndex = 10;
            resultadoFinal.Text = "Total Pago:";
            // 
            // taxaDeJurosAnual
            // 
            taxaDeJurosAnual.Location = new Point(293, 85);
            taxaDeJurosAnual.Margin = new Padding(3, 2, 3, 2);
            taxaDeJurosAnual.Name = "taxaDeJurosAnual";
            taxaDeJurosAnual.Size = new Size(110, 23);
            taxaDeJurosAnual.TabIndex = 11;
            // 
            // principal
            // 
            principal.Location = new Point(293, 39);
            principal.Margin = new Padding(3, 2, 3, 2);
            principal.Name = "principal";
            principal.Size = new Size(110, 23);
            principal.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(principal);
            Controls.Add(taxaDeJurosAnual);
            Controls.Add(resultadoFinal);
            Controls.Add(totalJuros);
            Controls.Add(valorPago);
            Controls.Add(label3);
            Controls.Add(numeroDeParcelas);
            Controls.Add(btnCalcularButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnCalcularButton;
        private TextBox numeroDeParcelas;
        private Label label3;
        private Label valorPago;
        private Label totalJuros;
        private Label resultadoFinal;
        private TextBox taxaDeJurosAnual;
        private TextBox principal;
    }
}