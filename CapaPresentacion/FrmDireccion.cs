using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmDireccion : Form
    {

        public string resultado { get; set; }

        
        public FrmDireccion()
        {
            InitializeComponent();
            txtDireccion.Text = "";
        }
        /// <summary>
        ///  Evento Boton Cerrar
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///  cierra modal
            /// </summary>
            this.Close();
        }
        /// <summary>
        ///  Evento Boton Agregar
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///  llena la direccion digitada en una variable
            /// </summary>
            resultado = txtDireccion.Text.Trim();
            /// <summary>
            ///  valida que el campo direccion tenga informacion
            /// </summary>
            if (resultado == "")
            {
                /// <summary>
                ///  visualiza mensaje al no tener direccion digitada
                /// </summary>
                MessageBox.Show("El Campo Direccion no puede ser vacio","AVISO");
            }
            else
            {
                /// <summary>
                ///  manda un evento DialogResult y cierra el modal
                /// </summary>
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
