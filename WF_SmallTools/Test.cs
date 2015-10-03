using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_SmallTools.ServiceReferenceTools;

namespace WF_SmallTools
{
    public partial class Test : Form
    {
        ServiceToolsClient klijent = new ServiceToolsClient();
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
          DataSet ds=  klijent.VratiSet("Napuni_Combos", null);
            cbCategories.DataSource = ds.Tables[0];
            cbCategories.DisplayMember = "CategoryName";
            cbRegions.DataSource = ds.Tables[1];
            cbRegions.DisplayMember = "RegionDescription";
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            int kol = (int)((DataRowView)cbCategories.SelectedItem)[0];
            Dictionary<string, object> Parametri = new Dictionary<string, object>();
            Parametri.Add("@param1", kol);
            dgProcedure.DataSource = null;
            dgProcedure.DataSource = klijent.VratiTablu("Get_ProductsByCategory", Parametri);
        }

        private void btnDataSet_Click(object sender, EventArgs e)
        {
            int kolP = (int)((DataRowView)cbCategories.SelectedItem)[0];
            int kolT = (int)((DataRowView)cbRegions.SelectedItem)[0];
            Dictionary<string, object> Parametri = new Dictionary<string, object>();
            Parametri.Add("@param1", kolP);
            Parametri.Add("@param2", kolT);
            dgProcedure.DataSource = null;
            DataSet ds= klijent.VratiSet("Get_DataSet", Parametri);
            ds.Tables[0].TableName = "Products"; ds.Tables[1].TableName = "Teritories";
            dgProcedure.DataSource = ds;
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kol = (int)((DataRowView)cbCategories.SelectedItem)[0];
            Dictionary<string, object> Parametri = new Dictionary<string, object>();
            Parametri.Add("@param1", kol);
            lblBroj.Text = klijent.VratiObjekat("Get_CountOfProd", Parametri).ToString();
        }

        private void cbRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kol = (int)((DataRowView)cbRegions.SelectedItem)[0];
            Dictionary<string, object> Parametri = new Dictionary<string, object>();
            Parametri.Add("@param1", kol);
            lblNumer.Text = klijent.VratiObjekat("Get_CountOfTeritories", Parametri).ToString();
        }
    }
}
