using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DatabaseForm
{
    public partial class DatabaseFormOphalen : Form
    {
        public DatabaseFormOphalen()
        {
            InitializeComponent();
        }

        private void ophalen_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM parking where \"NAME\" = '" + comboBox1.SelectedItem + "' or \"TYPE\" = '" + comboBox2.SelectedItem + "' or \"AANTAL_PLEKKEN\" = '" + comboBox3.SelectedItem + "' or \"ADRES\" = '" + comboBox4.SelectedItem + "' or \"PLAATS\" = '" + comboBox5.SelectedItem + "' or \"GEBIED\" = '" + comboBox6.SelectedItem + "';";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox1.Text += reader.GetString(1) + "\r\n";
                            textBox2.Text += reader.GetString(3) + "\r\n";
                            textBox3.Text += reader.GetString(4) + "\r\n";
                            textBox4.Text += reader.GetString(5) + "\r\n";
                            textBox5.Text += reader.GetString(6) + "\r\n";
                            textBox6.Text += reader.GetString(7) + "\r\n";
                        }
                    }
                }
            }
        }

        private void DatabaseFormOphalen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_RotterdamDataSet.parking' table. You can move, or remove it, as needed.
            this.parkingTableAdapter.Fill(this.dataset_RotterdamDataSet.parking);

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.parkingTableAdapter.FillBy(this.dataset_RotterdamDataSet.parking);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
