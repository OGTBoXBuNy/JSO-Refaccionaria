using Refracciones;
using Refracciones.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeic
{
    public partial class bajasMultiplesSinCodBarras : Form
    {
        OperBD consulta = new OperBD();
        public bajasMultiplesSinCodBarras()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            limpiarDgv();
            
            consulta.productosBajaSinCodBarras(dgvPiezas,txtCodigo.Text.Trim());
            dgvPiezas.Columns[1].Name = "ColumnPed";
            dgvPiezas.Columns[2].Name = "ColumnSin";
            dgvPiezas.Columns[3].Name = "ColumnPieza";
            dgvPiezas.Columns[4].Name = "ColumnCliente";
            dgvPiezas.Columns[5].Name = "ColumnEstatus";
            dgvPiezas.Columns[6].Name = "ColumnCvePedido";
            dgvPiezas.Columns[7].Name = "ColumnCveVenta";
            dgvPiezas.Columns[8].Name = "ColumnCvePieza";
            dgvPiezas.Columns[9].Name = "ColumnCantidad";
            dgvPiezas.Columns[10].Name = "ColumnFechaAsig";

            dgvPiezas.Columns["ColumnCvePedido"].Visible = false;
            dgvPiezas.Columns["ColumnCveVenta"].Visible = false;
            dgvPiezas.Columns["ColumnCvePieza"].Visible = false;
            dgvPiezas.Columns["ColumnCantidad"].Visible = false;
            dgvPiezas.Columns["ColumnFechaAsig"].Visible = false;
        }

        private void limpiarDgv()
        {
            dgvPiezas.DataSource = null;
            dgvPiezas.Rows.Clear();
            dgvPiezas.Columns.Clear();
            dgvPiezas.Refresh();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            //limpiarDgv();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string realizo = lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9);
            DateTime fecha = Fecha_in.Value; 

            if (dgvPiezas.Rows.Count == 0)
            {
                MessageBOX.SHowDialog(2, "Sin datos para procesar!");
            }
            else
            {
                foreach (DataGridViewRow row in dgvPiezas.Rows)
                {

                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                    if (isSelected)
                    {
                        string cvePedido = row.Cells["ColumnPed"].Value.ToString(); //Valor de pedido de la tabla ventas
                        string cveSiniestro = row.Cells["ColumnSin"].Value.ToString();//valor de siniestro en la tabla ventas
                        int cvePedidoIdentity = int.Parse(row.Cells["ColumnCvePedido"].Value.ToString());//ID de la tabla Pedido
                        int cvePieza = int.Parse(row.Cells["ColumnCvePieza"].Value.ToString());//Valor de la columna cve_pieza en tabla Pedido
                        int cantidad = int.Parse(row.Cells["ColumnCantidad"].Value.ToString());//Cantidad a dar de baja
                        int cveVenta = int.Parse(row.Cells["ColumnCveVenta"].Value.ToString()); //valor de la cveVenta de la tabla ventas
                        DateTime fecha_asigancion = DateTime.Parse(row.Cells["ColumnFechaAsig"].Value.ToString()); //fecha de asignacion de la tabla ventas

                        consulta.registrarBajaCodigoBarras(cveSiniestro, cvePedido, cvePieza, cantidad, fecha, cveVenta, fecha_asigancion, realizo, cvePedidoIdentity);

                        string usuario = lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9);
                        string idPedido = row.Cells["ColumnPed"].Value.ToString();
                        string nombrePieza = row.Cells["ColumnPieza"].Value.ToString();
                        string descripcionLog = "El usuario: " + usuario + " registro una baja del pedido: " + idPedido + " de la pieza: " + nombrePieza + " el día: " + DateTime.Now.ToString();
                        consulta.Log(usuario, idPedido, descripcionLog, "12");
                    }
                    else
                    {
                        //MessageBOX.SHowDialog(0,row.Cells["ColumnPieza"].Value.ToString().Trim());
                    }

                   
                }
                limpiarDgv();
                txtCodigo.Text = string.Empty;
                MessageBOX.SHowDialog(3, "Datos registrados correctamente!");
            }

           
        }
    }
}
