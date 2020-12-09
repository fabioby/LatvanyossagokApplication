using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        private List<City> list_city = new List<City>();
        static List<Shew> list_shew = new List<Shew>();

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=latvanyossagokdb; Uid=root; Pwd=''");
            conn.Open();

            this.FormClosed += (sender, args) => {
                if(conn != null)
                {
                    conn.Close();
                }
            };

            loadData();
        }

        void loadData()
        {
            var command = this.conn.CreateCommand();
            command.CommandText = @"SELECT * FROM varosok";
            using (var reader = command.ExecuteReader())
            {
                listBox_city.Items.Add(string.Format("{0,-40}\t{1,-40}", "Név", "Populáció"));
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    int population = reader.GetInt32("population");
                    var city = new City(id,name,population);
                    list_city.Add(city);
                    listBox_city.Items.Add(string.Format("{0,-40}\t{1,-60}", name, population));
                    shew_id.Items.Add(name);
                }
            }

            command.CommandText = @"SELECT * FROM latvanyossagok";
            using (var reader = command.ExecuteReader())
            {
                listBox_shew.Items.Add(string.Format("{0,-40}\t{1,-40}", "Név", "Ár"));
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    string description = reader.GetString("description");
                    int price = reader.GetInt32("price");
                    int city_id = reader.GetInt32("city_id");
                    var shew = new Shew(id, name, description, price, city_id);
                    list_shew.Add(shew);

                    if (price == 0)
                    {
                        listBox_shew.Items.Add(string.Format("{0,-20}\t{1,-40}", name, "Ingyenes"));
                    } else
                    {
                        listBox_shew.Items.Add(string.Format("{0,-40}\t{1,-40}", name, price));
                    }
                }
            }
        }

        private void button_city_Click(object sender, EventArgs e)
        {
            if(city_name.Text.Length > 0 && city_population.Value > 0)
            {
                foreach (City item in list_city)
                {
                    if (city_name.Text.Equals(item.getName()))
                    {
                        MessageBox.Show("Már létezik ilyen város");
                        return;
                    }
                }

                var command = this.conn.CreateCommand();
                command.CommandText = @"INSERT INTO varosok (name, population) VALUES('" + city_name.Text + "', '" + city_population.Value + "')";
                command.ExecuteNonQuery();
                var city = new City((list_city.Count + 1), city_name.Text, (int)city_population.Value);
                list_city.Add(city);
                listBox_city.Items.Add(string.Format("{0,-40}\t{1,-40}", city_name.Text, city_population.Value));
                shew_id.Items.Add(city);
                MessageBox.Show("Új város sikeresen létrehozva!");
            } else
            {
                MessageBox.Show("Tölts ki minden mezőt!");
                foreach (City item in list_city)
                {
                    
                    MessageBox.Show(""+ item.getName());
                }
            }
        }

        private void button_shew_Click(object sender, EventArgs e)
        {
            if (shew_name.Text.Length > 0 && shew_description.Text.Length > 0 && shew_id.Text.Length > 0)
            {
                foreach (Shew item in list_shew)
                {
                    if (shew_name.Text.Equals(item))
                    {
                        MessageBox.Show("Már létezik ilyen látványosság");
                        return;
                    }
                }

                int city_id = 0;
                foreach (City item in list_city)
                {
                    if (shew_id.SelectedItem.Equals(item.getId()))
                    {
                        city_id = item.getId();
                    }
                }

                var command = this.conn.CreateCommand();
                command.CommandText = @"INSERT INTO latvanyossagok (name, description, price, city_id) VALUES('" + shew_name.Text + "', '" + shew_description.Text + "', '" + shew_price.Text + "', '" + city_id + "')";
                command.ExecuteNonQuery();
                var shew = new Shew((list_shew.Count + 1), shew_name.Text, shew_description.Text, (int)shew_price.Value, city_id);
                list_shew.Add(shew);
                listBox_shew.Items.Add(string.Format("{0,-40}\t{1,-40}", shew_name.Text, city_id));
                MessageBox.Show("Új város sikeresen létrehozva!");
            }
            else
            {
                MessageBox.Show("Tölts ki minden mezőt!");
                foreach (City item in list_city)
                {

                    MessageBox.Show("" + item.getName());
                }
            }
        }


        private void delete_city_Click_1(object sender, EventArgs e)
        {
            if (listBox_city.SelectedIndex == -1 || listBox_city.SelectedIndex == 0)
            {
                MessageBox.Show("Válassz ki egy mezőt!");
            }
            else
            {
                removeData(listBox_city.SelectedIndex);
                list_city.RemoveAt(listBox_city.SelectedIndex-1);
                listBox_city.Items.RemoveAt(listBox_city.SelectedIndex);
            }
        }

        private void delete_shew_Click_1(object sender, EventArgs e)
        {
            if (listBox_shew.SelectedIndex == -1 || listBox_shew.SelectedIndex == 0)
            {
                MessageBox.Show("Válassz ki egy mezőt!");
            }
            else
            {
                removeData2(listBox_shew.SelectedIndex);
                list_shew.RemoveAt(listBox_shew.SelectedIndex);
                listBox_shew.Items.RemoveAt(listBox_shew.SelectedIndex);
            }
        }

        public void removeData(int index)
        {
            var command = this.conn.CreateCommand();
            command.CommandText = @"DELETE FROM varosok WHERE id = '" + index + "'";
            command.ExecuteNonQuery();
        }

        public void removeData2(int index)
        {
            var command = this.conn.CreateCommand();
            command.CommandText = @"DELETE FROM latvanyossagok WHERE id = '" + index + "'";
            command.ExecuteNonQuery();
        }
    }
}
