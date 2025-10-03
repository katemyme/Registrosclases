using Productos.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos.formularios
{
    public partial class FrmArreglo : Form
    {
        public FrmArreglo()
        {
            InitializeComponent();
        }

        private void tbEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                Agregar();
                e.SuppressKeyPress = true;
            }
        }

        public void MostrarEdades()
        {
            lbEdades.DataSource = null;
            lbEdades.DataSource = EdadaDao.edades;
            lbEdades.Refresh();
        }

        private void FrmArreglo_Load(object sender, EventArgs e)
        {
            MostrarEdades();
        }

        public void Agregar()
        {
            try
            {
                if (int.TryParse(tbEdad.Text, out int edad) && edad > 0 && edad <= 120)
                    EdadaDao.edades[EdadaDao.pos++] = edad;
                else MessageBox.Show("Solo se permiten numero enteros", "advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No se puede agregar mas elementos", "advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                utilerias();
            }
        }
        public void utilerias()
        {
            tbEdad.Clear();
            tbEdad.Focus();
            MostrarEdades();
        }

        private void lblPromedio_Click(object sender, EventArgs e)
        { }
    }
}
