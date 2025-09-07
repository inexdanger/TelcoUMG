using System;
using System.Data;
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
            this.Load += frm_Empleados_Load;

            // Toolstrip
            btnAgregar.Click += btnAgregar_Click;     // si ya estaba en Designer, no pasa nada
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            iconToolStripButton1.Click += btnLimpiar_Click;
            btnCerrar.Click += btnCerrar_Click;

            // Grid
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;

            // Cambia salario al elegir tipo
            cbox_TipoEmpleado.SelectedIndexChanged += (s, e) =>
            {
                if (!string.IsNullOrEmpty(cbox_TipoEmpleado.Text))
                    txt_SalarioBase.Text = Lempleados.MtdSalarioBase(cbox_TipoEmpleado.Text).ToString("0.00");
            };
        }

        private void frm_Empleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            if (cbox_TipoEmpleado.Items.Count > 0 && cbox_TipoEmpleado.SelectedIndex < 0)
                cbox_TipoEmpleado.SelectedIndex = 0;

            if (cbox_Estado.Items.Count > 0 && cbox_Estado.SelectedIndex < 0)
                cbox_Estado.SelectedIndex = 0;
        }

        private void CargarEmpleados()
        {
            try
            {
                DataTable dt = empleados.Mtd_ConsultarEmpleados();
                dgvEmpleados.DataSource = dt;
                dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvEmpleados.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CREATE
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposEmpleado()) return;

            string nombre = txt_Nombre.Text.Trim();
            int dpi = int.Parse(txt_Dpi.Text.Trim());
            string direccion = txt_Direccion.Text.Trim();
            DateTime fechaIngreso = dtp_FechaIngreso.Value;
            string tipoEmpleado = cbox_TipoEmpleado.Text;
            string estado = cbox_Estado.Text;

            // salario según lógica
            double salarioBase = Lempleados.MtdSalarioBase(tipoEmpleado);

            try
            {
                empleados.Mtd_AgregarEmpleados(nombre, dpi, direccion, fechaIngreso, salarioBase, tipoEmpleado, estado);
                MessageBox.Show("Empleado agregado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCamposEmpleado();
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el empleado. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // UPDATE
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_codigoEmpleado.Text))
            {
                MessageBox.Show("Seleccione un empleado del listado.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidarCamposEmpleado()) return;

            int codigo = int.Parse(txt_codigoEmpleado.Text.Trim());
            string nombre = txt_Nombre.Text.Trim();
            int dpi = int.Parse(txt_Dpi.Text.Trim());
            string direccion = txt_Direccion.Text.Trim();
            DateTime fechaIngreso = dtp_FechaIngreso.Value;
            string tipoEmpleado = cbox_TipoEmpleado.Text;
            string estado = cbox_Estado.Text;
            double salarioBase = Lempleados.MtdSalarioBase(tipoEmpleado);

            try
            {
                empleados.Mtd_ActualizarEmpleado(codigo, nombre, dpi, direccion, fechaIngreso, salarioBase, tipoEmpleado, estado);
                MessageBox.Show("Empleado actualizado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCamposEmpleado();
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el empleado. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DELETE
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_codigoEmpleado.Text))
            {
                MessageBox.Show("Seleccione un empleado del listado.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show("¿Eliminar este empleado?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            try
            {
                empleados.Mtd_EliminarEmpleado(int.Parse(txt_codigoEmpleado.Text.Trim()));
                MessageBox.Show("Empleado eliminado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCamposEmpleado();
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el empleado. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCamposEmpleado();
        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();

        // Selección en grid → poblar campos
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvEmpleados.CurrentRow == null) return;
            var row = dgvEmpleados.CurrentRow;

            txt_codigoEmpleado.Text = row.Cells["CodigoEmpleado"]?.Value?.ToString() ?? "";
            txt_Nombre.Text = row.Cells["Nombre"]?.Value?.ToString() ?? "";
            txt_Dpi.Text = row.Cells["Dpi"]?.Value?.ToString() ?? "";
            txt_Direccion.Text = row.Cells["Direccion"]?.Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["FechaIngreso"]?.Value?.ToString(), out var fecha))
                dtp_FechaIngreso.Value = fecha;

            cbox_TipoEmpleado.Text = row.Cells["TipoEmpleado"]?.Value?.ToString() ?? "";
            cbox_Estado.Text = row.Cells["Estado"]?.Value?.ToString() ?? "";

            // mostrar salario base (solo informativo)
            txt_SalarioBase.Text = row.Cells["SalarioBase"]?.Value?.ToString() ?? "";
        }

        private bool ValidarCamposEmpleado()
        {
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_Dpi.Text) ||
                string.IsNullOrWhiteSpace(txt_Direccion.Text) ||
                string.IsNullOrWhiteSpace(cbox_TipoEmpleado.Text) ||
                string.IsNullOrWhiteSpace(cbox_Estado.Text))
            {
                MessageBox.Show("Complete todos los campos requeridos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txt_Dpi.Text.Trim(), out _))
            {
                MessageBox.Show("DPI debe ser numérico.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Dpi.Focus(); return false;
            }

            return true;
        }

        private void LimpiarCamposEmpleado()
        {
            txt_codigoEmpleado.Text = "";
            txt_Nombre.Text = "";
            txt_Dpi.Text = "";
            txt_Direccion.Text = "";
            dtp_FechaIngreso.Value = DateTime.Now.Date;
            if (cbox_TipoEmpleado.Items.Count > 0) cbox_TipoEmpleado.SelectedIndex = 0;
            if (cbox_Estado.Items.Count > 0) cbox_Estado.SelectedIndex = 0;
            txt_SalarioBase.Text = Lempleados.MtdSalarioBase(cbox_TipoEmpleado.Text).ToString("0.00");
            txt_Nombre.Focus();
        }
    }
}
