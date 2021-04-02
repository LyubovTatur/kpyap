using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace lab25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection("data source=MyDB.db");
            sQLiteConnection.Open();
            string query = "select * from about_good";
            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, sQLiteConnection);
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(sQLiteCommand);
            sQLiteDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            //bindingNavigator1.BindingSource = new BindingSource(dataGridView1.DataSource, "about_good");
            sQLiteConnection.Close();

        }
    }
}
