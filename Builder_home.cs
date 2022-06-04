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
    public partial class Builder_home : Form
    {
        private string currentName;
        private string currentValue;
        public Builder_home(string currentName, string currentValue)
        {
            InitializeComponent();
            this.currentName = currentName;
            this.currentValue = currentValue;
        }

        private void lbl_Builder_Click(object sender, EventArgs e)
        {

        }

        private void btn_piecies_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pieces_builder pieces = new Pieces_builder(this.currentName, this.currentValue);
            pieces.Show();



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
                String QueryParts = "SELECT * FROM Parts";


                MySqlCommand myCmd_Client = new MySqlCommand(QueryRepres, myConnection);
                MySqlCommand myCmd_Order = new MySqlCommand(QueryCommand, myConnection);
                MySqlCommand myCmd_Builder = new MySqlCommand(QueryBuilders, myConnection);
                MySqlCommand myCmd_cmd_line = new MySqlCommand(Querycmd_line, myConnection);
                MySqlCommand myCmd_Bikes = new MySqlCommand(QueryBikes, myConnection);
                MySqlCommand myCmd_WorkingDaysHasBikes = new MySqlCommand(QueryWorkingDaysHasBikes, myConnection);
                MySqlCommand myCmd_Parts = new MySqlCommand(QueryParts, myConnection);







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

                //Reader Parts
                MySqlDataReader myDBParts = myCmd_Parts.ExecuteReader();
                DataTable myDTParts = new DataTable();
                myDTParts.Load(myDBParts);
                myDBParts.Close();
                myDBParts = null;

                //MessageBox.Show("test 4");



                //Define inner texts
                // myDTBuilders.Select("SELECT Builder_name, Builder_firstname FROM New_db.Builder");


                pieces.piece1.Text = myDTParts.Rows[0]["Parts_Name"].ToString();
                pieces.label2.Text = myDTParts.Rows[1]["Parts_Name"].ToString();
                pieces.label3.Text = myDTParts.Rows[2]["Parts_Name"].ToString();
                pieces.label4.Text = myDTParts.Rows[3]["Parts_Name"].ToString();
                pieces.label5.Text = myDTParts.Rows[4]["Parts_Name"].ToString();

            }
            catch
            {
                MessageBox.Show("Non connecté");
            }
        }
      
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO connecter à la base de données Working Days
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
                String QueryParts = "SELECT * FROM Parts";
                


                MySqlCommand myCmd_Client = new MySqlCommand(QueryRepres, myConnection);
                MySqlCommand myCmd_Order = new MySqlCommand(QueryCommand, myConnection);
                MySqlCommand myCmd_Builder = new MySqlCommand(QueryBuilders, myConnection);
                MySqlCommand myCmd_cmd_line = new MySqlCommand(Querycmd_line, myConnection);
                MySqlCommand myCmd_Bikes = new MySqlCommand(QueryBikes, myConnection);
                MySqlCommand myCmd_WorkingDaysHasBikes = new MySqlCommand(QueryWorkingDaysHasBikes, myConnection);
                MySqlCommand myCmd_Parts = new MySqlCommand(QueryParts, myConnection);


                // Reader Working Days has bikes
                MySqlDataReader myDBReaderWorkingDaysHasBikes = myCmd_WorkingDaysHasBikes.ExecuteReader();
                DataTable myDTWorkingDaysHasBikes = new DataTable();
                myDTWorkingDaysHasBikes.Load(myDBReaderWorkingDaysHasBikes);
                myDBReaderWorkingDaysHasBikes.Close();
                myDBReaderWorkingDaysHasBikes = null;


                // TODO récupérer l'objet lié à l'index changé dans la db
                // TODO Changer la valeur dans la db => result["isDone"] = 1
                foreach (CheckedBoxListProps item in checkedListBox1.CheckedItems)
                {
                    //MessageBox.Show(item.Text);
                    //MessageBox.Show(item.Value); 
                    String Queryinsertdataworkingdayhasbike = "UPDATE Working_Day_has_Bikes SET IsDone = 1 WHERE Id ="+item.Value;
                    MySqlCommand myCmd_Isdone = new MySqlCommand(Queryinsertdataworkingdayhasbike, myConnection);
                    int value = myCmd_Isdone.ExecuteNonQuery();
                    //MessageBox.Show(value.ToString());
                    //MessageBox.Show(item.Value);
                }
                myConnection.Close();
            }
            catch
            {
                MessageBox.Show("Non connecté");
            }
            
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
