using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WcfServiceTools
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceTools" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceTools.svc or ServiceTools.svc.cs at the Solution Explorer and start debugging.
    public class ServiceTools : IServiceTools
    {
        SqlConnection konekcija = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["konekcija_lokal"]);

        public void DoWork()
        {
            Console.WriteLine("Juhuu");
        }
        public DataTable VratiTablu(string StoreProc, Dictionary<string, object> SqlParametri)
        {
            DataTable tabela = new DataTable(StoreProc);
          
            using (konekcija)
            {
                SqlCommand komanda = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = komanda;
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.Connection = konekcija;
                komanda.CommandText = StoreProc;
                komanda.Parameters.Clear();
                if (SqlParametri != null)
                    foreach (KeyValuePair<string, object> sp in SqlParametri)
                    {
                        komanda.Parameters.AddWithValue(sp.Key, sp.Value);
                    }
                da.Fill(tabela);
            }
            return tabela;
        }
        public DataSet VratiSet(string StoreProc, Dictionary<string, object> SqlParametri)
        {
            DataSet ds = new DataSet();
            using (konekcija)
            {
                SqlCommand komanda = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = komanda;
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.Connection = konekcija;
                komanda.CommandText = StoreProc;
                komanda.Parameters.Clear();
                if (SqlParametri != null)
                    foreach (KeyValuePair<string, object> sp in SqlParametri)
                    {
                        komanda.Parameters.AddWithValue(sp.Key, sp.Value);
                    }
                da.Fill(ds);
            }
            return ds;
        }
        public object VratiObjekat(string StoreProc, Dictionary<string, object> SqlParametri)
        {
            object dObj = new object();
            using (konekcija)
            {
                SqlCommand komanda = new SqlCommand();
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.Connection = konekcija;
                komanda.CommandText = StoreProc;
                komanda.Parameters.Clear();
                if (SqlParametri != null)
                    foreach (KeyValuePair<string, object> sp in SqlParametri)
                    {
                        komanda.Parameters.AddWithValue(sp.Key, sp.Value);
                    }
                konekcija.Open();
                dObj = komanda.ExecuteScalar();
                konekcija.Close();
            }
            return dObj;
        }
    }
}
