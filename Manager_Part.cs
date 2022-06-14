using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace Prettybike
{
    public partial class Manager_Part : Form
    {
        public Manager_Part()
        {
            InitializeComponent();
            
            BuilderIDs = this.BuilderIDs;
            DateOrders = this.DateOrders;
            AmountLeft = this.AmountLeft;
           
            
        }

        public int BuilderIDs;
        public string DateOrders;
        
        public int increment = 0;
        public int AmountLeft;
        public int SelectedAmount;
        public int btnCounter = 0;
        public bool First = true;
        public int TotalAmount;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_CurrentOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_amount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTP_Manager_from_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Manager_Click(object sender, EventArgs e)
        {

        }


        private void btn_validate_amt_Click(object sender, EventArgs e)
        {
            int AmountSelected = Int32.Parse(this.txtbox_amount.Text);
            DateOrders = this.dateTP_Manager_from.Value.ToString("yyyy-MM-dd");

            BuilderIDs = this.combobox_Builders.SelectedIndex + 1;
            SelectedAmount = AmountSelected;
            if (First == false)
            {
                AmountLeft -= SelectedAmount;
            }
            else if (First)
            {
                AmountLeft = TotalAmount - SelectedAmount;
                First = false;
            }
            this.lbl_amount_left_generate.Text = AmountLeft.ToString();
            sendToDB();
        }

        private void btn_newOrder_Click(object sender, EventArgs e)
        {

            
            

            
          
            if (AmountLeft == 0)
            {
                increment++;
                Manager_Part manager_Part = new Manager_Part();
                Newpage(manager_Part);



                this.Hide();

                manager_Part.Show();
            }
            else if (AmountLeft < 0)
            {
                MessageBox.Show("Error : you selected too much bikes");
            }
            else 
            {
                MessageBox.Show("Error : All bikes were not sent to builders");
            }
           
            



        }


        
        public int BuilderID;
        public int BikeID;
        public int OrderID; 
        public int ClientID;



        public void Newpage(Manager_Part manager_Part)
        {
            
            
            
            string connectionString = "database = New_db; server = pat.infolab.ecam.be;port = 63345; user = admin; pwd = prettybyke2";

            

            //SQL Connection Part
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            try
            {
                myConnection.Open();


                
                
                //Queries
                String QueryRepres = "SELECT * FROM Representative";
                String QueryCommand = "SELECT* FROM Command";
                String QueryBuilders = "SELECT * FROM Builder";
                String Querycmd_line = "SELECT * FROM cmd_line";
                String QueryBikes = "SELECT * FROM Bikes";

                //SQL Commands
                MySqlCommand myCmd_Client = new MySqlCommand(QueryRepres, myConnection);
                MySqlCommand myCmd_Order = new MySqlCommand(QueryCommand, myConnection);
                MySqlCommand myCmd_Builder = new MySqlCommand(QueryBuilders, myConnection);
                MySqlCommand myCmd_cmd_line = new MySqlCommand(Querycmd_line, myConnection);
                MySqlCommand myCmd_Bikes = new MySqlCommand(QueryBikes, myConnection);




                //Reader Command/Order
                MySqlDataReader myDBReaderOrder = myCmd_Order.ExecuteReader();

                DataTable myDTOrder = new DataTable();
                myDTOrder.Load(myDBReaderOrder);

                string IDClientstring = myDTOrder.Rows[increment]["Representative_id_rps"].ToString();
                int IDClient = Int32.Parse(IDClientstring);
                ClientID = IDClient;
                string IDOrderstring = myDTOrder.Rows[increment]["idCommand"].ToString();
                OrderID = Int32.Parse(IDOrderstring);
                
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
                    
                    manager_Part.combobox_Builders.Items.Add(myDTBuilders.Rows[incr]["Builder_name"].ToString());
                    
                    incr += 1;

                }



                myDBReaderBuilder.Close();
                myDBReaderBuilder = null;



                //Reader Cmd_line
                MySqlDataReader myDBReadercmd_line = myCmd_cmd_line.ExecuteReader();
                DataTable myDTcmd_line = new DataTable();
                myDTcmd_line.Load(myDBReadercmd_line);
                string IDBikestring = myDTcmd_line.Rows[increment]["Bikes_idBikes"].ToString();
                int IDBike = Int32.Parse(IDBikestring);              
                BikeID = IDBike - 1;

                myDBReadercmd_line.Close();
                myDBReadercmd_line = null;

                


                //Reader Bikes
                MySqlDataReader myDBReaderBikes = myCmd_Bikes.ExecuteReader();
                DataTable myDTbikes = new DataTable();
                myDTbikes.Load(myDBReaderBikes);


                myDBReaderBikes.Close();
                myDBReaderBikes = null;




                IDBike--;
                

                //Define inner texts
                manager_Part.lbl_orderdate.Text = myDTOrder.Rows[increment]["date_cmd"].ToString();
                manager_Part.lbl_representative.Text = myDTClients.Rows[IDClient]["Company_Name"].ToString();
                manager_Part.lbl_TotalAmount_Generate.Text = myDTcmd_line.Rows[increment]["qty"].ToString();
                TotalAmount = Int32.Parse(this.lbl_TotalAmount_Generate.Text);
                manager_Part.lbl_model.Text = myDTbikes.Rows[IDBike]["Bikes_Model"].ToString();
                manager_Part.lbl_color.Text = myDTbikes.Rows[IDBike]["Bikes_Color"].ToString();
                manager_Part.lbl_size.Text = myDTbikes.Rows[IDBike]["Bikes_Size"].ToString();

                


                
            }
            catch
            {
                MessageBox.Show("Non connecté");
            }
        }


        public void sendToDB()
        {

            //Connection with db

            string connectionString = "database = New_db; server = pat.infolab.ecam.be;port = 63345; user = admin; pwd = prettybyke2";

            MySqlConnection conn = new MySqlConnection(connectionString);

            MySqlCommand cmd_Working_Day = new MySqlCommand();
            MySqlCommand cmd_Working_Day_has_bikes = new MySqlCommand();


           
            //Queries
            cmd_Working_Day.CommandText = "INSERT INTO Working_Day (Date, Builder_idBuilder) VALUES ('" + DateOrders +"','" + BuilderIDs + "' )";
            cmd_Working_Day_has_bikes.CommandText = "INSERT INTO Working_Day_has_Bikes (Working_Day_Date, Working_Day_Builder_idBuilder, Bikes_idBikes, Command_idCommand, Command_Representative_id_rps,IsDone ) VALUES ('" + DateOrders + "', '" + BuilderIDs + "','" + BikeID + "' ,'" + OrderID + "','" + ClientID + "', 0 )";


            


            


            cmd_Working_Day.Connection = conn;
            cmd_Working_Day_has_bikes.Connection = conn;

            conn.Open();

            try
            {
                int aff = cmd_Working_Day.ExecuteNonQuery();
                

                while (SelectedAmount >0)
                {
                    
                    
                    int aff2 = cmd_Working_Day_has_bikes.ExecuteNonQuery();
                    
                    SelectedAmount -= 1;
                    
                    
                }
                

            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.ToString());   
            }
            finally
            {
                conn.Close();
            }

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            
            

        }



        public void getInfos(Manager_Part man)
        {
            int increm = man.combobox_Builders.SelectedIndex;
            increm++;
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();

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




                //TODO chercher les builders dans la base de donnée
                //TODO ajouter les builders à la combobox

                login.comboBox1.DataSource = myDTBuilders;
                login.comboBox1.DisplayMember = "Builder_name";
                login.comboBox1.ValueMember = "idBuilder";


            }
            catch
            {
                MessageBox.Show("Non connecté");
            }
        }

        
    }

}
