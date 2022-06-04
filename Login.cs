using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Prettybike
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //amounts.Add(200);
            //amounts.Add(300);
            //amounts.Add(150);
            //orders.Add("vélos noirs City 26''");
            //orders.Add("vélos jaunes City 28''");
            //orders.Add("vélos bleus City 28''");
        }

        public static List<string> orders = new List<string>();
        public static List<int> amounts = new List<int>();
        private void lbl_Identif_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {


           

        }

        public static class myAmount
        {

            public static int currentAmount = amounts[0];

        }
        public static class myOrder
        {

            public static string currentOrder = orders[0];

        }
        public DataTable OrderTable = new DataTable();



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


        
        private void btn_login_Click(object sender, EventArgs e)
        {

            ManagerPart_Newpage();


        }

        private void txtbox_Passwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_ID_TextChanged(object sender, EventArgs e)
        {

            

        }

        
        private void ManagerPart_Newpage()
        {

            Manager_Part manager_Part = new Manager_Part();
            manager_Part.Show();

            this.Hide();




            MySqlConnection myConnection = new MySqlConnection("database = New_db; server = pat.infolab.ecam.be;port = 63345; user = admin; pwd = prettybyke2");
            try
            {
                myConnection.Open();
                String QueryRepres = "SELECT * FROM Representative";
                String QueryCommand = "SELECT* FROM Command";
                String QueryBuilders = "SELECT * FROM Builder";
                String Querycmd_line = "SELECT * FROM cmd_line";
                String QueryBikes = "SELECT * FROM Bikes";


                MySqlCommand myCmd_Client = new MySqlCommand(QueryRepres, myConnection);
                MySqlCommand myCmd_Order = new MySqlCommand(QueryCommand, myConnection);
                MySqlCommand myCmd_Builder = new MySqlCommand(QueryBuilders, myConnection);
                MySqlCommand myCmd_cmd_line = new MySqlCommand(Querycmd_line, myConnection);
                MySqlCommand myCmd_Bikes = new MySqlCommand(QueryBikes, myConnection);




                //Reader Command/Order
                MySqlDataReader myDBReaderOrder = myCmd_Order.ExecuteReader();
                DataTable myDTOrder = new DataTable();
                myDTOrder.Load(myDBReaderOrder);
                string IDClientstring = myDTOrder.Rows[manager_Part.increment]["Representative_id_rps"].ToString();
                int IDClient = Int32.Parse(IDClientstring);
                IDClient = IDClient - 1;
                myDBReaderOrder.Close();
                myDBReaderOrder = null;


                //Reader Client
                MySqlDataReader myDBReaderClient = myCmd_Client.ExecuteReader();
                DataTable myDTClients = new DataTable();
                myDTClients.Load(myDBReaderClient);
                myDBReaderClient.Close();
                myDBReaderClient = null;



                //Reader Builder
                MySqlDataReader myDBReaderBuilder = myCmd_Builder.ExecuteReader();
                DataTable myDTBuilders = new DataTable();
                myDTBuilders.Load(myDBReaderBuilder);

                int incr = 0;
                while (incr < myDTBuilders.Rows.Count)
                {
                    //foreach (DataColumn col in myDTBuilders.Columns)
                    //{


                    manager_Part.combobox_Builders.Items.Add(myDTBuilders.Rows[incr]["Builder_name"].ToString());
                    //}
                    incr += 1;

                }

                //string IDBuilderstring = myDTBuilders.Rows[increm]["idBuilder"].ToString();
                //Manager_Part.BuilderIDs.Add(Int32.Parse(IDBuilderstring));


                myDBReaderBuilder.Close();
                myDBReaderBuilder = null;

                //Reader Cmd_line
                MySqlDataReader myDBReadercmd_line = myCmd_cmd_line.ExecuteReader();
                DataTable myDTcmd_line = new DataTable();
                myDTcmd_line.Load(myDBReadercmd_line);
                string IDBikestring = myDTcmd_line.Rows[manager_Part.increment]["Bikes_idBikes"].ToString();
                int IDBike = Int32.Parse(IDBikestring);
                IDBike = IDBike - 1;

                myDBReadercmd_line.Close();
                myDBReadercmd_line = null;

                //MessageBox.Show("test 3");
                //Reader Bikes
                MySqlDataReader myDBReaderBikes = myCmd_Bikes.ExecuteReader();
                DataTable myDTbikes = new DataTable();
                myDTbikes.Load(myDBReaderBikes);


                myDBReaderBikes.Close();
                myDBReaderBikes = null;

                ;
                //MessageBox.Show("test 4");



                //Define inner texts
                manager_Part.lbl_orderdate.Text = myDTOrder.Rows[manager_Part.increment]["date_cmd"].ToString();
                manager_Part.lbl_representative.Text = myDTClients.Rows[IDClient]["Company_Name"].ToString();
                manager_Part.lbl_TotalAmount_Generate.Text = myDTcmd_line.Rows[manager_Part.increment]["qty"].ToString();
                manager_Part.lbl_model.Text = myDTbikes.Rows[IDBike]["Bikes_Model"].ToString();
                manager_Part.lbl_color.Text = myDTbikes.Rows[IDBike]["Bikes_Color"].ToString();
                manager_Part.lbl_size.Text = myDTbikes.Rows[IDBike]["Bikes_Size"].ToString();








            }
            catch
            {
                MessageBox.Show("Non connecté");
            }







        }



        private void btn_login_builder_Click(object sender, EventArgs e)
        {
            //Quel builder a ete selectionné?
            string selectedName = comboBox1.GetItemText(comboBox1.SelectedItem);
            //MessageBox.Show(selecteName);
            string selectedVal = comboBox1.GetItemText(comboBox1.SelectedValue);
            //MessageBox.Show(selecteVal);

            Builder_home homepage_Part = new Builder_home(selectedName, selectedVal);
            homepage_Part.Show();

            this.Hide();




            MySqlConnection myConnection = new MySqlConnection("database = New_db; server = pat.infolab.ecam.be;port = 63345; user = admin; pwd = prettybyke2");
            try
            {
                myConnection.Open();
                //MessageBox.Show("Connecté");
                String QueryRepres = "SELECT * FROM Representative";
                String QueryCommand = "SELECT* FROM Command";
                String QueryBuilders = "SELECT * FROM Builder";
                String Querycmd_line = "SELECT * FROM cmd_line";
                String QueryBikes = "SELECT * FROM Bikes";
                String QueryWorkingDaysHasBikes = "SELECT * FROM Working_Day_has_Bikes";


                MySqlCommand myCmd_Client = new MySqlCommand(QueryRepres, myConnection);
                MySqlCommand myCmd_Order = new MySqlCommand(QueryCommand, myConnection);
                MySqlCommand myCmd_Builder = new MySqlCommand(QueryBuilders, myConnection);
                MySqlCommand myCmd_cmd_line = new MySqlCommand(Querycmd_line, myConnection);
                MySqlCommand myCmd_Bikes = new MySqlCommand(QueryBikes, myConnection);
                MySqlCommand myCmd_WorkingDaysHasBikes = new MySqlCommand(QueryWorkingDaysHasBikes, myConnection);







                //Reader Builder
                MySqlDataReader myDBReaderBuilder = myCmd_Builder.ExecuteReader();
                DataTable myDTBuilders = new DataTable();
                myDTBuilders.Load(myDBReaderBuilder);
                myDBReaderBuilder.Close();
                myDBReaderBuilder = null;

                // Reader Working Days has bikes
                MySqlDataReader myDBReaderWorkingDaysHasBikes = myCmd_WorkingDaysHasBikes.ExecuteReader();
                DataTable myDTWorkingDaysHasBikes = new DataTable();
                myDTWorkingDaysHasBikes.Load(myDBReaderWorkingDaysHasBikes);
                myDBReaderWorkingDaysHasBikes.Close();
                myDBReaderWorkingDaysHasBikes = null;

                // Reader Bikes
                MySqlDataReader myDBReaderBikes = myCmd_Bikes.ExecuteReader();
                DataTable myDTBikes = new DataTable();
                myDTBikes.Load(myDBReaderBikes);
                myDBReaderBikes.Close();
                myDBReaderBikes = null;


                




                //Define inner texts
                // myDTBuilders.Select("SELECT Builder_name, Builder_firstname FROM New_db.Builder");

                // TODO prendre la date du jour
                String dateToday = DateTime.Today.ToString("yyyy-MM-dd");
                String test = "2004-06-22 21:19:08";
                // TODO Selectionner dans la base de donnée, les éléments lié à la date (working days has bike)
                DataRow[] result = myDTWorkingDaysHasBikes.Select("Working_Day_Date = #" + dateToday + "# and Working_Day_Builder_idBuilder = " + selectedVal);
                // Récupérer l'id des 'bikes' et les affichers sur le checklist
                foreach (DataRow data in result)
                {


                    DataRow bike = myDTBikes.Select("idBikes = " + data["Bikes_idBikes"])[0];
                    String resultBike = bike["Bikes_Color"] + " " + bike["Bikes_Model"] + " " + bike["Bikes_Size"];
                    //homepage_Part.checkedListBox1.Items.Add(resultBike);
                    homepage_Part.checkedListBox1.DisplayMember = "Text";
                    homepage_Part.checkedListBox1.ValueMember = "Value";
                    homepage_Part.checkedListBox1.Items.Add(new CheckedBoxListProps(resultBike, data["Id"].ToString()), int.Parse(data["IsDone"].ToString()) == 1);


                    //homepage_Part.checkedListBox1.SelectedValue = bike["Id"];
                    //String identifiant = (string)bike["Id"];
                    //MessageBox.Show(identifiant);
                    //homepage_Part.checkedListBox1.ValueMember = identifiant;

                    //login.comboBox1.DataSource = myDTBuilders;
                    //login.comboBox1.DisplayMember = "Builder_name";
                    //login.comboBox1.ValueMember = "idBuilder";
                }
                homepage_Part.lbl_Builder.Text = selectedName;


            }
            catch
            {
                MessageBox.Show("Non connecté");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {   
            
            this.Close();
            Homepage homepage = new Homepage();
            homepage.Show();

            
        }
    }
    public class CheckedBoxListProps
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public CheckedBoxListProps(string text, string value)
        {
            Text = text;
            Value = value;
        }
    }
    
}
