using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WF_SmallTools
{
    public partial class fSpisakServera : Form
    {
        dsProject.SqlServeriDataTable tabela;
        public fSpisakServera(dsProject.SqlServeriDataTable Tabela)
        {
            InitializeComponent();
            tabela = Tabela;
            dgvServeri.DataSource = tabela;
          
        }

        private void fSpisakServera_Load(object sender, EventArgs e)
        {
           dgvServeri.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvServeri.Columns[0].Width = 50;
            dgvServeri.Columns[1].Width = 250;
            dgvServeri.Columns[2].Width = 150;
            dgvServeri.Columns[3].Width = 50;
            dgvServeri.Columns[4].Width = 100;
            dgvServeri.Columns[5].Width = 100;
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvServeri.CurrentRow!=null)
            dgvServeri.Rows.RemoveAt(dgvServeri.CurrentRow.Index);          
        }

        private void fSpisakServera_FormClosing(object sender, FormClosingEventArgs e)
        {
         DialogResult Odgovor=   MessageBox.Show("Промене у табели ће бити изгубљене.\n Да ли желите претходно да их сачувате?", "Упозорење!", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if(Odgovor==DialogResult.OK) tabela.AcceptChanges();
            if (Odgovor == DialogResult.Cancel) tabela.RejectChanges();
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabela.AcceptChanges();
        }
    }
}
