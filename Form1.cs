﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;

namespace EN_dizaina_risinājums_2024
{
    public partial class Form1 : Form
    {
        public string autors = "blablaa";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        static SQLiteConnection CreatConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=db_gramatas.db; Version = 3; New = True; Compress = True; ");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            autors = tb_autors.Text;
            if (tb_autors.Text == "" || tb_autors.Text == " " || tb_autors.Text == null)
            {

                MessageBox.Show("Ievadiet ludzu grāmatas autoru");
            }
            if (tb_gramatas_nosaukums.Text == "" || tb_gramatas_nosaukums.Text == " " || tb_gramatas_nosaukums.Text == null)
            {

                MessageBox.Show("Ievadiet ludzu grāmatas nosaukumu");
            }
            if (rtb_apraksts.Text == "" || rtb_apraksts.Text == " " || rtb_apraksts.Text == null)
            {

                MessageBox.Show("Ievadiet ludzu grāmatas aprakstu");
            }
            if (rtb_ilustracijas.Text == "" || rtb_ilustracijas.Text == " " || rtb_ilustracijas.Text == null)

            {

                MessageBox.Show("Ievadiet ludzu informāciju par grāmatas ilustrācijām");
            }
            if (rtb_patika.Text == "" || rtb_patika.Text == " " || rtb_patika.Text == null)
            {

                MessageBox.Show("Ievadiet ludzu kas Jums patika");
            }
            if (rtb_nepatika.Text == "" || rtb_nepatika.Text == " " || rtb_nepatika.Text == null)
            {

                MessageBox.Show("Ievadiet ludzu kas jums nepatika");
            }

            SQLiteConnection sqlite_conn;
            sqlite_conn = CreatConnection();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO dizaina_rizinajums(Gramatas_nosaukums, Gramatas_autors, apraksts, ilustacijas, nepatika, patika ) VALUES('" + tb_gramatas_nosaukums.Text + "','" + tb_autors.Text + "', '" + rtb_apraksts.Text + "','" + rtb_ilustracijas.Text + "','" + rtb_nepatika.Text + "','" + rtb_patika.Text + "');";
            sqlite_cmd.ExecuteNonQuery();

           await AuthorizeAsync();
        }

        private void b_Dzest_Click(object sender, EventArgs e)
        {
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreatConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "DELETE FROM dizaina_rizinajums WHERE ID=" + tb_dzest.Text + ";";
                sqlite_cmd.ExecuteNonQuery();
                tb_dzest.Clear();
            }
        }

        private void b_tabula_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreatConnection();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM dizaina_rizinajums";

            DataTable sTable;
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
            using (sTable = new DataTable())
            {
                sqlda.Fill(sTable);
                dgv_apskatit.DataSource = sTable;
            }
        }
        public async Task AuthorizeAsync()
        {
         

            var Webklients = new HttpClient();
            var atbilde = await Webklients.GetAsync("https://openlibrary.org/search/authors.json?q=" + autors); // tb_autors.Text;
            if (atbilde.IsSuccessStatusCode)
            {
                var AtbildesDati = await atbilde.Content.ReadAsStringAsync();
                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(AtbildesDati);


                rtb_zanri.Text = (data.docs[0].top_subjects);
                //rtb_zanri.Text = (data[i].docs[0]);

                


            }
            Console.ReadLine();
        }
    }
}
