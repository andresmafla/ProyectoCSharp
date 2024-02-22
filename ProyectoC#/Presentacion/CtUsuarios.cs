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
using System.IO;
using System.Data.SqlClient;

namespace ProyectoC_.Presentacion
{
    public partial class CtUsuarios : UserControl
    {
        public CtUsuarios()
        {
            InitializeComponent();
        }

        int IdUsuario;
        private void btnagregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarPaneles();
            MostrarModulos();
        }
        private void Limpiar()
        {
            txtnombre.Clear();
            txtcontraseña.Clear();
            txtusuario.Clear();
        }

        private void HabilitarPaneles()
        {
            panelRegistro.Visible = true;
            lblanuncioicono.Visible = true;
            panelIcono.Visible = false;
            panelRegistro.Dock = DockStyle.Fill;
            panelRegistro.BringToFront();
            btnactualizar.Visible = false;
        }

        private void MostrarModulos()
        {
            Dmodulos funcion = new Dmodulos();
            DataTable dt = new DataTable();
            funcion.MostrarModulos(ref dt);
            dataListadoModulos.DataSource = dt;
            dataListadoModulos.Columns[1].Visible = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombre.Text))
            {
                if (!string.IsNullOrEmpty(txtusuario.Text))
                {
                    if (!string.IsNullOrEmpty(txtcontraseña.Text))
                    {
                        if (lblanuncioicono.Visible == false)
                        {
                            InsertarUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un Icono");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Usuario");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el Nombre");
            }
        }

        private void InsertarUsuarios()
        {
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.Nombre = txtnombre.Text;
            parametros.Login = txtusuario.Text;
            parametros.Password = txtcontraseña.Text;
            MemoryStream ms = new MemoryStream();
            icono.Image.Save(ms, icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if (funcion.InsertarUsuarios(parametros) == true)
            {
                ObtenerIdUsuarios();
                InsertarPermisos();
            }
        }

        private void InsertarPermisos()
        {
            foreach (DataGridViewRow row in dataListadoModulos.Rows)
            {
                int IdModulo = Convert.ToInt32(row.Cells["IdModulo"].Value);
                bool marcado = Convert.ToBoolean(row.Cells["Marcar"].Value);
                if (marcado == true)
                {
                    Lpermisos parametros = new Lpermisos();
                    Dpermisos funcion = new Dpermisos();
                    parametros.IdModulo = IdModulo;
                    parametros.IdUsuario = IdUsuario;
                    funcion.Insertar_Permisos(parametros);
                }
            }
            MostrarUsuarios();
            panelRegistro.Visible = false;
        }

        private void MostrarUsuarios()
        {
            DataTable dt = new DataTable();
            Dusuarios funcion = new Dusuarios();
            funcion.mostrar_Usuarios(ref dt);
            datalistadoUsuarios.DataSource = dt;
            DiseñarDtvUsuarios();
        }

        private void DiseñarDtvUsuarios()
        {
            Lbase.Diseñador(ref datalistadoUsuarios);
            Lbase.DiseñoDtvEliminar(ref datalistadoUsuarios);
            datalistadoUsuarios.Columns[2].Visible = false;
            datalistadoUsuarios.Columns[5].Visible = false;
        }
        private void ObtenerIdUsuarios()
        {
            Dusuarios funcion = new Dusuarios();
            funcion.ObtenerIdUsuario(ref IdUsuario, txtusuario.Text);
        }

        private void lblanuncioicono_Click(object sender, EventArgs e)
        {
            MostrarPanelIcono();
        }

        private void MostrarPanelIcono()
        {
            panelIcono.Visible = true;
            panelIcono.Dock = DockStyle.Fill;
            panelIcono.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox3.Image;
            ocultarPanelIconos();
        }

        private void ocultarPanelIconos()
        {
            panelIcono.Visible = false;
            lblanuncioicono.Visible = false;
            icono.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox4.Image;
            ocultarPanelIconos();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox5.Image;
            ocultarPanelIconos();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox6.Image;
            ocultarPanelIconos();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox7.Image;
            ocultarPanelIconos();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox8.Image;
            ocultarPanelIconos();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox9.Image;
            ocultarPanelIconos();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox10.Image;
            ocultarPanelIconos();
        }

        private void AgregarIconoPc_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de imagenes";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                icono.BackgroundImage = null;
                icono.Image = new Bitmap(dlg.FileName);
                ocultarPanelIconos();
            }
        }

        private void icono_Click(object sender, EventArgs e)
        {
            MostrarPanelIcono();
        }

        private void CtUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnvolver2_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ocultarPanelIconos();
        }
    }
}
