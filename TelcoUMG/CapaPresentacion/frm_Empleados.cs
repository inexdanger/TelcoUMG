using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaLogica;

namespace CapaPresentacion
{

    public partial class frm_Empleados : Form
    {
        CD_Empleados empleados = new CD_Empleados();
        CL_Empleados Lempleados = new CL_Empleados();
        public frm_Empleados()
        {
            InitializeComponent();
        }

        private void Mtd_CosultarEmpleados()
        {
            DataTable dt = empleados.Mtd_ConsultarEmpleados();
            dgvEmpleados.DataSource = dt;
        }

        private void Mtd_LimpiarCampos()
        {

        }

        private void frm_Empleados_Load(object sender, EventArgs e)
        {
            Mtd_CosultarEmpleados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nombre.Text) || string.IsNullOrEmpty(txt_Direccion.Text)||string.IsNullOrEmpty(txt_Dpi.Text)||string.IsNullOrEmpty(txt_SalarioBase.Text)||string.IsNullOrEmpty(cbox_TipoEmpleado.Text)||string.IsNullOrEmpty(cbox_Estado.Text))
            {
                MessageBox.Show("Complete todos los cambos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else 
            {
                string Nombre = txt_Nombre.Text;
                int Dpi = int.Parse(txt_Dpi.Text);
                string Direccion = txt_Direccion.Text;
                DateTime FechaIngreso = dtp_FechaIngreso.Value;
                string TipoEmpleado = cbox_TipoEmpleado.Text;
                string Estado = cbox_Estado.Text;
                double SalarioBase = Lempleados.MtdSalarioBase(TipoEmpleado);


                try
                {
                    empleados.Mtd_AgregarEmpleados(Nombre, Dpi, Direccion, FechaIngreso, SalarioBase, TipoEmpleado, Estado);
                    MessageBox.Show("Empleado agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtd_CosultarEmpleados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
        }
    }
}
