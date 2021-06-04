using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Management
{
    public partial class Login : Form
    {
        public MySqlDb mySqlDb
        {
            get; set;
        }
        public Login()
        {
            InitializeComponent();
        }


        private void BtnConnect_Click(object sender, EventArgs e)
        {
            string connStr = String.Format(
              "server={0};user={1};database={2};port=3306;password={3}"
              , "192.168.56.1"
              , this.textBox1.Text      //"root"
              , "php_db"
              , this.textBox2.Text         //"1234"
               );

                mySqlDb = new MySqlDb(connStr);

                if (mySqlDb?.Open() == true)
                {
                    this.Dispose();
                    MainForm MF = new MainForm();
                    MF.mySqlDb = this.mySqlDb;
                    MF.ShowDialog();
                }
                else
                {
                MessageBox.Show("등록되지 않은 관리자이거나, 비밀번호가 올바르지 않습니다.");
                this.Dispose();
                Login login = new Login();
                login.ShowDialog();
                }
   
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
