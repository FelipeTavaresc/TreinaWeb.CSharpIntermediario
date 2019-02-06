using AgendaADONET.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaADONET
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            int id = (int)dgvAgenda.CurrentRow.Cells[0].Value;
            ContatoDAO contatoDao = new ContatoDAO();
            contatoDao.Excluir(id);
            CarregarDataGridView();
        }

        private void CarregarDataGridView()
        {
            ContatoDAO contatoDAO = new ContatoDAO();
            DataTable dataTable = contatoDAO.GetContatos();
            dgvAgenda.DataSource = dataTable;
            dgvAgenda.Refresh();
        }
    }
}
