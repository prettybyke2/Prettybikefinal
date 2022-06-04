
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Prettybike
{
    internal class Command
    {
        public Command()
        {
            

        }

        public DataTable OrdersTable()
        {
            System.Data.DataTable OrdersTable = new DataTable("Orders");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "idCommand";
            column.Unique = true;
            OrdersTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "date_cmd";
            OrdersTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Representative_id_rps";
            OrdersTable.Columns.Add(column);

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = OrdersTable.Columns["idCommand"];
            OrdersTable.PrimaryKey = PrimaryKeyColumns;

            return OrdersTable;


            

        }

        private static void ShowTable(DataTable table)
        {
            foreach (DataColumn col in table.Columns)
            {
                Console.Write("{0,-14}", col.ColumnName);
            }
            Console.WriteLine();

            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    if (col.DataType.Equals(typeof(DateTime)))
                        Console.Write("{0,-14:d}", row[col]);
                    else if (col.DataType.Equals(typeof(Decimal)))
                        Console.Write("{0,-14:C}", row[col]);
                    else
                        Console.Write("{0,-14}", row[col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public DataTable OrderTable = new DataTable();
        

        public void GetCommand()
        {
            
            MySqlConnection myConnection = new MySqlConnection("database = New_db; server = pat.infolab.ecam.be;port = 63345; user = admin; pwd = prettybyke2");
            try
            {
                myConnection.Open();
                
                String myQueryString = "SELECT * FROM New_db.Command";
                MySqlCommand myCmd = new MySqlCommand(myQueryString, myConnection);
                MySqlDataReader myDbReader = null;
                myDbReader = myCmd.ExecuteReader();

                MessageBox.Show("Connecté");

                Console.WriteLine(myCmd.CommandText);

                DataTable myDT = new DataTable();
                myDT.Load(myDbReader);
                OrderTable.Load(myDbReader);
                int incr = 0;
                while (incr < myDT.Rows.Count)
                {
                    foreach (DataColumn col in myDT.Columns)
                        {
                        
                            MessageBox.Show(myDT.Rows[incr][col].ToString());
                                
                        }
                    incr += 1;

                }
                
                    
                
                //                while (mydbreader.read()) // read next line
                //                {
                //                    extract data from record
                //#pragma warning disable cs8600 // conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
                //                    string idcmd_line = mydbreader["new_db.idcmd_line"].tostring();
                //#pragma warning restore cs8600 // conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
                //                    string qty = mydbreader.getstring(1);
                //                    string idcmd = mydbreader.getstring(2);
                //                    do something with data...
                //                    messagebox.show("connecté de fou");
                //                    messagebox.show(idcmd);
                //                }
            }
            catch
            {
                MessageBox.Show("Non connecté");
            }
        }
    }
}