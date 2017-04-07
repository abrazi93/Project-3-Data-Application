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
                            name.Text = reader.GetString(1);
                            type.Text = reader.GetString(3);
                            aantal_plaatsen.Text = reader.GetString(4);
                            adres.Text = reader.GetString(5);
                            plaats.Text = reader.GetString(6);
                            gebied.Text = reader.GetString(7);
                        }
                    }
                }
            }
        }
    }
}
