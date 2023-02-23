using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;
namespace CapaPresentacion
{
    public partial class FrmModulo : Form
    {        
        /// <summary>
        ///  Definimos objetos a utilizar
        /// </summary>
        #region Objetos
        private CL_EMPRESA clEmpresa = new CL_EMPRESA();
        private bool ModoConsulta = false;
        #endregion



        public FrmModulo()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Evento Boton Nuevo
        /// </summary>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///  Llamamos al metodo LimpiaCampos();
            /// </summary>
            LimpiaCampos();
        }

        /// <summary>
        ///  Evento Boton Grabar
        /// </summary>
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///  Llamamos al metodo Grabar();
            /// </summary>
            Grabar();
        }
        /// <summary>
        ///  Evento Boton AgregarDireccion
        /// </summary>
        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {        /// <summary>
                 ///  Llamamos al metodo VisualizaModalDireccion();
                 /// </summary>
            VisualizaModalDireccion();
        }
        /// <summary>
        ///  Evento Boton EliminarDireccion
        /// </summary>
        private void btnEliminaDireccion_Click(object sender, EventArgs e)
        { 
            /// <summary>
           ///  Llamamos al metodo EliminaDireccion();
          /// </summary>
            EliminaDireccion();
        }

        /// <summary>
        ///  Evento Boton Consultar
        /// </summary>
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///  Llamamos al metodo HabilitaModoConsulta();
            /// </summary>
            HabilitaModoConsulta();
        }

        /// <summary>
        ///  Evento Boton EliminarEmpresa
        /// </summary>
        private void btnEliminaEmpresa_Click(object sender, EventArgs e)
        {

            /// <summary>
            ///  Llamamos al metodo EliminarEmpresa() que recibe como parametro el codigo;
            /// </summary>
            if(MessageBox.Show("Esta Seguro de Eliminar Empresa", "AVISO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                EliminarEmpresa(txtCodigo.Text);
            }


            
        }
        /// <summary>
        ///  Evento txt keywown
        /// </summary>
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            /// <summary>
            ///  evento que se lanza cuando el usuario apreta enter;
            /// </summary>
            if (e.KeyCode == Keys.Enter)
            {
                /// <summary>
                ///  Llamamos al metodo Consulta() que recibe como parametro el codigo;
                /// </summary>
                Consulta(txtCodigo.Text);
            }
        }
        /// <summary>
        ///  Evento boton Salir
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///  cierra el formulario principal
            /// </summary>
            this.Close();
        }
        /// <summary>
        ///  Evento txt keypress
        /// </summary>
        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {       
            /// <summary>
            ///  obtiene el código ASCII del carácter presionado
            /// </summary>
            int codigoTecla = (int)e.KeyChar;
            /// <summary>
            ///  Permite letras (mayúsculas y minúsculas) y números
            /// </summary>
            if ((codigoTecla >= 65 && codigoTecla <= 90) || (codigoTecla >= 97 && codigoTecla <= 122) || (codigoTecla >= 48 && codigoTecla <= 57))
            {
                e.Handled = false;
            }
            /// <summary>
            /// Permite la tecla de borrar (backspace) y la de borrar hacia delante (delete)
            /// </summary>
            else if (codigoTecla == 8 || codigoTecla == 127)
            {
                e.Handled = false;
            }
            else
            {
                /// <summary>
                /// Bloquea la tecla selecciona si no cumple las condiciones
                /// </summary>
                e.Handled = true;
            }
        }
        /// <summary>
        ///  Evento txt keypress
        /// </summary>
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// <summary>
            ///  obtiene el código ASCII del carácter presionado
            /// </summary>
            int codigoTecla = (int)e.KeyChar;
            /// <summary>
            ///  Permite números
            /// </summary>
            if (codigoTecla >= 48 && codigoTecla <= 57)
            {
                e.Handled = false; // Permitir la tecla presionada
            }
            /// <summary>
            ///  Permite la tecla de borrar (backspace) y la de borrar hacia delante (delete)
            /// </summary>
            else if (codigoTecla == 8 || codigoTecla == 127)
            {
                e.Handled = false; 
            }
            else
            {
                /// <summary>
                /// Bloquea la tecla selecciona si no cumple las condiciones
                /// </summary>
                e.Handled = true; 
            }
        }

        /// <summary>
        ///  Evento txt keypress
        /// </summary>
        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// <summary>
            ///  obtiene el código ASCII del carácter presionado
            /// </summary>
            int codigoTecla = (int)e.KeyChar;
            /// <summary>
            ///  Permitir letras (mayúsculas y minúsculas), números y comillas simples
            /// </summary>
            if ((codigoTecla >= 65 && codigoTecla <= 90) || (codigoTecla >= 97 && codigoTecla <= 122) || (codigoTecla >= 48 && codigoTecla <= 57) || codigoTecla == 39)
            {
                e.Handled = false; 
            }
            /// <summary>
            /// Permite  la tecla de borrar (backspace) y la de borrar hacia delante (delete)
            /// </summary>
            else if (codigoTecla == 8 || codigoTecla == 127)
            {
                e.Handled = false;
            }
            /// <summary>
            /// Permite espacios en blanco
            /// </summary>
            else if (codigoTecla == 32)
            {
                e.Handled = false; 
            }
            else
            {
                /// <summary>
                /// Bloquea la tecla selecciona si no cumple las condiciones
                /// </summary>
                e.Handled = true; 
            }
        }

        /// <summary>
        /// Region que contiene los metodos utilizados
        /// </summary>
        #region Métodos

        /// <summary>
        /// Metodo VisualizaModalDireccion
        /// </summary>
        public void VisualizaModalDireccion()
        {
            /// <summary>
            /// valida si tiene un codigo asignado
            /// </summary>
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("El Campo Codigo se encuentra Vacio","AVISO");
            }
            else
            {
                /// <summary>
                /// Definimos el formulario FrmDireccion como dialog
                /// </summary>
                FrmDireccion modal = new FrmDireccion();
                modal.FormBorderStyle = FormBorderStyle.FixedDialog;
                modal.StartPosition = FormStartPosition.CenterParent;
                /// <summary>
                /// Esperamos como resultado dialog.ok
                /// </summary>
                if (modal.ShowDialog(this) == DialogResult.OK)
                {
                    /// <summary>
                    /// Llamamos al metodo AgregaFila() que contiene como parametro la direccion digitada por el usuario
                    /// </summary>
                    AgregaFila(modal.resultado);
                }
            }

        }
        /// <summary>
        /// Metodo EliminarEmpresa
        /// </summary>
        public void EliminarEmpresa(string codigo)
        {
            try
            {
                /// <summary>
                /// Validamos que el codigo tenga 6 digitos
                /// </summary>
                if (codigo.Length < 6)
                {
                    MessageBox.Show("El Codigo Permite como maximo 6 caracteres","AVISO");
                }
                else
                {
                    /// <summary>
                    /// Elimina la empresa segun el codigo 
                    /// </summary>
                    clEmpresa.ELIMINAR(codigo);
                    /// <summary>
                    /// Visualiza mensaje de exito 
                    /// </summary>
                    MessageBox.Show("Empresa Eliminada", "AVISO");
                    /// <summary>
                    /// Limpia los campos para un nuevo registro
                    /// </summary>
                    LimpiaCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO");

            }

        }
        /// <summary>
        /// Metodo HabilitaModoConsulta
        /// </summary>
        public void HabilitaModoConsulta()
        {
            /// <summary>
            /// Quita al txt codigo el modo lectura y activa el modo lectura a los demas txt  y botones 
            /// </summary>
            txtCodigo.ReadOnly = false ;
            txtRuc.ReadOnly = true ;
            txtRazonSocial.ReadOnly = true ;
            rbActivo.Enabled  = false ;
            rbInactivo.Enabled = false;
            btnAgregarDireccion.Enabled = false;
            btnEliminaDireccion.Enabled = false;
            ModoConsulta = true;
        }
        /// <summary>
        /// Metodo Consulta donde filtra por codigo
        /// </summary>
        private void Consulta(string codigo)
        {
            try
            {
                /// <summary>
                /// valida que el codigo no tenga menos de 6 digitos
                /// </summary>
                if (codigo.Length < 6)
                {
                    MessageBox.Show("El Codigo Permite como maximo 6 caracteres","AVISO");
                }
                else
                {
                    /// <summary>
                    /// busca el codigo para listarlo
                    /// </summary>
                    DataSet ds = clEmpresa.LISTA(codigo);

                    /// <summary>
                    /// valida si la lista tiene informacion
                    /// </summary>
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        /// <summary>
                        /// crea table donde se asigna el valor del dataset
                        /// </summary>
                        DataTable detalles = ds.Tables["DETALLE"];
                        DataTable cabeceras = ds.Tables["CABECERA"];

                        /// <summary>
                        /// almacena en una coleccion el table detalle
                        /// </summary>
                        IEnumerable<DataRow> LISTA_DETALLE =
                            from detalle in detalles.AsEnumerable()
                            select detalle;

                        /// <summary>
                        /// almacena en una coleccion el table cabecera
                        /// </summary>
                        IEnumerable<DataRow> LISTA_CABECERA =
                        from cabecera in cabeceras.AsEnumerable()
                        select cabecera;

                        /// <summary>
                        /// valido el detalle de direcciones para limpirar la lista
                        /// </summary>
                        if (LISTA_DETALLE.Count() > 0)
                        {
                            /// <summary>
                            /// llama al metodo LimpiaBuscador
                            /// </summary>
                            LimpiaBuscador();
                        }
                        /// <summary>
                        /// recorre la lista detalle
                        /// </summary>
                        foreach (DataRow p in LISTA_DETALLE)
                        {
                            /// <summary>
                            /// inserta la fila en la lista
                            /// </summary>
                            AgregaFila(p.Field<string>("DIRECCION"));
                        }
                        /// <summary>
                        /// recorre la cabecera para llenar los datos de ruc,razon socia,etc
                        /// </summary>
                        foreach (DataRow p in LISTA_CABECERA)
                        {

                            txtRuc.Text = p.Field<string>("RUC");
                            txtRazonSocial.Text = p.Field<string>("RAZON_SOCIAL");
                            /// <summary>
                            /// valida el estado para saber si esta activo o inactivo
                            /// </summary>
                            if (Convert.ToBoolean(p.Field<bool>("ESTADO")) == true)
                            {
                                rbActivo.Checked = true;
                                rbInactivo.Checked = false;
                            }
                            else
                            {
                                rbActivo.Checked = false;
                                rbInactivo.Checked = true;
                            }

                        }

                    }
                    else
                    {
                        /// <summary>
                        /// visualiza un mensaje al no encontrar informacion con el codigo digitado
                        /// </summary>
                        MessageBox.Show("No existe informacion con el codigo digitado","AVISO");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"AVISO");
            }


           
        }
        /// <summary>
        /// Metodo LimpiaBuscador
        /// </summary>
        public void LimpiaBuscador()
        {
            /// <summary>
            /// Limpia la grilla para que no existan datos duplicados de otra consulta
            /// </summary>
            DgDatos.DataSource = null;
            DgDatos.Rows.Clear();
        }

        /// <summary>
        /// Metodo EliminaDireccion
        /// </summary>
        private void EliminaDireccion()
        {
            /// <summary>
            /// valida si existen direcciones para eliminar
            /// </summary>
            if (DgDatos.Rows.Count == 0)
            {
                MessageBox.Show("No tiene direcciones para eliminar", "AVISO");
            }
            else
            {
                /// <summary>
                /// Elimina la fila seleccionada
                /// </summary>
                DgDatos.Rows.Remove(DgDatos.CurrentRow);
            }


        }

        /// <summary>
        /// Elimina la fila seleccionada
        /// </summary>
        private void AgregaFila(string direccion)
        {
            DataGridView miDataGridView = DgDatos;
            /// <summary>
            /// funcion que valida si la direccion existe
            /// </summary>
            if (ValidaDireccion(direccion)==false)
            {
                MessageBox.Show("La Direccion Digita Ya Existe", "AVISO");
            }
            else
            {
                /// <summary>
                /// inserta la direccion nueva
                /// </summary>
                int contador = (CuentaFilas()+1);
                DataGridViewRow nuevaFila = new DataGridViewRow();
                nuevaFila.CreateCells(miDataGridView);
                nuevaFila.Cells[0].Value = contador;
                nuevaFila.Cells[1].Value = direccion;
                miDataGridView.Rows.Add(nuevaFila);
            }


        }
        /// <summary>
        /// Metodo ValidaDireccion  envia la direccion digitada
        /// </summary>
        public bool ValidaDireccion(string direccion)
        {
            bool valida = true;
            /// <summary>
            /// valida si el datagrid tiene filas
            /// </summary>
            if (DgDatos.Rows.Count == 0)
            {
                valida = true;
            }
            else
            {
                /// <summary>
                /// recorre el datagrid y valia si la direccion digitada existe
                /// </summary>
                foreach (DataGridViewRow item in DgDatos.Rows){
                  if (item.Cells[1].Value.ToString() == direccion){
                     valida = false;
                     break;
                 }
               }
            }

            return valida;
        }

        /// <summary>
        /// Metodo CuentaFilas
        /// </summary>
        private int CuentaFilas()
        { int filas=0;
            /// <summary>
            /// recorre el datagrid para saber cuantos registros existe
            /// </summary>
            foreach (var item in DgDatos.Rows)
            {
                filas++;
            }


            return filas;
        }
        /// <summary>
        /// Metodo LimpiaCampos
        /// </summary>
        private void LimpiaCampos()
        {
            /// <summary>
            /// limpia y habilita los campos para un nuevo registro
            /// </summary>
            txtCodigo.Text = "";
            txtRuc.Text = "";
            txtRazonSocial.Text = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
            DgDatos.DataSource = null;
            DgDatos.Rows.Clear();
            ModoConsulta = false;
            /// <summary>
            /// genera codigo nuevo
            /// </summary>
            string Cadena = clEmpresa.CODIGO_AUTOGENERADO();
            txtCodigo.ReadOnly = true;
            txtCodigo.Text = Cadena;
            txtRuc.ReadOnly = false;
            txtRazonSocial.ReadOnly = false;
            rbActivo.Enabled = true;
            rbInactivo.Enabled = true;
            btnAgregarDireccion.Enabled = true;
            btnEliminaDireccion.Enabled = true;
        }
        /// <summary>
        /// Metodo ValidacionRegistro
        /// </summary>
        public string ValidacionRegistro()
        {
            string result = "";
            /// <summary>
            ///  valida que el campo ruc no tenga longitud mayor a 11 y menor a 11
            /// </summary>
            if (txtRuc.Text.Length > 11 || txtRuc.Text.Length <11)
            {
                result = "El Campo Ruc Solo Acepta 11 Digitos";
                return result;
            }
            /// <summary>
            ///  valida que el datagrid tenga registrada 1 direccion
            /// </summary>
            if (DgDatos.RowCount == 0)
            {
                result = "Debe Digitar Como minimo una Direccion";
                return result;
            }
            /// <summary>
            ///  valida que el campo ruc no este vacio y no tenga espacios en blanco
            /// </summary>
            if (txtRuc.Text.Trim() == "" || txtRuc.Text.Length == 0)
            {
                result = "Campo Ruc Obligatorio";

            }
            /// <summary>
            ///  valida que el campo Razon Social no este vacio y no tenga espacios en blanco
            /// </summary>
            if (txtRazonSocial.Text.Trim() == "" || txtRazonSocial.Text.Length == 0)
            {
                result = result + "\nCampo Razon Social Obligatorio";
            }
            /// <summary>
            ///  valida que el campo Estado esta seleccionado ya sea activo o inactivo
            /// </summary>
            if (rbActivo.Checked == false && rbInactivo.Checked == false)
            {
                result = result + "\nEl Campo Estado Obligatorio";

            }

            return result;
        }
        /// <summary>
        /// Metodo ValidaEstado
        /// </summary>
        public bool ValidaEstado()
        {
            bool estado = false;
            /// <summary>
            ///  valida si el campo activo esta seleccion y el campo inactivo no este seleccionado
            /// </summary>
            if (rbActivo.Checked == true && rbInactivo.Checked == false)
            {
                estado = true;
            }
            /// <summary>
            ///  valida si el campo activo no este seleccionado y el campo inactivo  este seleccionado
            /// </summary>
            if (rbActivo.Checked == false && rbInactivo.Checked == true)
            {
                estado = false;
            }
            return estado;
        }
        /// <summary>
        /// Metodo Grabar
        /// </summary>
        public void Grabar()
        {
            try
            {
                /// <summary>
                ///  valida que el modo consulta esta activo
                /// </summary>
                if (ModoConsulta == true)
                {
                    MessageBox.Show("No se puede guardar en modo consulta", "AVISO");
                    return;
                }
                /// <summary>
                ///  llama al metodo ValidacionRegistro
                /// </summary>
                string Validacion = ValidacionRegistro();

                /// <summary>
                ///  retorna el resultado del metodo ValidacionRegistro()
                /// </summary>
                if (Validacion != "")
                {
                    MessageBox.Show(Validacion,"AVISO");
                }
                else
                {
                    /// <summary>
                    ///  Instancia un objeto de la Clase Empresa
                    /// </summary>
                    EMPRESA objEmpresa = new EMPRESA();
                    objEmpresa.Codigo = txtCodigo.Text;
                    objEmpresa.Estado = ValidaEstado();
                    objEmpresa.Razon_Social = txtRazonSocial.Text;
                    objEmpresa.Ruc = txtRuc.Text;

                    /// <summary>
                    ///  Crear un objLista de la Lista DIRECCION_EMPRESA
                    /// </summary>
                    List<DIRECCION_EMPRESA> lista_direccion_empresa = new List<DIRECCION_EMPRESA>();
                    /// <summary>
                    ///  Crear un obj de la Lista DIRECCION_EMPRESA
                    /// </summary>
                    DIRECCION_EMPRESA obj_direccion_empresa;
                    /// <summary>
                    ///  recorre el datagrid
                    /// </summary>
                    foreach (DataGridViewRow  item in DgDatos.Rows)
                    {
                        /// <summary>
                        ///  llena el obj DIRECCION_EMPRESA
                        /// </summary>
                        obj_direccion_empresa = new DIRECCION_EMPRESA();
                        obj_direccion_empresa.Codigo = objEmpresa.Codigo;
                        obj_direccion_empresa.Direccion = item.Cells[1].Value.ToString();

                        /// <summary>
                        ///  llena la lista con el objeto 
                        /// </summary>
                        lista_direccion_empresa.Add(obj_direccion_empresa);
                    }
                    /// <summary>
                    ///  envia los objetos a la capa logica
                    /// </summary>
                    clEmpresa.INSERTA_EMPRESA_DIRECCION(objEmpresa, lista_direccion_empresa);
                    /// <summary>
                    ///  Llamamos al metodo LimpiaCampos();
                    /// </summary>
                    LimpiaCampos();
                    /// <summary>
                    ///  visualiza mensaje de registro ok
                    /// </summary>
                    MessageBox.Show("Se registro Correctamente", "AVISO");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO");
            }

        }


        #endregion


    }
}
