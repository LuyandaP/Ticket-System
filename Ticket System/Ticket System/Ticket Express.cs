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

namespace Ticket_System
{
    public partial class Login : Form
    {
        int id;
        string name;
        string age;
        string stage;
        string stadium;
        string dates;
        string seats;
        string outlet;
        int ticketA;
        int ticketN;
        int total;
        string ConString = "server=localhost;user id=root;database=ticketdb";
        MySqlConnection cs;
        MySqlCommand cm;
        MySqlDataReader r;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            groupBox1.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Senior" && textBox2.Text == "Spass")
            {
                panel1.Hide();
                panel2.Show();
                MessageBox.Show("Welcome Senior");
            }
            else if (textBox1.Text == "Junior" && textBox2.Text == "Jpass")
            {
                panel1.Hide();
                panel2.Show();
                MessageBox.Show("Welcome Junior");
            }
            else if (textBox1.Text == "Checkpoint" && textBox2.Text == "Entrance")
            {
                panel1.Hide();
                panel6.Show();
            }
            else
            {
                label17.Text = "Incorrect username or password";
            }
            for (int i = 0; i < 101; i++)
            {
                comboBox1.Items.Add(i);
            }
            
        }

        private void btnToGrp_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt32(comboBox1.Text) < 14 && System.Convert.ToInt32(comboBox1.Text) > 0)
            {
                if (textBox1.Text == "Junior" && textBox2.Text == "Jpass")
                {
                    panel2.Hide();
                    groupBox1.Show();
                }
                else
                {
                    panel2.Hide();
                    panel3.Show();
                }
                age = "Child";
            }
            else
            {
                panel2.Hide();
                panel3.Show();
                age = "Adult";
            }
            id = System.Convert.ToInt32(textBox3.Text);
            name = System.Convert.ToString(textBox4.Text);
           
        }

        private void btnPnl3Next_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Add("VIP");
            comboBox4.Items.Add("Field Side");
            comboBox4.Items.Add("General");
            comboBox5.Items.Add("Checkers");
            comboBox5.Items.Add("Edgars");
            comboBox5.Items.Add("Jet");

            if (radioButton1.Checked)
            {
                comboBox2.Items.Add("Loftus Versfeld Stadium");
                comboBox2.Items.Add("Nelson Mandela Bay Stadium");
                comboBox2.Items.Add("Moses Mabida Stadium");
                comboBox3.Items.Add("July 1 - July 16");
                comboBox3.Items.Add("July 17 - August 1");
                stage = "Group";
                panel3.Hide();
                panel4.Show();
            }
            else if (radioButton2.Checked)
            {
                comboBox3.Items.Add("August 7");
                comboBox3.Items.Add("August 8");
                comboBox3.Items.Add("August 9");
                comboBox2.Items.Add("Kings Park Stadium");
                comboBox2.Items.Add("Cape Town Stadium");
                stage = "Semi";
                panel3.Hide();
                panel4.Show();
            }
            else if (radioButton3.Checked)
            {
                comboBox3.Items.Add("August 2");
                comboBox3.Items.Add("August 3");
                comboBox3.Items.Add("August 4");
                comboBox3.Items.Add("August 5");
                comboBox3.Items.Add("August 6");
                comboBox2.Items.Add("Mmabatho Stadium");
                comboBox2.Items.Add("Ellis Park Stadium");
                comboBox2.Items.Add("Odi Stadium");
                stage = "Quarter";
                panel3.Hide();
                panel4.Show();
            }
            else if (radioButton4.Checked)
            {
                comboBox3.Items.Add("August 10");
                comboBox2.Items.Add("FNB Stadium");
                stage = "Final";
                panel3.Hide();
                panel4.Show();
            }
            else
            {
                label18.Text = "Please select one";
            }
            
        }

        private void btnPrchBack_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            if (System.Convert.ToInt32(comboBox1.Text) < 14 && System.Convert.ToInt32(comboBox1.Text) > 0)
            {
                if (textBox1.Text == "Junior" && textBox2.Text == "Jpass")
                {
                    groupBox1.Show();
                }
                else
                {
                    panel3.Show();
                }
            }
            else
            {
                panel3.Show();
            }
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
        }

        private void btnGrpNext_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Add("VIP");
            comboBox4.Items.Add("Field Side");
            comboBox4.Items.Add("General");
            comboBox5.Items.Add("Checkers");
            comboBox5.Items.Add("Edgars");
            comboBox5.Items.Add("Jet");

            if (radioButton5.Checked)
            {
                comboBox2.Items.Add("Loftus Versfeld Stadium");
                comboBox2.Items.Add("Nelson Mandela Bay Stadium");
                comboBox2.Items.Add("Moses Mabida Stadium");
                comboBox3.Items.Add("July 1 - July 16");
                comboBox3.Items.Add("July 17 - August 1");
                stage = "Group";
                groupBox1.Hide();
                panel4.Show();
            }
            else if (radioButton6.Checked)
            {
                comboBox3.Items.Add("August 2");
                comboBox3.Items.Add("August 3");
                comboBox3.Items.Add("August 4");
                comboBox3.Items.Add("August 5");
                comboBox3.Items.Add("August 6");
                comboBox2.Items.Add("Mmabatho Stadium");
                comboBox2.Items.Add("Ellis Park Stadium");
                comboBox2.Items.Add("Odi Stadium");
                stage = "Quarter";
                groupBox1.Hide();
                panel4.Show();
            }
            else
            {
                label19.Text = "Please select one";
            }
        }

        private void btnPnl3Back_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel2.Show();
        }

        private void btnChldBack_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            panel2.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
            label16.Text = "R0";
            label7.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            comboBox3.Text = "";
            comboBox3.Items.Clear();
            comboBox4.Text = "";
            comboBox4.Items.Clear();
            panel4.Hide();
            panel2.Show();
        }

        private void btnSgnOut_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
            label16.Text = "R0";
            label7.Text = "";
            comboBox1.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            panel2.Hide();
            panel1.Show();
        }

        private void btnPrch_Click(object sender, EventArgs e)
        {
            stadium = comboBox2.Text;
            dates = comboBox3.Text;
            seats = comboBox4.Text;
            outlet = comboBox5.Text;
            ticketA = System.Convert.ToInt32(numericUpDown1.Value);
            Random ran = new Random();
            ticketN = ran.Next(10000, 50000);
            label7.Text = $"Your Ticket number is {ticketN}";

            cs = new MySqlConnection(ConString);

            string sql1 = $"INSERT INTO tickets(ID, Name, Age, Stage, Stadium, Dates, Seats, Outlet, TicketAmount, TicketNumber) VALUES('{id}', '{name}', '{age}', '{stage}', '{stadium}', '{dates}', '{seats}', '{outlet}', '{ticketA}', '{ticketN}')";

            cs.Open();

            cm = new MySqlCommand(sql1, cs);
 
            int insert = System.Convert.ToInt32(cm.ExecuteScalar());

            cs.Close();
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM tickets WHERE TicketNumber={textBox5.Text}";
            cs = new MySqlConnection(ConString);

            cs.Open();

            cm = new MySqlCommand(sql, cs);

            r = cm.ExecuteReader();

            if (r.Read())
            {
                id = r.GetInt32("ID");
                name = r.GetString("Name");
                age = r.GetString("Age");
                stage = r.GetString("Stage");
                stadium = r.GetString("Stadium");
                dates = r.GetString("Dates");
                seats = r.GetString("Seats");
                outlet = r.GetString("Outlet");
                ticketA = r.GetInt32("TicketAmount");
            }
            else
            {
                label10.Text = "No Match!";
            }

            cs.Close();

            label10.Text = $"ID: {id}";
            label11.Text = $"Name: {name}";
            label12.Text = $"Age: {age}";
            label13.Text = $"Stage: {stage}";
            label14.Text = $"Stadium: {stadium}";
            label15.Text = $"Dates: {dates}";
            label21.Text = $"Seats: {seats}";
            label24.Text = $"Purchased from {outlet}";
            label26.Text = $"Amount of Tickets: {ticketA}";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "VIP" && stage == "Group" && age == "Adult")
            {
                label16.Text = $"R{total= 300 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "Field Side" && stage == "Group" && age == "Adult")
            {
                label16.Text = $"R{total = 150 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "General" && stage == "Group" && age == "Adult")
            {
                label16.Text = $"R{total = 50 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "VIP" && stage == "Group" && age == "Child")
            {
                label16.Text = $"R{total = 275 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "Field Side" && stage == "Group" && age == "Child")
            {
                label16.Text = $"R{total = 125 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "General" && stage == "Group" && age == "Child")
            {
                label16.Text = $"R{total = 30 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "VIP" && stage == "Quarter" && age == "Adult")
            {
                label16.Text = $"R{total = 325 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "Field Side" && stage == "Quarter" && age == "Adult")
            {
                label16.Text = $"R{total = 175 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "General" && stage == "Quarter" && age == "Adult")
            {
                label16.Text = $"R{total = 75 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "VIP" && stage == "Quarter" && age == "Child")
            {
                label16.Text = $"R{total = 300 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "Field Side" && stage == "Quarter" && age == "Child")
            {
                label16.Text = $"R{total = 150 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "General" && stage == "Quarter" && age == "Child")
            {
                label16.Text = $"R{total = 60 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "VIP" && stage == "Semi" && age == "Adult")
            {
                label16.Text = $"R{total = 350 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "Field Side" && stage == "Semi" && age == "Adult")
            {
                label16.Text = $"R{total = 200 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "General" && stage == "Semi" && age == "Adult")
            {
                label16.Text = $"R{total = 100 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "VIP" && stage == "Semi" && age == "Child")
            {
                label16.Text = $"R{total = 325 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "Field Side" && stage == "Semi" && age == "Child")
            {
                label16.Text = $"R{total = 175 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "General" && stage == "Semi" && age == "Child")
            {
                label16.Text = $"R{total = 85 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "VIP" && stage == "Final" && age == "Adult")
            {
                label16.Text = $"R{total= 400 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "Field Side" && stage == "Final" && age == "Adult")
            {
                label16.Text = $"R{total = 250 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "General" && stage == "Final" && age == "Adult")
            {
                label16.Text = $"R{total = 150 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "VIP" && stage == "Final" && age == "Child")
            {
                label16.Text = $"R{total = 375 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "Field Side" && stage == "Final" && age == "Child")
            {
                label16.Text = $"R{total = 225 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else if (comboBox4.Text == "General" && stage == "Final" && age == "Child")
            {
                label16.Text = $"R{total = 125 * System.Convert.ToInt32(numericUpDown1.Value)}";
            }
            else
            {
                label16.Text = "";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label16.Text = $"R{total * System.Convert.ToInt32(numericUpDown1.Value)}";
        }

        private void btnSrchID_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            panel6.Hide();
            panel5.Show();
            dataGridView1.DataSource = null;
        }

        private void btnSrchTN_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            panel5.Hide();
            panel6.Show();
        }

        private void btnSrchDB_Click(object sender, EventArgs e)
        {
            cs = new MySqlConnection(ConString);
            string sql = $"SELECT * FROM tickets WHERE ID={textBox6.Text}";
            MySqlDataAdapter ad = new MySqlDataAdapter(sql, cs);

            cs.Open();

            DataTable data = new DataTable();
            ad.Fill(data);
          
            cs.Close();
            dataGridView1.DataSource = data;

        }

        private void btnClearT_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox5.Focus();
            label21.Text = "";
            label24.Text = "";
            label26.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
        }
    }
}
