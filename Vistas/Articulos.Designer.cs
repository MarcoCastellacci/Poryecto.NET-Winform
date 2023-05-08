namespace App_Stock;

partial class Articulos
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    //private AutoScaleMode AutoScaleMode;
    //private Size ClientSize;
    //private string Text;

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
        button1 = new Button();
        dsArticulo = new DataGridView();
        label1 = new Label();
        button2 = new Button();
        button3 = new Button();
        txtID = new TextBox();
        label2 = new Label();
        ((System.ComponentModel.ISupportInitialize)dsArticulo).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(128, 255, 128);
        button1.Font = new Font("Sitka Heading Semibold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
        button1.Location = new Point(62, 393);
        button1.Name = "button1";
        button1.Size = new Size(147, 48);
        button1.TabIndex = 1;
        button1.Text = "Cargar Articulo";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // dsArticulo
        // 
        dsArticulo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dsArticulo.Location = new Point(12, 43);
        dsArticulo.Name = "dsArticulo";
        dsArticulo.RowTemplate.Height = 25;
        dsArticulo.Size = new Size(1078, 317);
        dsArticulo.TabIndex = 2;
        dsArticulo.CellContentClick += dsArticulo_CellContentClick;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Yu Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        label1.ForeColor = Color.Purple;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(226, 31);
        label1.TabIndex = 3;
        label1.Text = "Articulos en Stock";
        label1.TextAlign = ContentAlignment.TopCenter;
        // 
        // button2
        // 
        button2.BackColor = SystemColors.ActiveCaption;
        button2.Font = new Font("Sitka Heading Semibold", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        button2.Location = new Point(943, 366);
        button2.Name = "button2";
        button2.Size = new Size(147, 48);
        button2.TabIndex = 4;
        button2.Text = "Modificar";
        button2.UseVisualStyleBackColor = false;
        button2.Click += Button2_Click;
        // 
        // button3
        // 
        button3.BackColor = Color.Red;
        button3.Font = new Font("Sitka Heading Semibold", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        button3.ForeColor = SystemColors.Control;
        button3.Location = new Point(943, 419);
        button3.Name = "button3";
        button3.Size = new Size(147, 48);
        button3.TabIndex = 5;
        button3.Text = "Eliminar";
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // txtID
        // 
        txtID.BackColor = Color.FromArgb(224, 224, 224);
        txtID.BorderStyle = BorderStyle.FixedSingle;
        txtID.Location = new Point(747, 418);
        txtID.Name = "txtID";
        txtID.Size = new Size(129, 23);
        txtID.TabIndex = 6;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        label2.Location = new Point(692, 393);
        label2.Name = "label2";
        label2.Size = new Size(87, 21);
        label2.TabIndex = 7;
        label2.Text = "Id Articulo";
        // 
        // Articulos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1102, 479);
        Controls.Add(label2);
        Controls.Add(txtID);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(label1);
        Controls.Add(dsArticulo);
        Controls.Add(button1);
        Name = "Articulos";
        Text = "Articulos";
        ((System.ComponentModel.ISupportInitialize)dsArticulo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button button1;
    private DataGridView dsArticulo;
    private Label label1;
    private Button button2;
    private Button button3;
    private TextBox txtID;
    private Label label2;
}