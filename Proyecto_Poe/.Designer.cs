
namespace Proyecto_Poe
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtSingIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BtSingIn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtCi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 350);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Sesion";
            // 
            // TxtCi
            // 
            this.TxtCi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCi.BackColor = System.Drawing.Color.LightGray;
            this.TxtCi.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCi.Location = new System.Drawing.Point(139, 129);
            this.TxtCi.MaxLength = 10;
            this.TxtCi.Name = "TxtCi";
            this.TxtCi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCi.Size = new System.Drawing.Size(274, 33);
            this.TxtCi.TabIndex = 1;
            this.TxtCi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.BackColor = System.Drawing.Color.LightGray;
            this.TxtPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(139, 205);
            this.TxtPassword.MaxLength = 15;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '•';
            this.TxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPassword.Size = new System.Drawing.Size(274, 33);
            this.TxtPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // BtSingIn
            // 
            this.BtSingIn.BackColor = System.Drawing.Color.Transparent;
            this.BtSingIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSingIn.BackgroundImage")));
            this.BtSingIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtSingIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSingIn.FlatAppearance.BorderSize = 0;
            this.BtSingIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSingIn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSingIn.ForeColor = System.Drawing.Color.Transparent;
            this.BtSingIn.Location = new System.Drawing.Point(152, 260);
            this.BtSingIn.Name = "BtSingIn";
            this.BtSingIn.Size = new System.Drawing.Size(249, 75);
            this.BtSingIn.TabIndex = 6;
            this.BtSingIn.UseMnemonic = false;
            this.BtSingIn.UseVisualStyleBackColor = false;
            this.BtSingIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(598, 351);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtSingIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCi;
    }
}

