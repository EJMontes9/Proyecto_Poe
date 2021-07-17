
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
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.DgOrder = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Plato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_PrecioTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.LaTot = new System.Windows.Forms.Label();
            this.BTAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orden";
            // 
            // TxtCod
            // 
            this.TxtCod.Location = new System.Drawing.Point(172, 86);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(100, 20);
            this.TxtCod.TabIndex = 1;
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
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(387, 86);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(100, 20);
            this.TxtAmount.TabIndex = 3;
            // 
            // DgOrder
            // 
            this.DgOrder.AllowUserToAddRows = false;
            this.DgOrder.AllowUserToDeleteRows = false;
            this.DgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.DG_Plato,
            this.DG_Cantidad,
            this.DG_PrecioUnitario,
            this.DG_PrecioTot});
            this.DgOrder.Location = new System.Drawing.Point(59, 130);
            this.DgOrder.Name = "DgOrder";
            this.DgOrder.ReadOnly = true;
            this.DgOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgOrder.Size = new System.Drawing.Size(569, 225);
            this.DgOrder.TabIndex = 5;
            this.DgOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrder_CellClick);
            // 
            // cod
            // 
            this.cod.HeaderText = "Codigo";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // DG_Plato
            // 
            this.DG_Plato.HeaderText = "Plato";
            this.DG_Plato.Name = "DG_Plato";
            this.DG_Plato.ReadOnly = true;
            // 
            // DG_Cantidad
            // 
            this.DG_Cantidad.HeaderText = "Cantidad";
            this.DG_Cantidad.Name = "DG_Cantidad";
            this.DG_Cantidad.ReadOnly = true;
            // 
            // DG_PrecioUnitario
            // 
            this.DG_PrecioUnitario.HeaderText = "Precio Unitario";
            this.DG_PrecioUnitario.Name = "DG_PrecioUnitario";
            this.DG_PrecioUnitario.ReadOnly = true;
            // 
            // DG_PrecioTot
            // 
            this.DG_PrecioTot.HeaderText = "Precio Total";
            this.DG_PrecioTot.Name = "DG_PrecioTot";
            this.DG_PrecioTot.ReadOnly = true;
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
            // LaTot
            // 
            this.LaTot.AutoSize = true;
            this.LaTot.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaTot.Location = new System.Drawing.Point(583, 390);
            this.LaTot.Name = "LaTot";
            this.LaTot.Size = new System.Drawing.Size(45, 23);
            this.LaTot.TabIndex = 8;
            this.LaTot.Text = "0.00";
            // 
            // BTAdd
            // 
            this.BTAdd.BackColor = System.Drawing.Color.Blue;
            this.BTAdd.FlatAppearance.BorderSize = 0;
            this.BTAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAdd.ForeColor = System.Drawing.Color.White;
            this.BTAdd.Location = new System.Drawing.Point(524, 81);
            this.BTAdd.Name = "BTAdd";
            this.BTAdd.Size = new System.Drawing.Size(104, 27);
            this.BTAdd.TabIndex = 9;
            this.BTAdd.Text = "Agregar";
            this.BTAdd.UseVisualStyleBackColor = false;
            this.BTAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.BtDelete);
            this.panel1.Controls.Add(this.LaTot);
            this.panel1.Controls.Add(this.BTAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DgOrder);
            this.panel1.Controls.Add(this.TxtAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtCod);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(60, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 450);
            this.panel1.TabIndex = 10;
            // 
            // BtDelete
            // 
            this.BtDelete.BackColor = System.Drawing.Color.Blue;
            this.BtDelete.FlatAppearance.BorderSize = 0;
            this.BtDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDelete.ForeColor = System.Drawing.Color.White;
            this.BtDelete.Location = new System.Drawing.Point(62, 386);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(104, 27);
            this.BtDelete.TabIndex = 10;
            this.BtDelete.Text = "Eliminar";
            this.BtDelete.UseVisualStyleBackColor = false;
            this.BtDelete.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Frm_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Order";
            this.Text = "EJM";
            ((System.ComponentModel.ISupportInitialize)(this.DgOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.DataGridView DgOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LaTot;
        private System.Windows.Forms.Button BTAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Plato;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_PrecioTot;
        private System.Windows.Forms.Button BtDelete;
    }
}