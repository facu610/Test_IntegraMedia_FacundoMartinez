using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_IntegraMedia_FacundoMartinez
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region METODOS 

        //Var que almacena el formulario que se abre. 
        private Form formActivo = null;



        //Metodo que abre un unico formulario (Hijo) en un panel contenedor.
        private void abrirForm_Hijo(Form formHijo)
        {
            // Primero debemos cerrar el formulario anterior o el que esté abierto. Es decir, si existe un formulario abierto, lo cerramos. 
            if (formActivo != null) formActivo.Close();

            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formHijo);
            pnlContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();


        }


        #endregion

        #region EVENTOS 
        #endregion

        private void btnVenta_Click(object sender, EventArgs e)
        {
            abrirForm_Hijo(new frmPrincipal());
        }
    }
}
