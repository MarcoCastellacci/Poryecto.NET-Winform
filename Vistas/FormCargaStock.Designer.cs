namespace App_Stock.Vistas
{
    partial class FormCargaStock
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
            label1 = new Label();
            txtId = new TextBox();
            label9 = new Label();
            capacidadNum = new NumericUpDown();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            button3 = new Button();
            cbArticulos = new ComboBox();
            cbDepositos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)capacidadNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 1;
            label1.Text = "Cargar Stock";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.GradientInactiveCaption;
            txtId.Location = new Point(635, 11);
            txtId.Name = "txtId";
            txtId.Size = new Size(102, 23);
            txtId.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(498, 13);
            label9.Name = "label9";
            label9.Size = new Size(94, 21);
            label9.TabIndex = 39;
            label9.Text = "Numero ID";
            // 
            // capacidadNum
            // 
            capacidadNum.BackColor = SystemColors.GradientInactiveCaption;
            capacidadNum.DecimalPlaces = 2;
            capacidadNum.Location = new Point(185, 365);
            capacidadNum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            capacidadNum.Name = "capacidadNum";
            capacidadNum.Size = new Size(120, 23);
            capacidadNum.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(35, 358);
            label6.Name = "label6";
            label6.Size = new Size(97, 30);
            label6.TabIndex = 45;
            label6.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 227);
            label4.Name = "label4";
            label4.Size = new Size(87, 30);
            label4.TabIndex = 43;
            label4.Text = "Articulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 107);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 42;
            label3.Text = "Depositos";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 128);
            button3.Font = new Font("Sitka Heading Semibold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(586, 390);
            button3.Name = "button3";
            button3.Size = new Size(202, 48);
            button3.TabIndex = 51;
            button3.Text = "Cargar Stock";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // cbArticulos
            // 
            cbArticulos.FormattingEnabled = true;
            cbArticulos.Location = new Point(184, 234);
            cbArticulos.Name = "cbArticulos";
            cbArticulos.Size = new Size(274, 23);
            cbArticulos.TabIndex = 53;
            // 
            // cbDepositos
            // 
            cbDepositos.FormattingEnabled = true;
            cbDepositos.Location = new Point(185, 114);
            cbDepositos.Name = "cbDepositos";
            cbDepositos.Size = new Size(273, 23);
            cbDepositos.TabIndex = 54;
            // 
            // FormCargaStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbDepositos);
            Controls.Add(cbArticulos);
            Controls.Add(button3);
            Controls.Add(capacidadNum);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "FormCargaStock";
            Text = "FormCargaStock";
            ((System.ComponentModel.ISupportInitialize)capacidadNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label9;
        private NumericUpDown capacidadNum;
        private Label label6;
        private Label label4;
        private Label label3;
        private Button button3;
        private ComboBox cbArticulos;
        private ComboBox cbDepositos;
    }
}