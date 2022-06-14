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
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Basket basket = new Basket();  
            basket.Show();  
        }

        private void buttonMyBasket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Basket basket = new();
            basket.Show();
        }

        private void buttonMyPtrettyBike_Click(object sender, EventArgs e)
        {
            PanelChoiceAcces.BringToFront();
            PanelChoiceAcces.Dock = DockStyle.Fill;
        }

        private void ButtonRepresAcces_Click(object sender, EventArgs e)
        {
            PanelRepresentingAcces.BringToFront();
            PanelRepresentingAcces.Dock = DockStyle.Fill;
        }

        private void ButtonLogRepresentingAcces_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new("database=New_db;server=pat.infolab.ecam.be;port=63345;userid=admin;pwd=prettybyke2;");
            try
            {
                connection.Open();
                MessageBox.Show("connexion ok");
                PanelChoixEtSpecificationCmd.BringToFront();
                PanelChoixEtSpecificationCmd.Dock = DockStyle.Fill;
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonExitRepresentingAcces_Click(object sender, EventArgs e)
        {
            PanelRepresentingAcces.SendToBack();
            PanelRepresentingAcces.Dock = DockStyle.None;
        }

        private void ButtonloadRepresenting_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new("database=New_db;server=pat.infolab.ecam.be;port=63345;userid=admin;pwd=prettybyke2;");
            try
            {
                connection.Open();
                string requete = "SELECT * FROM login";
                MySqlCommand cmd = new(requete, connection);
                MySqlDataReader? reader = null;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewLoadRepresenting.Rows.Add(reader.GetString(0), reader.GetString(1));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxMuscByk_Click(object sender, EventArgs e)
        {
            PanelChoixEtSpecificationCmd.BringToFront();
            PanelChoixEtSpecificationCmd.Dock = DockStyle.Fill;
        }

        private void pictureBoxElecByk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not availlable now but will come as soon as possible! thanks!!!");
        }

        private void ButtonSelectColorModelOrder_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                label4.BackColor = color;
            }
        }

        int Imgnum2 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            pictureBoxMuscByk.Image = imageList2.Images[Imgnum2];
            if(Imgnum2 == imageList2.Images.Count - 1)
            {
                Imgnum2 = 0;
            }
            else
            {
                Imgnum2++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage Hp = new();
            Hp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int prix = Convert.ToInt32(label5.Text);
            int quantite = Convert.ToInt32(textBox3.Text);
            int montant = prix * quantite;
            dataGridView1.Rows.Add(comboBox2.Text, textBox3.Text, comboBox1.Text, label4.BackColor, montant.ToString());
            textBox3.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
                label2.Text = "530";
            else
                label2.Text = "410";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
                //comboBox2.SelectedIndex = tabPage1.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonMyBasket_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Basket basket = new();
            basket.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
            Homepage Hp = new();
            Hp.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int prix = Convert.ToInt32(label2.Text);
            int quantite = Convert.ToInt32(textBox3.Text);
            int montant = prix * quantite;
            dataGridView1.Rows.Add(comboBox2.Text, textBox3.Text, comboBox1.Text, label4.BackColor, montant.ToString());
            textBox3.Clear();
        }

        private void ButtonSelectColorModelOrder_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                label4.BackColor = color;
            }
        }
    }
}
