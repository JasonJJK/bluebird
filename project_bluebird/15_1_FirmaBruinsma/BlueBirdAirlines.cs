using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace _15_1_FirmaBruinsma
{
    public partial class BlueBirdAirlines : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public BlueBirdAirlines()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                    data source = ..\\..\\..\\bluebird.accdb ; Persist Security Info=False;";
        }

        private void addAllChairs()
        {
            cmbStoelnummer.Items.Clear();
            OleDbConnection con = new OleDbConnection();
            connection.Open();
            OleDbDataReader dbread = null;
            string sql = "SELECT * FROM Reserveringen";
            OleDbCommand dbcom = new OleDbCommand(sql, connection);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                cmbStoelnummer.Items.Add(dbread.GetValue(1).ToString());
            }

            dbread.Close();
            connection.Close();
        }

        private void BlueBirdAirlines_Load(object sender, EventArgs e)
        {
            plekken(lbxEmptySit.Text);


            cmbStoelnummer.Items.Clear();
            OleDbConnection con = new OleDbConnection();
            connection.Open();
            OleDbDataReader dbread = null;
            string sql = "SELECT * FROM Reserveringen";
            OleDbCommand dbcom = new OleDbCommand(sql, connection);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
            cmbStoelnummer.Items.Add(dbread.GetValue(1).ToString());
            }

            dbread.Close();
            connection.Close();

            rbtnFirstClass.Checked = true;
        }
         private void plekken(string student)
         {
            lbxEmptySit.Items.Clear();
            OleDbConnection con = new OleDbConnection();
            connection.Open();
            OleDbDataReader dbread = null;
            string sql = "SELECT * FROM Reserveringen";
            OleDbCommand dbcom = new OleDbCommand(sql, connection);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
            lbxEmptySit.Items.Add(dbread.GetValue(1).ToString()
                + " " + dbread.GetValue(3).ToString());
            }

            dbread.Close();
            connection.Close();
         }
        private void lsbStoelenVrij_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbtnFirstClass.Checked = false;
            rbtnEconomyClass.Checked = false;
            rbtnBusinessClass.Checked = false;

            addAllChairs();

            try{
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM Reserveringen WHERE CurrentValue= '" + lbxEmptySit.SelectedItem.ToString().Split(' ')[1] + "'";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["CurrentValue"].ToString()=="Vrij")
                    {
                        txtNaamInvoeren.Text = "";
                    }
                    else
                    {
                        txtNaamInvoeren.Text = reader["CurrentValue"].ToString(); 
                    }
                    cmbStoelnummer.SelectedItem = lbxEmptySit.SelectedItem.ToString().Split(' ')[0];
            
                }
                connection.Close();
            }
            catch(Exception Vrij)
            {
                MessageBox.Show("Error "+ Vrij); 
                connection.Close(); 
            }
        }

        private void btnStoelVrijgeven_Click(object sender, EventArgs e)
        {   
            if (cmbStoelnummer.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteer eerst een stoelnummer");
                return;
            }
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "UPDATE Reserveringen SET CurrentValue = 'Vrij' WHERE StoelNummer = '" + cmbStoelnummer.Text + "'";
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Stoel "+cmbStoelnummer.Text + " is nu vrij");
            var form = new BlueBirdAirlines();
            form.Show();
            this.Hide();
        }






        private void btnStoelToevoegen_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE Reserveringen SET CurrentValue = '" + txtNaamInvoeren.Text +"' WHERE StoelNummer = + '" + cmbStoelnummer.Text +"'";
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("De reservering is aangemaakt.\nStoel "+ cmbStoelnummer.Text +" voor "+txtNaamInvoeren.Text);
            var form = new BlueBirdAirlines();
            form.Show();
            this.Hide();
        }

        private void rbtnFirstClass_CheckedChanged(object sender, EventArgs e)
        {
            txtNaamInvoeren.Text = "";
            cmbStoelnummer.Items.Clear();
            OleDbConnection con = new OleDbConnection();
            connection.Open();
            OleDbDataReader dbread = null;
            string sql = "SELECT * FROM Reserveringen WHERE StoelNummer = '1A' OR StoelNummer ='1B' OR StoelNummer ='1C' OR StoelNummer ='1D'";
            OleDbCommand dbcom = new OleDbCommand(sql, connection);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
            cmbStoelnummer.Items.Add(dbread.GetValue(1).ToString());
            }

            dbread.Close();
            connection.Close();
        }

        private void rbtnBusinessClass_CheckedChanged(object sender, EventArgs e)
        {
            txtNaamInvoeren.Text = "";
            cmbStoelnummer.Items.Clear();
            OleDbConnection con = new OleDbConnection();
            connection.Open();
            OleDbDataReader dbread = null;
            string sql = "SELECT * FROM Reserveringen WHERE StoelNummer = '2A' OR StoelNummer ='2B' OR StoelNummer ='2C' OR StoelNummer ='2D' OR StoelNummer ='3A' OR StoelNummer ='3B' OR StoelNummer ='3C' OR StoelNummer ='3D'";
            OleDbCommand dbcom = new OleDbCommand(sql, connection);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                cmbStoelnummer.Items.Add(dbread.GetValue(1).ToString());
            }

            dbread.Close();
            connection.Close();
        }

        private void rbtnEconomyClass_CheckedChanged(object sender, EventArgs e)
        {
            txtNaamInvoeren.Text = "";
            cmbStoelnummer.Items.Clear();
            OleDbConnection con = new OleDbConnection();
            connection.Open();
            OleDbDataReader dbread = null;
            string sql = "SELECT * FROM Reserveringen WHERE StoelNummer = '4A' OR StoelNummer ='4B' OR StoelNummer ='4C' OR StoelNummer ='4D' OR StoelNummer = '5A' OR StoelNummer ='5B' OR StoelNummer ='5C' OR StoelNummer ='5D'";
            OleDbCommand dbcom = new OleDbCommand(sql, connection);


            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                cmbStoelnummer.Items.Add(dbread.GetValue(1).ToString());
            }

            dbread.Close();
            connection.Close();
        }

        private void BlueBirdAirlines_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmbStoelnummer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
