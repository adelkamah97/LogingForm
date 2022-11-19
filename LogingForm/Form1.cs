using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace LogingForm
{
    public partial class Form1 : Form
    {
        SqlConnection  con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        

        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=Adel-PC;Initial Catalog=loginTest;User ID=adel;Password=adel";


        }

        Color select_color = Color.FromArgb(46, 49,49);
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel2.BackColor = select_color;
            Loginbtn.BackColor = select_color;
            Loginbtn.ForeColor = Color.White;           
            Registrebtn.BackColor = Color.White;
            Registrebtn.ForeColor = select_color;
        }

        private void Registrebtn_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.BackColor = select_color;
            Registrebtn.BackColor = select_color;
            Registrebtn.ForeColor = Color.White;
            Loginbtn.ForeColor = select_color;
            Loginbtn.BackColor = Color.White;
        }

        private void confirmbtn2_Click(object sender, EventArgs e)
        {
            con.Open();
            string userid = usertxt.Text;
            string password = passwordtxt2.Text;
            SqlCommand cmd = new SqlCommand("select userName,password from authe where userName='" + userid + "'and password='" + password + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess");               
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();

        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            string FirstName = FirstNametxt.Text;
            string LastName = LastNametxt.Text;
            string Username = UserNametxt.Text;
            string Password = Passwordtxt.Text;
            string Passwordd = confirmtxt.Text;
            
            if (Password == Passwordd)
            {
                string sql = "insert into authe(firstName,lastName,userName,password) " +
                    "values(@FirstName,@LastName,@Username,@Password)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);

                MessageBox.Show("User Added");
                cmd.ExecuteNonQuery();

                FirstNametxt.Clear();
                LastNametxt.Clear();
                UserNametxt.Clear();
                Passwordtxt.Clear();
                confirmtxt.Clear();
                con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
            
            


        }
    }
}