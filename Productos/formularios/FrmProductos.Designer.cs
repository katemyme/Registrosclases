namespace Productos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbNoombre = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.chkIVA = new System.Windows.Forms.CheckBox();
            this.dgbRegistro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgbRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prceio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(104, 157);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNoombre
            // 
            this.tbNoombre.Location = new System.Drawing.Point(104, 6);
            this.tbNoombre.Name = "tbNoombre";
            this.tbNoombre.Size = new System.Drawing.Size(100, 22);
            this.tbNoombre.TabIndex = 4;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(104, 46);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 22);
            this.tbPrecio.TabIndex = 5;
            this.tbPrecio.TextChanged += new System.EventHandler(this.tbRegistro_TextChanged);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(104, 89);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 22);
            this.tbCodigo.TabIndex = 6;
            // 
            // chkIVA
            // 
            this.chkIVA.AutoSize = true;
            this.chkIVA.Location = new System.Drawing.Point(104, 131);
            this.chkIVA.Name = "chkIVA";
            this.chkIVA.Size = new System.Drawing.Size(95, 20);
            this.chkIVA.TabIndex = 7;
            this.chkIVA.Text = "Aplicar IVA";
            this.chkIVA.UseVisualStyleBackColor = true;
            this.chkIVA.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dgbRegistro
            // 
            this.dgbRegistro.AllowUserToAddRows = false;
            this.dgbRegistro.AllowUserToDeleteRows = false;
            this.dgbRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbRegistro.Location = new System.Drawing.Point(41, 186);
            this.dgbRegistro.Name = "dgbRegistro";
            this.dgbRegistro.ReadOnly = true;
            this.dgbRegistro.RowHeadersWidth = 51;
            this.dgbRegistro.RowTemplate.Height = 24;
            this.dgbRegistro.Size = new System.Drawing.Size(584, 306);
            this.dgbRegistro.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(796, 554);
            this.Controls.Add(this.dgbRegistro);
            this.Controls.Add(this.chkIVA);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbNoombre);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbNoombre;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.CheckBox chkIVA;
        private System.Windows.Forms.DataGridView dgbRegistro;
    }
}

