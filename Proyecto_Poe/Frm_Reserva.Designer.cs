
namespace Proyecto_Poe
{
    partial class Frm_Reserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reserva));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreReserva = new System.Windows.Forms.TextBox();
            this.cmbNumPersonas = new System.Windows.Forms.ComboBox();
            this.rdButtonVentana = new System.Windows.Forms.RadioButton();
            this.rdButtonCentro = new System.Windows.Forms.RadioButton();
            this.rdButtonPuerta = new System.Windows.Forms.RadioButton();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dateReserva = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSugerencias = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha y hora de Reservación ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de Personas ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ubicación de Mesa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(227, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre de quien Reserva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(220, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(188, 41);
            this.label6.TabIndex = 5;
            this.label6.Text = "Reservación";
            // 
            // txtNombreReserva
            // 
            this.txtNombreReserva.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreReserva.Location = new System.Drawing.Point(319, 119);
            this.txtNombreReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreReserva.Name = "txtNombreReserva";
            this.txtNombreReserva.Size = new System.Drawing.Size(285, 26);
            this.txtNombreReserva.TabIndex = 6;
            this.txtNombreReserva.TextChanged += new System.EventHandler(this.txtNombreReserva_TextChanged);
            this.txtNombreReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreReserva_KeyPress);
            // 
            // cmbNumPersonas
            // 
            this.cmbNumPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumPersonas.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumPersonas.FormattingEnabled = true;
            this.cmbNumPersonas.Items.AddRange(new object[] {
            "1 ",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbNumPersonas.Location = new System.Drawing.Point(319, 224);
            this.cmbNumPersonas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNumPersonas.Name = "cmbNumPersonas";
            this.cmbNumPersonas.Size = new System.Drawing.Size(69, 26);
            this.cmbNumPersonas.TabIndex = 9;
            // 
            // rdButtonVentana
            // 
            this.rdButtonVentana.AutoSize = true;
            this.rdButtonVentana.BackColor = System.Drawing.Color.Transparent;
            this.rdButtonVentana.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButtonVentana.ForeColor = System.Drawing.Color.White;
            this.rdButtonVentana.Location = new System.Drawing.Point(5, 12);
            this.rdButtonVentana.Margin = new System.Windows.Forms.Padding(4);
            this.rdButtonVentana.Name = "rdButtonVentana";
            this.rdButtonVentana.Size = new System.Drawing.Size(156, 25);
            this.rdButtonVentana.TabIndex = 10;
            this.rdButtonVentana.TabStop = true;
            this.rdButtonVentana.Text = "Vista a la Ventana";
            this.rdButtonVentana.UseVisualStyleBackColor = false;
            // 
            // rdButtonCentro
            // 
            this.rdButtonCentro.AutoSize = true;
            this.rdButtonCentro.BackColor = System.Drawing.Color.Transparent;
            this.rdButtonCentro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButtonCentro.ForeColor = System.Drawing.Color.White;
            this.rdButtonCentro.Location = new System.Drawing.Point(5, 38);
            this.rdButtonCentro.Margin = new System.Windows.Forms.Padding(4);
            this.rdButtonCentro.Name = "rdButtonCentro";
            this.rdButtonCentro.Size = new System.Drawing.Size(196, 25);
            this.rdButtonCentro.TabIndex = 11;
            this.rdButtonCentro.TabStop = true;
            this.rdButtonCentro.Text = "Centro del Restaurante";
            this.rdButtonCentro.UseVisualStyleBackColor = false;
            // 
            // rdButtonPuerta
            // 
            this.rdButtonPuerta.AutoSize = true;
            this.rdButtonPuerta.BackColor = System.Drawing.Color.Transparent;
            this.rdButtonPuerta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButtonPuerta.ForeColor = System.Drawing.Color.White;
            this.rdButtonPuerta.Location = new System.Drawing.Point(5, 65);
            this.rdButtonPuerta.Margin = new System.Windows.Forms.Padding(4);
            this.rdButtonPuerta.Name = "rdButtonPuerta";
            this.rdButtonPuerta.Size = new System.Drawing.Size(159, 25);
            this.rdButtonPuerta.TabIndex = 12;
            this.rdButtonPuerta.TabStop = true;
            this.rdButtonPuerta.Text = "Cerca de la puerta";
            this.rdButtonPuerta.UseVisualStyleBackColor = false;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReservar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(68, 417);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(136, 34);
            this.btnReservar.TabIndex = 13;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(469, 417);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(136, 34);
            this.btnRegresar.TabIndex = 14;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dateReserva
            // 
            this.dateReserva.CustomFormat = "dd/MM/yyyy";
            this.dateReserva.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateReserva.Location = new System.Drawing.Point(319, 171);
            this.dateReserva.Margin = new System.Windows.Forms.Padding(4);
            this.dateReserva.MinDate = new System.DateTime(2021, 9, 15, 0, 0, 0, 0);
            this.dateReserva.Name = "dateReserva";
            this.dateReserva.Size = new System.Drawing.Size(285, 26);
            this.dateReserva.TabIndex = 15;
            this.dateReserva.Value = new System.DateTime(2021, 9, 15, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(63, 361);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(181, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sugerencia adicional";
            // 
            // txtSugerencias
            // 
            this.txtSugerencias.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSugerencias.Location = new System.Drawing.Point(319, 358);
            this.txtSugerencias.Margin = new System.Windows.Forms.Padding(4);
            this.txtSugerencias.Name = "txtSugerencias";
            this.txtSugerencias.Size = new System.Drawing.Size(285, 26);
            this.txtSugerencias.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdButtonVentana);
            this.groupBox1.Controls.Add(this.rdButtonCentro);
            this.groupBox1.Controls.Add(this.rdButtonPuerta);
            this.groupBox1.Location = new System.Drawing.Point(319, 256);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(217, 92);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // Frm_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSugerencias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateReserva);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.cmbNumPersonas);
            this.Controls.Add(this.txtNombreReserva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreReserva;
        private System.Windows.Forms.ComboBox cmbNumPersonas;
        private System.Windows.Forms.RadioButton rdButtonVentana;
        private System.Windows.Forms.RadioButton rdButtonCentro;
        private System.Windows.Forms.RadioButton rdButtonPuerta;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DateTimePicker dateReserva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSugerencias;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}