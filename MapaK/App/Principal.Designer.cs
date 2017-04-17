namespace App
{
    partial class Principal
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
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerarTabla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroVariables = new System.Windows.Forms.TextBox();
            this.btnGenerarMapa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlHorizontal = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlVertical = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvMapa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.AllowUserToResizeColumns = false;
            this.dgvTabla.AllowUserToResizeRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(26, 37);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(325, 515);
            this.dgvTabla.TabIndex = 0;
            this.dgvTabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTabla_CellClick);
            this.dgvTabla.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTabla_CellEndEdit);
            this.dgvTabla.SelectionChanged += new System.EventHandler(this.DgvTabla_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTabla);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 577);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabla de Verdad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerarTabla);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNumeroVariables);
            this.groupBox2.Location = new System.Drawing.Point(392, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 90);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnGenerarTabla
            // 
            this.btnGenerarTabla.Location = new System.Drawing.Point(204, 37);
            this.btnGenerarTabla.Name = "btnGenerarTabla";
            this.btnGenerarTabla.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarTabla.TabIndex = 2;
            this.btnGenerarTabla.Text = "Generar";
            this.btnGenerarTabla.UseVisualStyleBackColor = true;
            this.btnGenerarTabla.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Variables";
            // 
            // txtNumeroVariables
            // 
            this.txtNumeroVariables.Location = new System.Drawing.Point(141, 40);
            this.txtNumeroVariables.Name = "txtNumeroVariables";
            this.txtNumeroVariables.Size = new System.Drawing.Size(42, 20);
            this.txtNumeroVariables.TabIndex = 0;
            this.txtNumeroVariables.Text = "4";
            // 
            // btnGenerarMapa
            // 
            this.btnGenerarMapa.Location = new System.Drawing.Point(38, 608);
            this.btnGenerarMapa.Name = "btnGenerarMapa";
            this.btnGenerarMapa.Size = new System.Drawing.Size(99, 23);
            this.btnGenerarMapa.TabIndex = 3;
            this.btnGenerarMapa.Text = "Generar Mapa";
            this.btnGenerarMapa.UseVisualStyleBackColor = true;
            this.btnGenerarMapa.Click += new System.EventHandler(this.BtnGenerarMapa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnlHorizontal);
            this.groupBox3.Controls.Add(this.pnlVertical);
            this.groupBox3.Controls.Add(this.dgvMapa);
            this.groupBox3.Location = new System.Drawing.Point(392, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(805, 508);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mapa K";
            // 
            // pnlHorizontal
            // 
            this.pnlHorizontal.Location = new System.Drawing.Point(127, 28);
            this.pnlHorizontal.Name = "pnlHorizontal";
            this.pnlHorizontal.Size = new System.Drawing.Size(87, 40);
            this.pnlHorizontal.TabIndex = 4;
            // 
            // pnlVertical
            // 
            this.pnlVertical.Location = new System.Drawing.Point(5, 133);
            this.pnlVertical.Name = "pnlVertical";
            this.pnlVertical.Size = new System.Drawing.Size(78, 45);
            this.pnlVertical.TabIndex = 3;
            // 
            // dgvMapa
            // 
            this.dgvMapa.AllowUserToAddRows = false;
            this.dgvMapa.AllowUserToDeleteRows = false;
            this.dgvMapa.AllowUserToResizeColumns = false;
            this.dgvMapa.AllowUserToResizeRows = false;
            this.dgvMapa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvMapa.ColumnHeadersHeight = 35;
            this.dgvMapa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMapa.Location = new System.Drawing.Point(89, 74);
            this.dgvMapa.Name = "dgvMapa";
            this.dgvMapa.ReadOnly = true;
            this.dgvMapa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMapa.Size = new System.Drawing.Size(696, 382);
            this.dgvMapa.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 643);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGenerarMapa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.Text = "Mapa de Karnaugh";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroVariables;
        private System.Windows.Forms.Button btnGenerarTabla;
        private System.Windows.Forms.Button btnGenerarMapa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvMapa;
        private System.Windows.Forms.FlowLayoutPanel pnlVertical;
        private System.Windows.Forms.FlowLayoutPanel pnlHorizontal;
    }
}

