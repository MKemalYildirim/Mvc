using FileTransferProtocolLib;
using FTPManager;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hostt

{
    public partial class Manager : Form
    {

        FTPManagerClass client;

        FTP manager;

       public string username;

        string result;

        string hostingname = "  onlineitfaiye-001 ";

        string hostingpassword = " e-yangin2018 ";

        string host = "ftp://onlineitfaiye-001@ftp-eu.site4now.net/cloneGit";





        public Manager()
        {
            InitializeComponent();




        }

      
        private void button6_Click(object sender, EventArgs e)
        {
            manager.CreateDirectory(textBox4.Text);
            RefreshGet();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            manager.Delete(textBox11.Text);
            RefreshGet();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            manager.ReName(textBox10.Text, textBox9.Text);
            RefreshGet();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox5.Text = ofd.FileName;
                textBox6.Text = ofd.SafeFileName;
            }
            RefreshGet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager.DownloadFile(textBox7.Text, textBox8.Text);
            RefreshGet();
        }

        private async void button4_Click(object sender, EventArgs e)
        {

            await Task.Run(() =>  manager.UploadFile(textBox5.Text, textBox6.Text));


            RefreshGet();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string ext = textBox7.Text.Substring(textBox7.Text.IndexOf("."));
            sfd.Filter = "Download file extension(" + ext + ")|*" + ext;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox8.Text = sfd.FileName;
            }
            RefreshGet();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {

            Login login = new Login();

            client = new FTPManagerClass(hostingname, hostingpassword, host);

            manager = new FTP(host, hostingname, hostingpassword);

            dataGridView1.Rows.Clear();

            string[] files = manager.FilesOnServer("");

            int i = 0;

            foreach (string filename in files)
            {

                if (filename == username)
                {
                    i = 1;
                }


                dataGridView1.Rows.Add(filename);

             
            }


            if (i==0)
            {
                manager.CreateDirectory(username);
            }


            RefreshGet();


        }


        public void RefreshGet() {

            host = "ftp://onlineitfaiye-001@ftp-eu.site4now.net/cloneGit/" + username;

            manager = new FTP(host, hostingname, hostingpassword);

            dataGridView1.Rows.Clear();

            string[] files = manager.FilesOnServer("");


            foreach (string filename in files)
            {

              

              dataGridView1.Rows.Add(filename);


            }


        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex]!=null)

            {

                string Satir = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                textBox7.Text = Satir;
                textBox10.Text = Satir;
                textBox11.Text = Satir;

            }

      
        }
    }
}
