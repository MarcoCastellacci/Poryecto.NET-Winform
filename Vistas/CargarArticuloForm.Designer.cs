namespace App_Stock.Vistas
{
    partial class CargarArticuloForm
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
            txtNombre = new TextBox();
            txtMarca = new TextBox();
            txtProveedor = new TextBox();
            txtTipo = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            minStockNum = new NumericUpDown();
            costoNum = new NumericUpDown();
            margenNum = new NumericUpDown();
            txtId = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtCodigo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)minStockNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)costoNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)margenNum).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.GradientInactiveCaption;
            txtNombre.Location = new Point(165, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(328, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = SystemColors.GradientInactiveCaption;
            txtMarca.Location = new Point(165, 119);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(328, 23);
            txtMarca.TabIndex = 1;
            // 
            // txtProveedor
            // 
            txtProveedor.BackColor = SystemColors.GradientInactiveCaption;
            txtProveedor.Location = new Point(165, 162);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(328, 23);
            txtProveedor.TabIndex = 2;
            // 
            // txtTipo
            // 
            txtTipo.BackColor = SystemColors.GradientInactiveCaption;
            txtTipo.Location = new Point(165, 205);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(328, 23);
            txtTipo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 28);
            label1.TabIndex = 7;
            label1.Text = "Carga tu Articulo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 396);
            label8.Name = "label8";
            label8.Size = new Size(69, 21);
            label8.TabIndex = 15;
            label8.Text = "Margen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 81);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 121);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 10;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 164);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 11;
            label4.Text = "Proveedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 207);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 12;
            label5.Text = "Tipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 306);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 13;
            label6.Text = "Min-Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 349);
            label7.Name = "label7";
            label7.Size = new Size(53, 21);
            label7.TabIndex = 14;
            label7.Text = "Costo";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Sitka Heading Semibold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(586, 390);
            button1.Name = "button1";
            button1.Size = new Size(202, 48);
            button1.TabIndex = 16;
            button1.Text = "Cargar Articulo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // minStockNum
            // 
            minStockNum.BackColor = SystemColors.GradientInactiveCaption;
            minStockNum.DecimalPlaces = 2;
            minStockNum.Location = new Point(165, 304);
            minStockNum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            minStockNum.Name = "minStockNum";
            minStockNum.Size = new Size(120, 23);
            minStockNum.TabIndex = 17;
            // 
            // costoNum
            // 
            costoNum.BackColor = SystemColors.GradientInactiveCaption;
            costoNum.DecimalPlaces = 2;
            costoNum.Location = new Point(165, 347);
            costoNum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            costoNum.Name = "costoNum";
            costoNum.Size = new Size(120, 23);
            costoNum.TabIndex = 18;
            // 
            // margenNum
            // 
            margenNum.BackColor = SystemColors.GradientInactiveCaption;
            margenNum.DecimalPlaces = 2;
            margenNum.Location = new Point(165, 394);
            margenNum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            margenNum.Name = "margenNum";
            margenNum.Size = new Size(120, 23);
            margenNum.TabIndex = 19;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.GradientInactiveCaption;
            txtId.Location = new Point(391, 14);
            txtId.Name = "txtId";
            txtId.Size = new Size(102, 23);
            txtId.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(254, 16);
            label9.Name = "label9";
            label9.Size = new Size(94, 21);
            label9.TabIndex = 35;
            label9.Text = "Numero ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(28, 257);
            label10.Name = "label10";
            label10.Size = new Size(65, 21);
            label10.TabIndex = 38;
            label10.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.GradientInactiveCaption;
            txtCodigo.Location = new Point(165, 255);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(328, 23);
            txtCodigo.TabIndex = 37;
            // 
            // CargarArticuloForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(txtCodigo);
            Controls.Add(txtId);
            Controls.Add(label9);
            Controls.Add(margenNum);
            Controls.Add(costoNum);
            Controls.Add(minStockNum);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTipo);
            Controls.Add(txtProveedor);
            Controls.Add(txtMarca);
            Controls.Add(txtNombre);
            Name = "CargarArticuloForm";
            Text = "CargarArticuloForm";
            ((System.ComponentModel.ISupportInitialize)minStockNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)costoNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)margenNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtMarca;
        private TextBox txtProveedor;
        private TextBox txtTipo;
        private Label label1;
        private Label label8;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private NumericUpDown minStockNum;
        private NumericUpDown costoNum;
        private NumericUpDown margenNum;
        private TextBox txtId;
        private Label label9;
        private Label label10;
        private TextBox txtCodigo;
    }
}