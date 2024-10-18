namespace Jeic
{
    partial class bajasMultiplesSinCodBarras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblScan = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.Fecha_in = new System.Windows.Forms.DateTimePicker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvPiezas = new System.Windows.Forms.DataGridView();
            this.ColumnPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCvePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCveVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCvePieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiezas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::Jeic.Properties.Resources.Close_Window__2_48px;
            this.pbClose.Location = new System.Drawing.Point(985, 3);
            this.pbClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(23, 21);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 22;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(372, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 20);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "REGISTRO DE BAJAS ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(8, 6);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 18);
            this.lblUsuario.TabIndex = 23;
            this.lblUsuario.Text = "usuario";
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblScan.Location = new System.Drawing.Point(739, 126);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(240, 18);
            this.lblScan.TabIndex = 27;
            this.lblScan.Text = "Número de Pedido o Siniestro:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFecha.Location = new System.Drawing.Point(749, 246);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 18);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "Fecha:";
            // 
            // Fecha_in
            // 
            this.Fecha_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_in.Location = new System.Drawing.Point(815, 242);
            this.Fecha_in.Margin = new System.Windows.Forms.Padding(4);
            this.Fecha_in.Name = "Fecha_in";
            this.Fecha_in.Size = new System.Drawing.Size(169, 23);
            this.Fecha_in.TabIndex = 25;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(740, 148);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(245, 22);
            this.txtCodigo.TabIndex = 24;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(742, 178);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(815, 285);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Dar de Baja";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvPiezas
            // 
            this.dgvPiezas.AllowUserToAddRows = false;
            this.dgvPiezas.AllowUserToDeleteRows = false;
            this.dgvPiezas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPiezas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPiezas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvPiezas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPiezas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPiezas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPiezas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPiezas.ColumnHeadersHeight = 22;
            this.dgvPiezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPiezas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPed,
            this.ColumnSin,
            this.ColumnPieza,
            this.ColumnCliente,
            this.ColumnEstatus,
            this.ColumnCvePedido,
            this.ColumnCveVenta,
            this.ColumnCvePieza,
            this.ColumnCantidad,
            this.ColumnFechaAsig});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPiezas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPiezas.EnableHeadersVisualStyles = false;
            this.dgvPiezas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.dgvPiezas.Location = new System.Drawing.Point(11, 126);
            this.dgvPiezas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPiezas.Name = "dgvPiezas";
            this.dgvPiezas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPiezas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPiezas.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPiezas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPiezas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPiezas.Size = new System.Drawing.Size(716, 288);
            this.dgvPiezas.TabIndex = 31;
            // 
            // ColumnPed
            // 
            this.ColumnPed.HeaderText = "PEDIDO";
            this.ColumnPed.MinimumWidth = 6;
            this.ColumnPed.Name = "ColumnPed";
            this.ColumnPed.Width = 87;
            // 
            // ColumnSin
            // 
            this.ColumnSin.HeaderText = "SINIESTRO";
            this.ColumnSin.MinimumWidth = 6;
            this.ColumnSin.Name = "ColumnSin";
            this.ColumnSin.Width = 108;
            // 
            // ColumnPieza
            // 
            this.ColumnPieza.HeaderText = "PIEZA";
            this.ColumnPieza.MinimumWidth = 6;
            this.ColumnPieza.Name = "ColumnPieza";
            this.ColumnPieza.Width = 74;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.HeaderText = "CLIENTE";
            this.ColumnCliente.MinimumWidth = 6;
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.Width = 92;
            // 
            // ColumnEstatus
            // 
            this.ColumnEstatus.HeaderText = "ESTATUS ACTUAL";
            this.ColumnEstatus.MinimumWidth = 6;
            this.ColumnEstatus.Name = "ColumnEstatus";
            this.ColumnEstatus.Width = 157;
            // 
            // ColumnCvePedido
            // 
            this.ColumnCvePedido.HeaderText = "CVE PEDIDO";
            this.ColumnCvePedido.MinimumWidth = 6;
            this.ColumnCvePedido.Name = "ColumnCvePedido";
            this.ColumnCvePedido.Width = 118;
            // 
            // ColumnCveVenta
            // 
            this.ColumnCveVenta.HeaderText = "CVE VENTA";
            this.ColumnCveVenta.MinimumWidth = 6;
            this.ColumnCveVenta.Name = "ColumnCveVenta";
            this.ColumnCveVenta.Width = 112;
            // 
            // ColumnCvePieza
            // 
            this.ColumnCvePieza.HeaderText = "CVE PIEZA";
            this.ColumnCvePieza.MinimumWidth = 6;
            this.ColumnCvePieza.Name = "ColumnCvePieza";
            this.ColumnCvePieza.Width = 105;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "CANTIDAD";
            this.ColumnCantidad.MinimumWidth = 6;
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.Width = 104;
            // 
            // ColumnFechaAsig
            // 
            this.ColumnFechaAsig.HeaderText = "FECHA ASIGNACION";
            this.ColumnFechaAsig.MinimumWidth = 6;
            this.ColumnFechaAsig.Name = "ColumnFechaAsig";
            this.ColumnFechaAsig.Width = 168;
            // 
            // bajasMultiplesSinCodBarras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.dgvPiezas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblScan);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.Fecha_in);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bajasMultiplesSinCodBarras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Bajas";
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiezas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker Fecha_in;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvPiezas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCvePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCveVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCvePieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaAsig;
    }
}