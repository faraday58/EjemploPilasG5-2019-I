namespace FormMascotas
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
            this.components = new System.ComponentModel.Container();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbDueño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbEspecie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.dgvMascota = new System.Windows.Forms.DataGridView();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(131, 12);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 20);
            this.txtbNombre.TabIndex = 0;
            this.txtbNombre.TextChanged += new System.EventHandler(this.txtbNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtbDueño
            // 
            this.txtbDueño.Location = new System.Drawing.Point(131, 53);
            this.txtbDueño.Name = "txtbDueño";
            this.txtbDueño.Size = new System.Drawing.Size(100, 20);
            this.txtbDueño.TabIndex = 0;
            this.txtbDueño.TextChanged += new System.EventHandler(this.txtbNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dueño";
            // 
            // txtbEspecie
            // 
            this.txtbEspecie.Location = new System.Drawing.Point(131, 92);
            this.txtbEspecie.Name = "txtbEspecie";
            this.txtbEspecie.Size = new System.Drawing.Size(100, 20);
            this.txtbEspecie.TabIndex = 0;
            this.txtbEspecie.TextChanged += new System.EventHandler(this.txtbNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Especie";
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(326, 12);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(89, 44);
            this.btnPush.TabIndex = 2;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(326, 79);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(89, 44);
            this.btnPop.TabIndex = 2;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // dgvMascota
            // 
            this.dgvMascota.AllowUserToAddRows = false;
            this.dgvMascota.AllowUserToDeleteRows = false;
            this.dgvMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaNombre,
            this.columnaDueño,
            this.columnaEspecie});
            this.dgvMascota.Location = new System.Drawing.Point(82, 154);
            this.dgvMascota.Name = "dgvMascota";
            this.dgvMascota.ReadOnly = true;
            this.dgvMascota.Size = new System.Drawing.Size(333, 150);
            this.dgvMascota.TabIndex = 3;
            // 
            // columnaNombre
            // 
            this.columnaNombre.Frozen = true;
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            this.columnaNombre.ReadOnly = true;
            // 
            // columnaDueño
            // 
            this.columnaDueño.Frozen = true;
            this.columnaDueño.HeaderText = "Dueño";
            this.columnaDueño.Name = "columnaDueño";
            this.columnaDueño.ReadOnly = true;
            // 
            // columnaEspecie
            // 
            this.columnaEspecie.Frozen = true;
            this.columnaEspecie.HeaderText = "Especie";
            this.columnaEspecie.Name = "columnaEspecie";
            this.columnaEspecie.ReadOnly = true;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 326);
            this.Controls.Add(this.dgvMascota);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbEspecie);
            this.Controls.Add(this.txtbDueño);
            this.Controls.Add(this.txtbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbDueño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbEspecie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.DataGridView dgvMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEspecie;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}

