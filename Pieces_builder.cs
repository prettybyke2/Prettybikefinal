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
    public partial class Pieces_builder : Form
    {
        private string currentName;
        private string currentValue;
        public Pieces_builder(string currentName, string currentValue)
        {
            InitializeComponent();
            this.currentName = currentName;
            this.currentValue = currentValue;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Builder_home f2 = new(this.currentName, this.currentValue) ;
            f2.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Pieces_builder_Load(object sender, EventArgs e)
        {

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
           

        }

        private void Piece1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Builder_home homepage_Part = new(this.currentName,this.currentValue) ;
            homepage_Part.Show();

            this.Hide();




            MySqlConnection myConnection = new("database = New_db; server = pat.infolab.ecam.be;port = 63345; user = admin; pwd = prettybyke2");
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


                MySqlCommand myCmd_Client = new(QueryRepres, myConnection);
                MySqlCommand myCmd_Order = new(QueryCommand, myConnection);
                MySqlCommand myCmd_Builder = new(QueryBuilders, myConnection);
                MySqlCommand myCmd_cmd_line = new(Querycmd_line, myConnection);
                MySqlCommand myCmd_Bikes = new(QueryBikes, myConnection);
                MySqlCommand myCmd_WorkingDaysHasBikes = new(QueryWorkingDaysHasBikes, myConnection);







                //Reader Builder
                MySqlDataReader? myDBReaderBuilder = myCmd_Builder.ExecuteReader();
                DataTable myDTBuilders = new();
                myDTBuilders.Load(myDBReaderBuilder);
                myDBReaderBuilder.Close();
                myDBReaderBuilder = null;

                // Reader Working Days has bikes
                MySqlDataReader? myDBReaderWorkingDaysHasBikes = myCmd_WorkingDaysHasBikes.ExecuteReader();
                DataTable myDTWorkingDaysHasBikes = new();
                myDTWorkingDaysHasBikes.Load(myDBReaderWorkingDaysHasBikes);
                myDBReaderWorkingDaysHasBikes.Close();
                myDBReaderWorkingDaysHasBikes = null;

                // Reader Bikes
                MySqlDataReader? myDBReaderBikes = myCmd_Bikes.ExecuteReader();
                DataTable myDTBikes = new();
                myDTBikes.Load(myDBReaderBikes);
                myDBReaderBikes.Close();
                myDBReaderBikes = null;


                //Quel builder a ete selectionné?
                // string selecteName = comboBox1.GetItemText(comboBox1.SelectedItem);
                //MessageBox.Show(selecteName);
                // string selecteVal = comboBox1.GetItemText(comboBox1.SelectedValue);
                //MessageBox.Show(selecteVal);




                //Define inner texts
                // myDTBuilders.Select("SELECT Builder_name, Builder_firstname FROM New_db.Builder");

                // TODO prendre la date du jour
                String dateToday = DateTime.Today.ToString("yyyy-MM-dd");
                String test = "2031-05-22";
                // TODO Selectionner dans la base de donnée, les éléments lié à la date (working days has bike)
                DataRow[] result = myDTWorkingDaysHasBikes.Select("Working_Day_Date = #" + test + "# and Working_Day_Builder_idBuilder = " + this.currentValue);
                // Récupérer l'id des 'bikes' et les affichers sur le checklist
                foreach (DataRow data in result)
                {


                    DataRow bike = myDTBikes.Select("idBikes = " + data["Bikes_idBikes"])[0];
                    String resultBike = bike["Bikes_Color"] + " " + bike["Bikes_Model"] + " " + bike["Bikes_Size"];
                    //homepage_Part.checkedListBox1.Items.Add(resultBike);
                    homepage_Part.checkedListBox1.DisplayMember = "Text";
                    homepage_Part.checkedListBox1.ValueMember = "Value";
                    homepage_Part.checkedListBox1.Items.Add(new CheckedBoxListProps(resultBike, data["Id"].ToString()), int.Parse(data["IsDone"].ToString()) == 1);
                    
                }
                homepage_Part.lbl_Builder.Text = this.currentName ;


            }
            catch
            {
                MessageBox.Show("Non connecté");
            }

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Label1_Click_3(object sender, EventArgs e)
        {

        }

        private void Label1_Click_4(object sender, EventArgs e)
        {

        }
    }
}
