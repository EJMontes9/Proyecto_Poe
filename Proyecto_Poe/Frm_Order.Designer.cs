
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Order));
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.TxtTable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtOrder = new System.Windows.Forms.Button();
            this.BtDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(375, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orden";
            // 
            // TxtCod
            // 
            this.TxtCod.Location = new System.Drawing.Point(473, 74);
            this.TxtCod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCod.MaxLength = 3;
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(64, 22);
            this.TxtCod.TabIndex = 1;
            this.TxtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCod_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(323, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo_Comida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(547, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(640, 74);
            this.TxtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtAmount.MaxLength = 3;
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(45, 22);
            this.TxtAmount.TabIndex = 3;
            this.TxtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAmount_KeyPress);
            // 
            // DgOrder
            // 
            this.DgOrder.AllowUserToAddRows = false;
            this.DgOrder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.DG_Plato,
            this.DG_Cantidad,
            this.DG_PrecioUnitario,
            this.DG_PrecioTot});
            this.DgOrder.Location = new System.Drawing.Point(43, 121);
            this.DgOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgOrder.Name = "DgOrder";
            this.DgOrder.ReadOnly = true;
            this.DgOrder.RowHeadersWidth = 51;
            this.DgOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgOrder.Size = new System.Drawing.Size(765, 277);
            this.DgOrder.TabIndex = 5;
            this.DgOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrder_CellClick);
            this.DgOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrder_CellContentClick);
            // 
            // cod
            // 
            this.cod.HeaderText = "Codigo";
            this.cod.MinimumWidth = 6;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Width = 125;
            // 
            // DG_Plato
            // 
            this.DG_Plato.HeaderText = "Plato";
            this.DG_Plato.MinimumWidth = 6;
            this.DG_Plato.Name = "DG_Plato";
            this.DG_Plato.ReadOnly = true;
            this.DG_Plato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Plato.Width = 131;
            // 
            // DG_Cantidad
            // 
            this.DG_Cantidad.HeaderText = "Cantidad";
            this.DG_Cantidad.MinimumWidth = 6;
            this.DG_Cantidad.Name = "DG_Cantidad";
            this.DG_Cantidad.ReadOnly = true;
            this.DG_Cantidad.Width = 125;
            // 
            // DG_PrecioUnitario
            // 
            this.DG_PrecioUnitario.HeaderText = "Precio Unitario";
            this.DG_PrecioUnitario.MinimumWidth = 6;
            this.DG_PrecioUnitario.Name = "DG_PrecioUnitario";
            this.DG_PrecioUnitario.ReadOnly = true;
            this.DG_PrecioUnitario.Width = 125;
            // 
            // DG_PrecioTot
            // 
            this.DG_PrecioTot.HeaderText = "Precio Total";
            this.DG_PrecioTot.MinimumWidth = 6;
            this.DG_PrecioTot.Name = "DG_PrecioTot";
            this.DG_PrecioTot.ReadOnly = true;
            this.DG_PrecioTot.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(541, 427);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total a pagar    $";
            // 
            // LaTot
            // 
            this.LaTot.AutoSize = true;
            this.LaTot.BackColor = System.Drawing.Color.Transparent;
            this.LaTot.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaTot.ForeColor = System.Drawing.Color.White;
            this.LaTot.Location = new System.Drawing.Point(737, 426);
            this.LaTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LaTot.Name = "LaTot";
            this.LaTot.Size = new System.Drawing.Size(64, 33);
            this.LaTot.TabIndex = 8;
            this.LaTot.Text = "0.00";
            // 
            // BTAdd
            // 
            this.BTAdd.BackColor = System.Drawing.Color.Goldenrod;
            this.BTAdd.FlatAppearance.BorderSize = 0;
            this.BTAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAdd.ForeColor = System.Drawing.Color.Black;
            this.BTAdd.Location = new System.Drawing.Point(339, 423);
            this.BTAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTAdd.Name = "BTAdd";
            this.BTAdd.Size = new System.Drawing.Size(139, 33);
            this.BTAdd.TabIndex = 9;
            this.BTAdd.Text = "Agregar";
            this.BTAdd.UseVisualStyleBackColor = false;
            this.BTAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.TxtTable);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtCi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtOrder);
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
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 554);
            this.panel1.TabIndex = 10;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.White;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(367, 492);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(159, 37);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // TxtTable
            // 
            this.TxtTable.Location = new System.Drawing.Point(759, 75);
            this.TxtTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTable.MaxLength = 2;
            this.TxtTable.Name = "TxtTable";
            this.TxtTable.Size = new System.Drawing.Size(45, 22);
            this.TxtTable.TabIndex = 14;
            this.TxtTable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTable_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(695, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mesa";
            // 
            // TxtCi
            // 
            this.TxtCi.Location = new System.Drawing.Point(137, 73);
            this.TxtCi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCi.MaxLength = 10;
            this.TxtCi.Name = "TxtCi";
            this.TxtCi.Size = new System.Drawing.Size(175, 22);
            this.TxtCi.TabIndex = 12;
            this.TxtCi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "CI Cliente";
            // 
            // BtOrder
            // 
            this.BtOrder.BackColor = System.Drawing.Color.Goldenrod;
            this.BtOrder.FlatAppearance.BorderSize = 0;
            this.BtOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtOrder.ForeColor = System.Drawing.Color.Black;
            this.BtOrder.Location = new System.Drawing.Point(192, 423);
            this.BtOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtOrder.Name = "BtOrder";
            this.BtOrder.Size = new System.Drawing.Size(139, 33);
            this.BtOrder.TabIndex = 11;
            this.BtOrder.Text = "Ordenar";
            this.BtOrder.UseVisualStyleBackColor = false;
            this.BtOrder.Click += new System.EventHandler(this.BtOrder_Click);
            // 
            // BtDelete
            // 
            this.BtDelete.BackColor = System.Drawing.Color.IndianRed;
            this.BtDelete.FlatAppearance.BorderSize = 0;
            this.BtDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDelete.ForeColor = System.Drawing.Color.Black;
            this.BtDelete.Location = new System.Drawing.Point(45, 423);
            this.BtDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(139, 33);
            this.BtDelete.TabIndex = 10;
            this.BtDelete.Text = "Eliminar";
            this.BtDelete.UseVisualStyleBackColor = false;
            this.BtDelete.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Frm_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(844, 554);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de comida";
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
        private System.Windows.Forms.Button BtDelete;
        private System.Windows.Forms.Button BtOrder;
        private System.Windows.Forms.TextBox TxtCi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Plato;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_PrecioTot;
    }
}