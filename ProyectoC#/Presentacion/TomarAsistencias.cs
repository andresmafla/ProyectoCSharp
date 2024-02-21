using ProyectoC_.Datos;
using ProyectoC_.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoC_.Presentacion
{
    public partial class TomarAsistencias : Form
    {
        public TomarAsistencias()
        {
            InitializeComponent();
        }

        string Identificacion;
        int IdPersonal;
        int Contador;
        DateTime fechareg;

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfecha2.Text = DateTime.Now.ToShortDateString();
        }

        private void TomarAsistencias_Load(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion2_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonalIdent();
            if (Identificacion == txtIdentificacion2.Text)
            {
                BuscarAsistenciasId();
                if (Contador == 0)
                {
                    DialogResult resultado = MessageBox.Show("¿Agregar una observacion?", "Observaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        panelObservacion.Visible = true;
                        panelObservacion.Location = new Point((panel2.Location.X), (panel2.Location.Y));
                        panelObservacion.Size = new Size(panel2.Width, panel2.Height);
                        panelObservacion.BringToFront();
                        txtobservacion.Clear();
                        txtobservacion.Focus();
                    }
                    else
                    {
                        InsertarAsistencias();
                    }
                }
                else
                {
                    ConfirmarSalida();
                }
            }
        }

        private void ConfirmarSalida()
        {
            Lasistencias parametros = new Lasistencias();
            Dasistencias funcion = new Dasistencias();
            parametros.Id_personal = IdPersonal;
            parametros.Facha_salida = DateTime.Now;
            parametros.Horas = Lbase.DateDiff(Lbase.DateInterval.Hour, fechareg, DateTime.Now);
            if (funcion.ConfirmarSalida(parametros) == true)
            {
                txtAviso.Text = "SALIDA REGISTRADA";
                txtIdentificacion2.Clear();
                txtIdentificacion2.Focus();
            }
        }
        private void InsertarAsistencias()
        {
            if (string.IsNullOrEmpty(txtobservacion.Text))
            {
                txtobservacion.Text = "-";
            }
            Lasistencias parametros = new Lasistencias();
            Dasistencias funcion = new Dasistencias();
            parametros.Id_personal = IdPersonal;
            parametros.Fecha_entrada = DateTime.Now;
            parametros.Facha_salida = DateTime.Now;
            parametros.Estado = "ENTRADA";
            parametros.Horas = 0;
            parametros.Observacion = txtobservacion.Text;
            if (funcion.InsertarAsistencias(parametros) == true)
            {
                txtAviso.Text = "ENTRADA REGISTRADA";
                txtIdentificacion2.Clear();
                txtIdentificacion2.Focus();
                panelObservacion.Visible = false;
            }
        }

        private void BuscarAsistenciasId()
        {
            DataTable dt = new DataTable();
            Dasistencias funcion = new Dasistencias();
            funcion.BuscarAsistenciasId(ref dt, IdPersonal);
            Contador = dt.Rows.Count;
            if (Contador > 0)
            {
                fechareg = Convert.ToDateTime(dt.Rows[0]["Fecha_entrada"]);
            }
        }
        private void BuscarPersonalIdent()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.BuscarPersonalIdentidad(ref dt, txtIdentificacion2.Text);
            if (dt.Rows.Count > 0)
            {
                Identificacion = dt.Rows[0]["Identificacion"].ToString();
                IdPersonal = Convert.ToInt32(dt.Rows[0]["Id_personal"]);
                txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            InsertarAsistencias();
        }
    }
}
