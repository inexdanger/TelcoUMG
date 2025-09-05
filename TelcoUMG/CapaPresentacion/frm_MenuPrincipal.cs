using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frm_MenuPrincipal : KryptonForm
    {

        //Estilo Borde Form Menu Pricipal
        private int borderSize = 2;
        private Size formSize;
        public frm_MenuPrincipal()
        {
            InitializeComponent();

            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(98, 102, 244);//Border color
        }

        //Agregar a form Menu pricipal
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        
        private void frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            formSize = this.ClientSize;
        }

        private void PanelLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0); // Mover el formulario
            }
        }

        private void PanelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Cursor.Position.Y < 15)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelCentral.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelCentral.Controls.Add(formulario);
                PanelCentral.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Clientes>();
        }

        private void btn_CerrarS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Empleados>();
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<tbl_Proveedores>();
        }
    }
}
