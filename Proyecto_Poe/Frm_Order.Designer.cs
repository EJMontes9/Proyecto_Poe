
namespace Proyecto_Poe
{
    partial class Frm_Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Plato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_PrecioTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orden";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo_Comida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(387, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.DG_Plato,
            this.DG_Cantidad,
            this.DG_PrecioUnitario,
            this.DG_PrecioTot});
            this.dataGridView1.Location = new System.Drawing.Point(59, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 225);
            this.dataGridView1.TabIndex = 5;
            // 
            // N
            // 
            this.N.HeaderText = "Num";
            this.N.Name = "N";
            // 
            // DG_Plato
            // 
            this.DG_Plato.HeaderText = "Plato";
            this.DG_Plato.Name = "DG_Plato";
            // 
            // DG_Cantidad
            // 
            this.DG_Cantidad.HeaderText = "Cantidad";
            this.DG_Cantidad.Name = "DG_Cantidad";
            // 
            // DG_PrecioUnitario
            // 
            this.DG_PrecioUnitario.HeaderText = "Precio Unitario";
            this.DG_PrecioUnitario.Name = "DG_PrecioUnitario";
            // 
            // DG_PrecioTot
            // 
            this.DG_PrecioTot.HeaderText = "Precio Total";
            this.DG_PrecioTot.Name = "DG_PrecioTot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total a pagar    $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(583, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "0.00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(524, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(60, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 450);
            this.panel1.TabIndex = 10;
            // 
            // Frm_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Order";
            this.Text = "Frm_SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Plato;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_PrecioTot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}