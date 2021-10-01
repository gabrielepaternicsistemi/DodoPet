using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodoPet
{
    class DataHelper
    {

        public DataSet GetVenduto(DateTime dataInizio, DateTime dataFine)
        {
            string sqlTestate = Query.TestateVenduto;
            string sqlRighe = Query.RigheVenduto;
            DataSet ds = new DataSet();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                using (SqlCommand command = new SqlCommand(sqlRighe, connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        command.Parameters.AddWithValue("@DATAINIZIO", dataInizio);
                        command.Parameters.AddWithValue("@DATAFINE", dataFine.AddDays(-1));
                        dataAdapter.Fill(ds, "MOVMAG");
                    }
                }

                using (SqlCommand command = new SqlCommand(sqlTestate, connection))
                {
                    command.Parameters.AddWithValue("@DATAINIZIO", dataInizio);
                    command.Parameters.AddWithValue("@DATAFINE", dataFine);
                    using (SqlDataAdapter dataAdapter2 = new SqlDataAdapter(command))
                    {
                        dataAdapter2.Fill(ds, "TESTMAG");
                    }
                }
                return ds;
            }
        }

        public DataSet getListiniTemporaneo()
        {
            string sql = Query.LISTALISTINITEMP;
            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dr;
                        dataAdapter.Fill(ds);
                        dr = ds.Tables[0];
                        return ds;
                    }
                }
            }
        }

        public string svuotaTempImport()
        {
            string result = "";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                connection.Open();
                string StrQuery = Query.ELIMINATEM;
                SqlCommand command = new SqlCommand(StrQuery, connection);
                try
                {
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    result = e.ToString();
                }
            }
            return result;
        }

        public string importDataFromExcelx(string excelfilePath)
        {
            string sexcelconnectionstring = " Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + excelfilePath + "; Extended Properties = Excel 12.0";
            using (OleDbConnection exel_con = new OleDbConnection(sexcelconnectionstring))
            {
                exel_con.Open();
                string sheet1 = exel_con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null).Rows[0]["TABLE_NAME"].ToString();

                DataTable dtExcelData = new DataTable();
                dtExcelData.Columns.AddRange(new DataColumn[30] {
                    new DataColumn("COD", typeof(string)),
                    new DataColumn("CODICI EAN",typeof(string)),
                    new DataColumn("REFERENZE", typeof(int)),
                    new DataColumn("IVA",typeof(string)),
                    new DataColumn("ar_gruppo", typeof(string)),
                    new DataColumn("ar_sotgru",typeof(string)),
                    new DataColumn("ar_qtacon2", typeof(double)),
                    new DataColumn("ar_conver", typeof(double)),
                    new DataColumn("ar_volume",typeof(double)),
                    new DataColumn("lc_listino6", typeof(double)),
                    new DataColumn("ar_unmis",typeof(string)),
                    new DataColumn("xx_qtaordinata",typeof(int)),
                    new DataColumn("ar_forn",typeof(int)),
                    new DataColumn("ar_codart1",typeof(string)),
                    new DataColumn("ar_codart2",typeof(string)),
                    new DataColumn("xx_codart",typeof(string)),
                    new DataColumn("ar_misura1",typeof(double)),
                    new DataColumn("ar_misura2",typeof(double)),
                    new DataColumn("ar_misura3",typeof(double)),
                    new DataColumn("bc_code",typeof(string)),
                    new DataColumn("bc_tipo",typeof(int)),
                    new DataColumn("lc_listino5",typeof(double)),
                    new DataColumn("lc_listino1",typeof(double)),
                    new DataColumn("lc_listino2",typeof(double)),
                    new DataColumn("so_scontol2",typeof(double)),
                    new DataColumn("lc_listino3",typeof(double)),
                    new DataColumn("so_sconto1l3",typeof(double)),
                    new DataColumn("so_sconto2l3",typeof(double)),
                    new DataColumn("ar_minord",typeof(int)),
                    new DataColumn("ar_varianti",typeof(string))
                });



                using (OleDbDataAdapter oda = new OleDbDataAdapter(String.Format("select * from [{0}${1}]", "Sheet1", "A2:AE"), exel_con))
                {
                    oda.Fill(dtExcelData);
                }

                exel_con.Close();

                //  string consString = ConfigurationManager.ConnectionStrings["DB_DATI"].ToString();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                    {

                        sqlBulkCopy.DestinationTableName = ConfigurationManager.AppSettings["NOMETABELLA"].ToString();

                        sqlBulkCopy.ColumnMappings.Add("xx_codartfo", "xx_codartfo");
                        sqlBulkCopy.ColumnMappings.Add("ar_descr", "ar_descr");
                        sqlBulkCopy.ColumnMappings.Add("ar_codiva", "ar_codiva");
                        sqlBulkCopy.ColumnMappings.Add("ar_famprod", "ar_famprod");
                        sqlBulkCopy.ColumnMappings.Add("ar_gruppo", "ar_gruppo");
                        sqlBulkCopy.ColumnMappings.Add("ar_sotgru", "ar_sotgru");
                        sqlBulkCopy.ColumnMappings.Add("ar_qtacon2", "ar_qtacon2");
                        sqlBulkCopy.ColumnMappings.Add("ar_conver", "ar_conver");
                        sqlBulkCopy.ColumnMappings.Add("ar_volume", "ar_volume");
                        sqlBulkCopy.ColumnMappings.Add("lc_listino6", "lc_listino6");
                        sqlBulkCopy.ColumnMappings.Add("ar_unmis", "ar_unmis");
                        sqlBulkCopy.ColumnMappings.Add("xx_qtaordinata", "xx_qtaordinata");
                        sqlBulkCopy.ColumnMappings.Add("ar_forn", "ar_forn");
                        sqlBulkCopy.ColumnMappings.Add("ar_codart1", "ar_codart1");
                        sqlBulkCopy.ColumnMappings.Add("ar_codart2", "ar_codart2");
                        sqlBulkCopy.ColumnMappings.Add("xx_codart", "xx_codart");
                        sqlBulkCopy.ColumnMappings.Add("ar_misura1", "ar_misura1");
                        sqlBulkCopy.ColumnMappings.Add("ar_misura2", "ar_misura2");
                        sqlBulkCopy.ColumnMappings.Add("ar_misura3", "ar_misura3");
                        sqlBulkCopy.ColumnMappings.Add("bc_code", "bc_code");
                        sqlBulkCopy.ColumnMappings.Add("bc_tipo", "bc_tipo");
                        sqlBulkCopy.ColumnMappings.Add("lc_listino5", "lc_listino5");
                        sqlBulkCopy.ColumnMappings.Add("lc_listino1", "lc_listino1");
                        sqlBulkCopy.ColumnMappings.Add("lc_listino2", "lc_listino2");
                        sqlBulkCopy.ColumnMappings.Add("so_scontol2", "so_scontol2");
                        sqlBulkCopy.ColumnMappings.Add("lc_listino3", "lc_listino3");
                        sqlBulkCopy.ColumnMappings.Add("so_sconto1l3", "so_sconto1l3");
                        sqlBulkCopy.ColumnMappings.Add("so_sconto2l3", "so_sconto2l3");
                        sqlBulkCopy.ColumnMappings.Add("ar_minord", "ar_minord");
                        sqlBulkCopy.ColumnMappings.Add("ar_varianti", "ar_varianti");

                        con.Open();
                        sqlBulkCopy.WriteToServer(dtExcelData);
                        con.Close();
                    }
                }
            }
            return String.Empty;
        }

    }
}


