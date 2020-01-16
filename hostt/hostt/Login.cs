using FileTransferProtocolLib;
using FTPManager;
using hostt.Properties;
using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace hostt
{
    public partial class Login : Form
    {


        FTPManagerClass client;

        FTP manager;

        string result;

        string hostingname = "  onlineitfaiye-001 ";

        string hostingpassword = " e-yangin2018 ";

        string host = "ftp://onlineitfaiye-001@ftp-eu.site4now.net/cloneGit";

        public Login()
        {
            InitializeComponent();



        }


        private void Login_Load(object sender, EventArgs e)
        {

            textBox1.Text = Properties.Settings.Default.username.ToString();
            textBox2.Text = Properties.Settings.Default.password.ToString();

            if (textBox1.Text.Count() > 0)
            {
                checkBox1.Checked = true;

            }
        }

        private async void button9_Click_1(object sender, EventArgs e)
        {

            Manager mng = new Manager();

            mng.username = textBox1.Text;

            string name = textBox1.Text;

            string pass = textBox2.Text;

            

            var clients = new HttpClient();



            clients.BaseAddress = new Uri("http://onlineitfaiye-001-site9.itempurl.com/");

            HttpResponseMessage response = await clients.GetAsync("api/customer?customerid=" + name + "&password=" + pass);

            string result = await response.Content.ReadAsStringAsync();

            MessageBox.Show(result);

            this.result = result;

            if (result == "{\"Message\":\"Kullanıcı Girişi Başarılı\"}")
            {




                client = new FTPManagerClass(hostingname, hostingpassword, host);

                manager = new FTP(host, hostingname, hostingpassword);






                if (checkBox1.Checked)
                {
                    Properties.Settings.Default.username = textBox1.Text;
                    Properties.Settings.Default.password = textBox2.Text;
                    Properties.Settings.Default.hatirla = true;




                }
                else
                {
                    Properties.Settings.Default.username = "";
                    Properties.Settings.Default.password = "";
                    Properties.Settings.Default.hatirla = false;

                }

                Settings.Default.Save();

             

                this.Hide();

                 mng.Show();

               
               



                

                

            }



        }
    }
}
