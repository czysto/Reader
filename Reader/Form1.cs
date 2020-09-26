using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Reader
{
    public partial class DataReader : Form
    {
        public DataReader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=.\enova;Initial Catalog=TEST;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output;

            ArrayList daneKontrahenciNazwa = new ArrayList();

            sql = "Select Nazwa from dbo.Kontrahenci";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                daneKontrahenciNazwa.Add(dataReader.GetValue(0));
                //Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }

            daneKontrahenciNazwa.Sort();

            Output = string.Join(Environment.NewLine, daneKontrahenciNazwa.ToArray());

            MessageBox.Show("Kontrahenci: " + "\n" + Output);

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'tESTDataSet1.Towary' . Możesz go przenieść lub usunąć.
            this.towaryTableAdapter.Fill(this.tESTDataSet1.Towary);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'tESTDataSet.Kontrahenci' . Możesz go przenieść lub usunąć.
            this.kontrahenciTableAdapter.Fill(this.tESTDataSet.Kontrahenci);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=.\enova;Initial Catalog=TEST;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "Select Nazwa from dbo.Towary";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "\n";
            }

            MessageBox.Show("Towary: " + "\n" + Output);

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=.\enova;Initial Catalog=TEST;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output;

            ArrayList daneKontrahenciNazwa = new ArrayList();

            sql = "Select NIP from dbo.Kontrahenci";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                daneKontrahenciNazwa.Add(dataReader.GetValue(0));
                //Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }

            daneKontrahenciNazwa.Sort();

            Output = string.Join(Environment.NewLine, daneKontrahenciNazwa.ToArray());

            MessageBox.Show("Kontrahenci: " + "\n" + Output);

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}
