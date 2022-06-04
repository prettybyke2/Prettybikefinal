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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //Command command = new Command();
            //command.GetCommand();

            this.Hide();
            Catalog catalog = new Catalog();    
            catalog.Show();
        }

        private void btn_employee_Click(object sender, EventArgs e)
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
                
                login.comboBox1.DataSource = myDTBuilders ;
                login.comboBox1.DisplayMember = "Builder_name";
                login.comboBox1.ValueMember = "idBuilder";


                // Ajout spécial Obama
                //login.comboBox1.Items.Add(myDTBuilders.Rows[3]["Builder_name"].ToString());
                //foreach (DataRow dr in myDTBuilders.Rows)
                //{
                //login.comboBox1.Items.Add(dr["Builder_name"]);
                //    login.comboBox1.DataSource = myDTBuilders;
                //}

            }
            catch
            {
                MessageBox.Show("Non connecté");
            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}