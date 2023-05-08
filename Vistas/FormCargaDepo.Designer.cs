namespace App_Stock.Vistas
{
    partial class FormCargaDepo
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            capacidadNum = new NumericUpDown();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtHorario = new TextBox();
            txtTelefono = new TextBox();
            button3 = new Button();
            txtId = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)capacidadNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(112, 8);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 0;
            label1.Text = "Cargar Deposito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 85);
            label2.Name = "label2";
            label2.Size = new Size(87, 30);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 150);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 212);
            label4.Name = "label4";
            label4.Size = new Size(85, 30);
            label4.TabIndex = 3;
            label4.Text = "Horario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 278);
            label5.Name = "label5";
            label5.Size = new Size(92, 30);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 343);
            label6.Name = "label6";
            label6.Size = new Size(109, 30);
            label6.TabIndex = 5;
            label6.Text = "Capacidad";
            // 
            // capacidadNum
            // 
            capacidadNum.BackColor = SystemColors.GradientInactiveCaption;
            capacidadNum.DecimalPlaces = 2;
            capacidadNum.Location = new Point(174, 350);
            capacidadNum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            capacidadNum.Name = "capacidadNum";
            capacidadNum.Size = new Size(120, 23);
            capacidadNum.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.GradientInactiveCaption;
            txtNombre.Location = new Point(174, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(263, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = SystemColors.GradientInactiveCaption;
            txtDireccion.Location = new Point(174, 157);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(263, 23);
            txtDireccion.TabIndex = 8;
            // 
            // txtHorario
            // 
            txtHorario.BackColor = SystemColors.GradientInactiveCaption;
            txtHorario.Location = new Point(174, 219);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(263, 23);
            txtHorario.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.GradientInactiveCaption;
            txtTelefono.Location = new Point(174, 285);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(263, 23);
            txtTelefono.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 128);
            button3.Font = new Font("Sitka Heading Semibold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(586, 390);
            button3.Name = "button3";
            button3.Size = new Size(202, 48);
            button3.TabIndex = 18;
            button3.Text = "Cargar Deposito";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.GradientInactiveCaption;
            txtId.Location = new Point(502, 10);
            txtId.Name = "txtId";
            txtId.Size = new Size(102, 23);
            txtId.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(365, 12);
            label9.Name = "label9";
            label9.Size = new Size(94, 21);
            label9.TabIndex = 37;
            label9.Text = "Numero ID";
            // 
            // FormCargaDepo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(txtTelefono);
            Controls.Add(txtHorario);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(capacidadNum);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCargaDepo";
            Text = "FormCargaDepo";
            ((System.ComponentModel.ISupportInitialize)capacidadNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown capacidadNum;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtHorario;
        private TextBox txtTelefono;
        private Button button3;
        private TextBox txtId;
        private Label label9;
    }
}