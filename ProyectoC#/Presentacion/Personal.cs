using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoC_.Logica;
using ProyectoC_.Datos;

namespace ProyectoC_.Presentacion
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }

        int Idcargo = 0;
        int desde = 1;
        int hasta = 10;
        int contador;
        int Idpersonal;
        private int items_por_pagina = 10;
        string estado;
        int total_paginas;

        private void btnagregar_Click(object sender, EventArgs e)
        {
            LocalizarDtvCargos();
            panelCargos.Visible = false;
            panelPaginado.Visible = false;
            panelRegistros.Visible = true;
            panelRegistros.Dock = DockStyle.Fill;
            btnGuardarPersonal.Visible = true;
            btnGuardarCambiosPersonal.Visible = false;
            Limpiar();
        }

        private void LocalizarDtvCargos()
        {
            datalistadocargos.Location = new Point(txtSueldo.Location.X, txtSueldo.Location.Y);
            datalistadocargos.Size = new Size(469, 141);
            datalistadocargos.Visible = true;
            lblSueldo.Visible = false;
            panelbtnGuardarPersonal.Visible = false;
        }
        private void Limpiar()
        {
            txtNombres.Clear();
            txtIdentificacion.Clear();
            txtCargo.Clear();
            txtSueldo.Clear();
            BuscarCargos();
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombres.Text))
            {
                if (!string.IsNullOrEmpty(txtIdentificacion.Text))
                {
                    if (!string.IsNullOrEmpty(cmbPais.Text))
                    {
                        if (Idcargo > 0)
                        {
                            if (!string.IsNullOrEmpty(txtSueldo.Text))
                            {
                                InsertarPersonal();
                            }

                        }
                    }

                }

            }
        }

        private void InsertarPersonal()
        {
            Lpersonal parametro = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametro.Nombres = txtNombres.Text;
            parametro.Identificacion = txtIdentificacion.Text;
            parametro.Pais = cmbPais.Text;
            parametro.Id_cargo = Idcargo;
            parametro.SueldoPorHora = Convert.ToDouble(txtSueldo.Text);
            if (funcion.InsertarPersonal(parametro) == true)
            {
                ReiniciarPaginado();
                MostrarPersonal();
                panelRegistros.Visible = false;

            }
        }

        private void MostrarPersonal()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.MostrarPersonal(ref dt, desde, hasta);
            datalistadoPersonal.DataSource = dt;
            DiseñarDtvPersonal();
        }

        private void ReiniciarPaginado()
        {
            desde = 1;
            hasta = 10;
            Contar();
            if (contador > hasta)
            {
                btnPagsig.Visible = true;
                btnPagatra.Visible = false;
                btnUltimapag.Visible = true;
                btnPrimerapag.Visible = true;
            }
            else
            {
                btnPagsig.Visible = false;
                btnPagatra.Visible = false;
                btnUltimapag.Visible = false;
                btnPrimerapag.Visible = false;
            }
            Paginar();
        }
        private void DiseñarDtvPersonal()
        {
            Lbase.Diseñador(ref datalistadoPersonal);
            Lbase.DiseñoDtvEliminar(ref datalistadoPersonal);
            panelPaginado.Visible = true;
            datalistadoPersonal.Columns[2].Visible = false;
            datalistadoPersonal.Columns[7].Visible = false;
        }

        private void InsertarCargo()
        {
            if (!string.IsNullOrEmpty(txtcargo2.Text))
            {
                if (!string.IsNullOrEmpty(txtSueldo2.Text))
                {
                    Lcargos parametros = new Lcargos();
                    Dcargos funcion = new Dcargos();
                    parametros.Cargo = txtcargo2.Text;
                    parametros.SueldoPorHora = Convert.ToDouble(txtSueldo2.Text);
                    if (funcion.InsertarCargo(parametros) == true)
                    {
                        txtCargo.Clear();
                        BuscarCargos();
                        panelCargos.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Agrege el sueldo", "Falta el sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Agrege el cargo", "Falta el cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BuscarCargos()
        {
            DataTable dt = new DataTable();
            Dcargos funcion = new Dcargos();
            funcion.BuscarCargo(ref dt, txtCargo.Text);
            datalistadocargos.DataSource = dt;
            Lbase.Diseñador(ref datalistadocargos);
            datalistadocargos.Columns[1].Visible = false;
            datalistadocargos.Columns[3].Visible = false;
            datalistadocargos.Visible = true;
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            BuscarCargos();
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            panelCargos.Visible = true;
            panelCargos.Dock = DockStyle.Fill;
            panelCargos.BringToFront();
            btnguardarc.Visible = true;
            btnguardarcambiosc.Visible = false;
            txtcargo2.Clear();
            txtSueldo2.Clear();
        }

        private void btnguardarc_Click(object sender, EventArgs e)
        {
            InsertarCargo();
        }

        private void txtSueldo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lbase.Decimales(txtSueldo2, e);
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lbase.Decimales(txtSueldo, e);
        }

        private void datalistadocargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistadocargos.Columns["EditarC"].Index)
            {
                ObtenerCargosEditar();
            }
            if (e.ColumnIndex == datalistadocargos.Columns["Cargo"].Index)
            {
                ObtenerDatosCargos();
            }
        }

        private void ObtenerDatosCargos()
        {
            Idcargo = Convert.ToInt32(datalistadocargos.SelectedCells[1].Value);
            txtCargo.Text = datalistadocargos.SelectedCells[2].Value.ToString();
            txtSueldo.Text = datalistadocargos.SelectedCells[3].Value.ToString();
            datalistadocargos.Visible = false;
            panelbtnGuardarPersonal.Visible = true;
            lblSueldo.Visible = true;
        }
        private void ObtenerCargosEditar()
        {
            Idcargo = Convert.ToInt32(datalistadocargos.SelectedCells[1].Value);
            txtcargo2.Text = datalistadocargos.SelectedCells[2].Value.ToString();
            txtSueldo2.Text = datalistadocargos.SelectedCells[3].Value.ToString();
            btnguardarc.Visible = false;
            btnguardarcambiosc.Visible = true;
            txtcargo2.Focus();
            txtcargo2.SelectAll();
            panelCargos.Visible = true;
            panelCargos.Dock = DockStyle.Fill;
            panelCargos.BringToFront();
        }

        private void btnVolverCargos_Click(object sender, EventArgs e)
        {
            panelCargos.Visible = false;
        }

        private void btnVolverPersonal_Click(object sender, EventArgs e)
        {
            panelRegistros.Visible = false;
            panelPaginado.Visible = true;
        }

        private void btnguardarcambiosc_Click(object sender, EventArgs e)
        {
            EditarCargos();
        }

        private void EditarCargos()
        {
            Lcargos parametros = new Lcargos();
            Dcargos funcion = new Dcargos();
            parametros.Id_cargo = Idcargo;
            parametros.Cargo = txtcargo2.Text;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldo2.Text);
            if (funcion.EditarCargo(parametros) == true)
            {
                txtCargo.Clear();
                BuscarCargos();
                panelCargos.Visible = false;
            }
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();

        }

        private void datalistadoPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistadoPersonal.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("Solo se cambiara el estado para que no pueda acceder, Desea continuar?", "Eliminado registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    EliminarPersonal();
                }

            }
            if (e.ColumnIndex == this.datalistadoPersonal.Columns["Editar"].Index)
            {
                ObtenerDatos();
            }
        }
        private void EliminarPersonal()
        {
            Idpersonal = Convert.ToInt32(datalistadoPersonal.SelectedCells[2].Value);
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Id_personal = Idpersonal;
            if (funcion.EliminarPersonal(parametros) == true)
            {
                MostrarPersonal();
            }
        }

        private void ObtenerDatos()
        {
            Idpersonal = Convert.ToInt32(datalistadoPersonal.SelectedCells[2].Value);
            estado = datalistadoPersonal.SelectedCells[8].Value.ToString();
            if (estado == "Eliminado")
            {
                RestaurarPersonal();
            }
            else
            {
                LocalizarDtvCargos();
                txtNombres.Text = datalistadoPersonal.SelectedCells[3].Value.ToString();
                txtIdentificacion.Text = datalistadoPersonal.SelectedCells[4].Value.ToString();
                cmbPais.Text = datalistadoPersonal.SelectedCells[10].Value.ToString();
                txtCargo.Text = datalistadoPersonal.SelectedCells[6].Value.ToString();
                Idcargo = Convert.ToInt32(datalistadoPersonal.SelectedCells[7].Value);
                txtSueldo.Text = datalistadoPersonal.SelectedCells[5].Value.ToString();
                panelPaginado.Visible = false;
                panelRegistros.Visible = true;
                panelRegistros.Dock = DockStyle.Fill;
                datalistadocargos.Visible = false;
                lblSueldo.Visible = true;
                panelbtnGuardarPersonal.Visible = true;
                btnGuardarPersonal.Visible = false;
                btnGuardarCambiosPersonal.Visible = true;
                panelCargos.Visible = false;
            }
        }

        private void RestaurarPersonal()
        {
            DialogResult result = MessageBox.Show("Este personal se elimino, ¿Desea volver a habilitar?", "Restauracion de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                HabilitarPersonal();
            }
        }

        private void HabilitarPersonal()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Id_personal = Idpersonal;
            if (funcion.RestaurarPersonal(parametros) == true)
            {
                MostrarPersonal();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DiseñarDtvPersonal();
            timer1.Stop();
        }

        private void btnGuardarCambiosPersonal_Click(object sender, EventArgs e)
        {
            EditarPersonal();
        }

        private void EditarPersonal()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Id_personal = Idpersonal;
            parametros.Nombres = txtNombres.Text;
            parametros.Identificacion = txtIdentificacion.Text;
            parametros.Pais = cmbPais.Text;
            parametros.Id_cargo = Idcargo;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldo.Text);

            if (funcion.EditarPersonal(parametros) == true)
            {
                MostrarPersonal();
                panelRegistros.Visible = false;
            }
        }

        private void btnPagsig_Click(object sender, EventArgs e)
        {
            desde += 10;
            hasta += 10;
            MostrarPersonal();
            Contar();
            if (contador > hasta)
            {
                btnPagsig.Visible = true;
                btnPagatra.Visible = true;
            }
            else
            {
                btnPagsig.Visible = false;
                btnPagatra.Visible = true;
            }
            Paginar();

        }

        private void Contar()
        {
            Dpersonal funcion = new Dpersonal();
            funcion.ContarPersonal(ref contador);
        }

        private void Paginar()
        {
            try
            {
                lblpagina.Text = (hasta / items_por_pagina).ToString();
                lbltotalpag.Text = Math.Ceiling(Convert.ToSingle(contador) / items_por_pagina).ToString();
                total_paginas = Convert.ToInt32(lbltotalpag.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnPagatra_Click(object sender, EventArgs e)
        {
            desde -= 10;
            hasta -= 10;
            MostrarPersonal();
            Contar();
            if (contador > hasta)
            {
                btnPagsig.Visible = true;
                btnPagatra.Visible = true;
            }
            else
            {
                btnPagsig.Visible = false;
                btnPagatra.Visible = true;

            }
            if (desde == 1)
            {
                ReiniciarPaginado();
            }
            Paginar();
        }

        private void btnUltimapag_Click(object sender, EventArgs e)
        {
            hasta = total_paginas * items_por_pagina;
            desde = hasta - 9;
            MostrarPersonal();
            Contar();
            if (contador > hasta)
            {
                btnPagsig.Visible = true;
                btnPagatra.Visible = true;
            }
            else
            {
                btnPagsig.Visible = false;
                btnPagatra.Visible = true;

            }
            Paginar();

        }

        private void btnPrimerapag_Click(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonal();
        }
        private void BuscarPersonal()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.BuscarPersonal(ref dt, desde, hasta, txtBuscador.Text);
            datalistadoPersonal.DataSource = dt;
            DiseñarDtvPersonal();
        }


        private void btnMosTodos_Click(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
        }
    }
}
