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
            grid.Clear();
            grid1.Clear();
            grid2.Clear();
            grid3.Clear();
            grid4.Clear();
            grid5.Clear();
            using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM parking where \"NAME\" = '" + name.Text + "' or \"ADRES\" = '" + adres.Text + "' or \"TYPE\" = '" + type.Text + "' or \"GEBIED\" = '" + gebied.Text + "' or \"PLAATS\" = '" + plaats.Text + "';";
                    Console.WriteLine("SELECT * FROM parking where \"NAME\" = '" + name.Text + "' or \"ADRES\" = '" + adres.Text + "' or \"TYPE\" = '" + type.Text + "' or \"GEBIED\" = '" + gebied.Text + "' or \"PLAATS\" = '" + plaats.Text + "';");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.ValueMember = reader.GetString(1) + "\r\n";
                            grid.Text += reader.GetString(1) + "\r\n";
                            grid1.Text += reader.GetString(3) + "\r\n";
                            grid2.Text += reader.GetString(4) + "\r\n";
                            grid3.Text += reader.GetString(5) + "\r\n";
                            grid4.Text += reader.GetString(6) + "\r\n";
                            grid5.Text += reader.GetString(7) + "\r\n";
                        }
                    }
                }
            }
        }

        private void annuleren_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void grid4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
