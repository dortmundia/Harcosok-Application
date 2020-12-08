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

namespace HarcosokApplication
{
    /*
   CREATE TABLE IF NOT EXISTS `cs_harcosok`.`harcosok` ( `id` INT NOT NULL AUTO_INCREMENT , `nev` VARCHAR(32) NOT NULL , `letrehozas` DATE NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;);

    CREATE TABLE IF NOT EXISTS `cs_harcosok`.`kepessegek` ( `id` INT NOT NULL AUTO_INCREMENT , `nev` VARCHAR(32) NOT NULL , `leiras` VARCHAR(250) NOT NULL , `harcos_id` INT NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;

        */
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "cs_harcosok";
            sb.CharacterSet = "utf8";

            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
                MessageBox.Show("sikeres kapcsolat");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("sikertelen kapcsolat");
                return;
            }

            tabla();
            myupdate();


            conn.Close();
        }

        private void tabla()
        {

            sql.CommandText = "  CREATE TABLE IF NOT EXISTS `cs_harcosok`.`harcosok` ( `id` INT NOT NULL AUTO_INCREMENT , `nev` VARCHAR(32) NOT NULL , `letrehozas` DATE NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB);" 
                +
                              "  CREATE TABLE IF NOT EXISTS `cs_harcosok`.`kepessegek` ( `id` INT NOT NULL AUTO_INCREMENT, `nev` VARCHAR(32) NOT NULL, `leiras` VARCHAR(250) NOT NULL, `harcos_id` INT NOT NULL , PRIMARY KEY(`id`)) ENGINE = InnoDB;";
            
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            sql.CommandText = "SELECT id,nev FROM harcosok WHERE 1;";

            MySqlDataReader dr = sql.ExecuteReader();
            string nev = textBox_harcosNeve.Text;
                DateTime datum = DateTime.Now; 
                while (dr.Read())
                {
                    if (dr.GetString("nev") == nev)
                    {
                        MessageBox.Show("ilyen nevű harcos már létezik");   
                    }
                    else
                    {
                        sql.CommandText = " INSERT INTO `harcosok` (`nev`, `letrehozas`) VALUES ( "+nev+","+datum+" )";

                        MessageBox.Show("Harcos sikeresen hozzáadva");
                    }
                }
                myupdate();
            
        }

        private void myupdate()
        {
            //TODO:combobox + listbox frissitése

            comboBox_hasznalo.Items.Clear();
            MySqlDataReader dr = sql.ExecuteReader();
                sql.CommandText = "SELECT id, nev,letrehozas FROM harcosok WHERE 1;";
            while(dr.Read()) { 

                comboBox_hasznalo.Items.Add(dr.GetInt32("id"));
            }

            listBox_harcosok.Items.Clear();
            listBox_kepessegek.Items.Clear();

            string item = dr.GetString("nev") +" - " + Convert.ToString(dr.GetDateTime("letrehozas"));
            while (dr.Read())
            {
                listBox_harcosok.Items.Add(item);
            }



            sql.CommandText = "SELECT id, nev FROM kepessegek WHERE ;";
            while (dr.Read())
            {
                listBox_kepessegek.Items.Add(dr.GetString("nev"));
            }

        }

        private void button_Add_Click(object sender, EventArgs e)
        {



            myupdate();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {




            myupdate();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {



            myupdate();
        }
    }
    
}


