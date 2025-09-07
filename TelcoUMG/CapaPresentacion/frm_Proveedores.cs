using System;
using System.Data;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frm_Proveedores : Form
    {
        private readonly CD_Proveedores proveedores = new CD_Proveedores();

        public frm_Proveedores()
        {
            InitializeComponent();

            // Enlazo eventos aquí para no tocar el Designer
            this.Load += frm_Proveedores_Load;
            btn_Agregar.Click += btn_Agregar_Click;
            btn_Editar.Click += btn_Editar_Click;
            btn_Eliminar.Click += btn_Eliminar_Click;
            btn_Limpiar.Click += btn_Limpiar_Click;
            btn_Cerrar.Click += btn_Cerrar_Click;
            dgv_Proveedores.CellClick += dgv_Proveedores_CellClick;
        }

        // ===== Utilitarios =====

        private void Mtd_Listar()
        {
            try
            {
                DataTable dt = proveedores.Mtd_ConsultarProveedores();
                dgv_Proveedores.DataSource = dt;
                if (kryptonHeaderGroup1 != null)
                    kryptonHeaderGroup1.ValuesSecondary.Description = $"Registros: {dgv_Proveedores.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Mtd_Validar()
        {
            if (string.IsNullOrWhiteSpace(txt_codigo_proveedor.Text))
            {
                MessageBox.Show("Ingrese el código del proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_codigo_proveedor.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                MessageBox.Show("Ingrese el nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nombre.Focus();
                return false;
            }
            // Podés agregar más validaciones si querés (email, tel, etc.)
            return true;
        }

        private void Mtd_Limpiar()
        {
            txt_codigo_proveedor.Clear();
            txt_Nombre.Clear();
            txt_Contacto.Clear();
            txt_Telefono.Clear();
            txt_Email.Clear();
            txt_Direccion.Clear();
            txt_Estado.Clear();
            txt_codigo_proveedor.Focus();
        }

        private void Mtd_PasarFilaATextos()
        {
            if (dgv_Proveedores.CurrentRow == null) return;

            var row = dgv_Proveedores.CurrentRow;
            // Asegurate que estos nombres de columna existen en la tabla / SELECT
            txt_codigo_proveedor.Text = row.Cells["CodigoProveedor"].Value?.ToString();
            txt_Nombre.Text = row.Cells["Nombre"].Value?.ToString();
            txt_Contacto.Text = row.Cells["Contacto"].Value?.ToString();
            txt_Telefono.Text = row.Cells["Telefono"].Value?.ToString();
            txt_Email.Text = row.Cells["Email"].Value?.ToString();
            txt_Direccion.Text = row.Cells["Direccion"].Value?.ToString();
            txt_Estado.Text = row.Cells["Estado"].Value?.ToString();
        }

        // ===== Eventos =====

        private void frm_Proveedores_Load(object sender, EventArgs e)
        {
            Mtd_Listar();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (!Mtd_Validar()) return;

            try
            {
                proveedores.Mtd_AgregarProveedor(
                    txt_codigo_proveedor.Text.Trim(),
                    txt_Nombre.Text.Trim(),
                    txt_Contacto.Text.Trim(),
                    txt_Telefono.Text.Trim(),
                    txt_Email.Text.Trim(),
                    txt_Direccion.Text.Trim(),
                    txt_Estado.Text.Trim()
                );

                MessageBox.Show("Proveedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mtd_Listar();
                Mtd_Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (!Mtd_Validar()) return;

            try
            {
                proveedores.Mtd_EditarProveedor(
                    txt_codigo_proveedor.Text.Trim(),
                    txt_Nombre.Text.Trim(),
                    txt_Contacto.Text.Trim(),
                    txt_Telefono.Text.Trim(),
                    txt_Email.Text.Trim(),
                    txt_Direccion.Text.Trim(),
                    txt_Estado.Text.Trim()
                );

                MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mtd_Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_codigo_proveedor.Text))
            {
                MessageBox.Show("Seleccione un proveedor (o escriba el código) para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show("¿Seguro que desea eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                proveedores.Mtd_EliminarProveedor(txt_codigo_proveedor.Text.Trim());
                MessageBox.Show("Proveedor eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mtd_Listar();
                Mtd_Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Mtd_Limpiar();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                Mtd_PasarFilaATextos();
        }
    }
}