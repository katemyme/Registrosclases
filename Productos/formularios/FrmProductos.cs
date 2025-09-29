using System;
using Productos.Dao;
using System.Windows.Forms;
using Productos.Modelos;

namespace Productos
{   
    public partial class Form1 : Form
    {
        ProductoDao dao = new ProductoDao();
        public Form1()
        {
            InitializeComponent();
            LLenarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.Nombre = tbNoombre.Text.ToUpper();
            prod.Codigo = tbCodigo.Text.ToUpper();
            prod.Precio = double.Parse(tbPrecio.Text);
            prod.IVA = chkIVA.Checked;
            dao.Agregar(prod);
            LLenarGrid();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void LLenarGrid()
        {
            this.dgbRegistro.DataSource = dao.Vercarrito();
            this.dgbRegistro.Refresh();

        }
private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbRegistro_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
