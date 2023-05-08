namespace App_Stock.Vistas
{
    partial class Stocks
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
            dgvStock = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            txtID = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(12, 58);
            dgvStock.Name = "dgvStock";
            dgvStock.RowTemplate.Height = 25;
            dgvStock.Size = new Size(776, 310);
            dgvStock.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 34);
            label1.TabIndex = 2;
            label1.Text = "Stock";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Sylfaen", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 388);
            button1.Name = "button1";
            button1.Size = new Size(200, 49);
            button1.TabIndex = 4;
            button1.Text = "Cargar Stock";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(256, 390);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 25;
            label2.Text = "Id Stock";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(224, 224, 224);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(311, 415);
            txtID.Name = "txtID";
            txtID.Size = new Size(129, 23);
            txtID.TabIndex = 24;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Sitka Heading Semibold", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(466, 390);
            button2.Name = "button2";
            button2.Size = new Size(147, 48);
            button2.TabIndex = 23;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Sitka Heading Semibold", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(640, 390);
            button3.Name = "button3";
            button3.Size = new Size(147, 48);
            button3.TabIndex = 22;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Stocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dgvStock);
            Name = "Stocks";
            Text = "Stocks";
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStock;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox txtID;
        private Button button2;
        private Button button3;
    }
}