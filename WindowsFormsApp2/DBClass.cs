using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp2
{
    class DBClass
    {
        private int selectedRowIndex;
        private int selectedKeyValue;
        OracleDataAdapter dBAdapter;
        DataSet dS;
        OracleCommandBuilder myCommandBuilder;
        DataTable resultTable;

        public int SelectedRowIndex
        {
            get { return selectedRowIndex; }
            set { selectedRowIndex = value; }
        }
        public int SelectedKeyValue
        {
            get { return selectedKeyValue; }
            set { selectedKeyValue = value; }
        }
        public OracleDataAdapter DBAdapter
        {
            get { return dBAdapter; }
            set { dBAdapter = value; }
        }
        public DataSet DS { get { return dS; } set { dS = value; } }
        public OracleCommandBuilder MyCommandBuilder
        {
            get
            {
                return myCommandBuilder;
            }
            set { myCommandBuilder = value; }
        }
        public DataTable ResultTable
        {
            get { return resultTable; }
            set
            {
                resultTable = value;
            }
        }

        public void DB_Open(string commandString, string tableName)
        {
            try
            {
                string connectionString = "User Id=stackload; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe))); ";

                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
                DBAdapter.Fill(DS, tableName);
                ResultTable = DS.Tables[tableName];
            }
            catch (DataException DE) {
                MessageBox.Show(DE.Message);
            }
        }

        public void DB_ObjCreate()
        {
            ResultTable = new DataTable();
        }

        public void ExecuteNonQuery(string query)
        {
            try
            {
                string connectionString = "User Id=stackload; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe))); ";
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                throw;
            }
        }
    }
}
