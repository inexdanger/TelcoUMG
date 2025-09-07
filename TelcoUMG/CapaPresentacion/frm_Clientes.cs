using System;
using System.Data;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frm_Clientes : Form
    {
        private readonly CD_Clientes _clientes = new CD_Clientes();

        public frm_Clientes()
        {
            InitializeComponent();

            // El designer ya conecta btn_Agregar_Click (si no, igual funcionará).
            this.Load += frm_Clientes_Load;

            // Los otros botones normalmente no tienen handler en Designer:
            btn_Editar.Click += btn_Editar_Click;
            btn_Eliminar.Click += btn_Eliminar_Click;
            btn_Limpiar.Click += btn_Limpiar_Click;
            btn_Cerrar.Click += btn_Cerrar_Click;

            dgv_Clientes.CellClick += dgv_Clientes_CellClick;
        }

        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                DataTable dt = _clientes.Mtd_ConsultarClientes();
                dgv_Clientes.DataSource = dt;
                dgv_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgv_Clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_Clientes.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // AGREGAR (el Designer suele apuntar aquí)
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                _clientes.Mtd_AgregarClientes(
                    txt_Nombre.Text.Trim(),
                    txt_Apellido.Text.Trim(),
                    int.Parse(txt_DPI.Text.Trim()),
                    int.Parse(txt_Telefono.Text.Trim()),
                    txt_Email.Text.Trim(),
                    txt_Estado.Text.Trim()
                );

                MessageBox.Show("Cliente agregado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el cliente. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EDITAR
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CodigoCliente.Text))
            {
                MessageBox.Show("Seleccione un cliente del listado.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidarCampos()) return;

            try
            {
                _clientes.Mtd_ActualizarCliente(
                    int.Parse(txt_CodigoCliente.Text.Trim()),
                    txt_Nombre.Text.Trim(),
                    txt_Apellido.Text.Trim(),
                    int.Parse(txt_DPI.Text.Trim()),
                    int.Parse(txt_Telefono.Text.Trim()),
                    txt_Email.Text.Trim(),
                    txt_Estado.Text.Trim()
                );

                MessageBox.Show("Cliente actualizado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el cliente. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ELIMINAR
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CodigoCliente.Text))
            {
                MessageBox.Show("Seleccione un cliente del listado.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show("¿Eliminar este cliente?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            try
            {
                _clientes.Mtd_EliminarCliente(int.Parse(txt_CodigoCliente.Text.Trim()));

                MessageBox.Show("Cliente eliminado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el cliente. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // LIMPIAR
        private void btn_Limpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        // CERRAR
        private void btn_Cerrar_Click(object sender, EventArgs e) => this.Close();

        // Cargar campos al seleccionar del grid
        private void dgv_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgv_Clientes.CurrentRow == null) return;
            var row = dgv_Clientes.CurrentRow;

            txt_CodigoCliente.Text = row.Cells["CodigoCliente"]?.Value?.ToString() ?? "";
            txt_Nombre.Text = row.Cells["Nombre"]?.Value?.ToString() ?? "";
            txt_Apellido.Text = row.Cells["Apellido"]?.Value?.ToString() ?? "";
            txt_DPI.Text = row.Cells["Dpi"]?.Value?.ToString() ?? "";
            txt_Telefono.Text = row.Cells["Telefono"]?.Value?.ToString() ?? "";
            txt_Email.Text = row.Cells["Email"]?.Value?.ToString() ?? "";
            txt_Estado.Text = row.Cells["Estado"]?.Value?.ToString() ?? "";
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_Apellido.Text) ||
                string.IsNullOrWhiteSpace(txt_DPI.Text) ||
                string.IsNullOrWhiteSpace(txt_Telefono.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_Estado.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txt_DPI.Text.Trim(), out _))
            {
                MessageBox.Show("DPI debe ser numérico.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DPI.Focus(); return false;
            }

            if (!int.TryParse(txt_Telefono.Text.Trim(), out _))
            {
                MessageBox.Show("Teléfono debe ser numérico.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Telefono.Focus(); return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txt_CodigoCliente.Text = "";
            txt_Nombre.Text = "";
            txt_Apellido.Text = "";
            txt_DPI.Text = "";
            txt_Telefono.Text = "";
            txt_Email.Text = "";
            txt_Estado.Text = "";
            txt_Nombre.Focus();
        }
    }
}
