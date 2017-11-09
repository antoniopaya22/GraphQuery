namespace GraphQuery
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbQuery = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.lbSubirArchivo = new System.Windows.Forms.Label();
            this.btSubirArchivo = new System.Windows.Forms.Button();
            this.tablaGrafo = new System.Windows.Forms.DataGridView();
            this.txtDescNodo = new System.Windows.Forms.TextBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbGuardarArchivo = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGrafo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Kozuka Gothic Pr6N H", 38.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lbTitulo.Location = new System.Drawing.Point(266, 49);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(333, 95);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "GraphQuery";
            // 
            // lbQuery
            // 
            this.lbQuery.AutoSize = true;
            this.lbQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuery.Location = new System.Drawing.Point(12, 322);
            this.lbQuery.Name = "lbQuery";
            this.lbQuery.Size = new System.Drawing.Size(97, 20);
            this.lbQuery.TabIndex = 2;
            this.lbQuery.Text = "Buscar por:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(126, 324);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(159, 21);
            this.cbTipo.TabIndex = 3;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(302, 325);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(249, 20);
            this.txtQuery.TabIndex = 4;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(558, 320);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(155, 29);
            this.btBuscar.TabIndex = 5;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.BuscarNodo);
            // 
            // lbSubirArchivo
            // 
            this.lbSubirArchivo.AutoSize = true;
            this.lbSubirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubirArchivo.Location = new System.Drawing.Point(84, 204);
            this.lbSubirArchivo.Name = "lbSubirArchivo";
            this.lbSubirArchivo.Size = new System.Drawing.Size(201, 20);
            this.lbSubirArchivo.TabIndex = 6;
            this.lbSubirArchivo.Text = "Subir archivo GRAPHML:";
            // 
            // btSubirArchivo
            // 
            this.btSubirArchivo.Location = new System.Drawing.Point(302, 201);
            this.btSubirArchivo.Name = "btSubirArchivo";
            this.btSubirArchivo.Size = new System.Drawing.Size(249, 29);
            this.btSubirArchivo.TabIndex = 7;
            this.btSubirArchivo.Text = "Buscar GRAPHML ...";
            this.btSubirArchivo.UseVisualStyleBackColor = true;
            this.btSubirArchivo.Click += new System.EventHandler(this.SubirFichero);
            // 
            // tablaGrafo
            // 
            this.tablaGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaGrafo.Location = new System.Drawing.Point(12, 359);
            this.tablaGrafo.Name = "tablaGrafo";
            this.tablaGrafo.Size = new System.Drawing.Size(335, 182);
            this.tablaGrafo.TabIndex = 8;
            this.tablaGrafo.SelectionChanged += new System.EventHandler(this.ImprimirNodo);
            // 
            // txtDescNodo
            // 
            this.txtDescNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescNodo.ForeColor = System.Drawing.Color.Maroon;
            this.txtDescNodo.Location = new System.Drawing.Point(365, 359);
            this.txtDescNodo.Multiline = true;
            this.txtDescNodo.Name = "txtDescNodo";
            this.txtDescNodo.ReadOnly = true;
            this.txtDescNodo.Size = new System.Drawing.Size(348, 182);
            this.txtDescNodo.TabIndex = 9;
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Location = new System.Drawing.Point(519, 9);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(203, 13);
            this.lbAutor.TabIndex = 10;
            this.lbAutor.Text = "Autor: Antonio Paya Gonzalez UO251065";
            // 
            // lbGuardarArchivo
            // 
            this.lbGuardarArchivo.AutoSize = true;
            this.lbGuardarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuardarArchivo.Location = new System.Drawing.Point(111, 258);
            this.lbGuardarArchivo.Name = "lbGuardarArchivo";
            this.lbGuardarArchivo.Size = new System.Drawing.Size(174, 20);
            this.lbGuardarArchivo.TabIndex = 11;
            this.lbGuardarArchivo.Text = "Guardar archivo XML:";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(302, 255);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(249, 29);
            this.btGuardar.TabIndex = 12;
            this.btGuardar.Text = "Guardar XML";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.Guardar);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 134);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(725, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.lbGuardarArchivo);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.txtDescNodo);
            this.Controls.Add(this.tablaGrafo);
            this.Controls.Add(this.btSubirArchivo);
            this.Controls.Add(this.lbSubirArchivo);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lbQuery);
            this.Controls.Add(this.lbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GraphQuery";
            ((System.ComponentModel.ISupportInitialize)(this.tablaGrafo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbQuery;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label lbSubirArchivo;
        private System.Windows.Forms.Button btSubirArchivo;
        private System.Windows.Forms.DataGridView tablaGrafo;
        private System.Windows.Forms.TextBox txtDescNodo;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbGuardarArchivo;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

