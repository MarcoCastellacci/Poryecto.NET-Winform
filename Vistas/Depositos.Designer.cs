namespace App_Stock.Vistas
{
    partial class Depositos
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
            dsDepositos = new DataGridView();
            label1 = new Label();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dsDepositos).BeginInit();
            SuspendLayout();
            // 
            // dsDepositos
            // 
            dsDepositos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsDepositos.Location = new Point(12, 63);
            dsDepositos.Name = "dsDepositos";
            dsDepositos.RowTemplate.Height = 25;
            dsDepositos.Size = new Size(776, 321);
            dsDepositos.TabIndex = 0;
            dsDepositos.CellContentClick += dsDepositos_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 34);
            label1.TabIndex = 1;
            label1.Text = "Depositos";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 128);
            button3.Font = new Font("Sitka Heading Semibold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 390);
            button3.Name = "button3";
            button3.Size = new Size(202, 48);
            button3.TabIndex = 17;
            button3.Text = "Cargar Deposito";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Sitka Heading Semibold", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(641, 390);
            button1.Name = "button1";
            button1.Size = new Size(147, 48);
            button1.TabIndex = 18;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Sitka Heading Semibold", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(467, 390);
            button2.Name = "button2";
            button2.Size = new Size(147, 48);
            button2.TabIndex = 19;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(257, 390);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 21;
            label2.Text = "Id Deposito";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(224, 224, 224);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(312, 415);
            txtID.Name = "txtID";
            txtID.Size = new Size(129, 23);
            txtID.TabIndex = 20;
            // 
            // Depositos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(dsDepositos);
            Name = "Depositos";
            Text = "Depositos";
            ((System.ComponentModel.ISupportInitialize)dsDepositos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dsDepositos;
        private Label label1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox txtID;
    }
}