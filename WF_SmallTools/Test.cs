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

        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> Parametri = new Dictionary<string, object>();
            Parametri.Add("@param1", 1);
            dgProcedure.DataSource = null;
            dgProcedure.DataSource = klijent.VratiTablu("Get_ProductsByCategory", Parametri);
        }

        private void btnDataSet_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> Parametri = new Dictionary<string, object>();
            Parametri.Add("@param1", 1);
            Parametri.Add("@param2", 1);
            dgProcedure.DataSource = null;
            dgProcedure.DataSource = klijent.VratiSet("Get_DataSet", Parametri);
        }
    }
}
