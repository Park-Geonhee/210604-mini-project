using MySql.Data.MySqlClient;
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
    public partial class Update : Form
    {
        public MySqlDb mySqlDb
        {
            get; set;
        }
        public Update()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (mySqlDb?.IsOpen == true)
            {
                try
                {
                    String sql = String.Format("select * from member WHERE MEMBER_ID ={0}", this.InsertID.Text);
                    MySqlCommand cmd = new MySqlCommand(sql, mySqlDb.Conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

               
                    if (rdr.HasRows)
                    {
                        MessageBox.Show("조회가 완료되었습니다.");

                        rdr.Read();

                        this.InsertID.Text = string.Format("{0}", rdr[0]);

                        this.txtboxName.Text = string.Format("{0}", rdr[1]);

                        this.txtboxAge.Text = string.Format("{0}", rdr[2]);

                        this.txtboxSex.Text = string.Format("{0}", rdr[3]);

                        this.txtboxAddress.Text = string.Format("{0}", rdr[4]);

                        this.txtboxPhone.Text = string.Format("{0}", rdr[5]);

                        rdr.Close();

                        this.label1.Text = "수정할 정보를 입력하세요.";
                        this.btnSelect.Enabled = false;
                        this.btnUpdate.Enabled = true;
                        this.InsertID.ReadOnly = true;
                        this.txtboxName.ReadOnly = false;
                        this.txtboxAge.ReadOnly = false;
                        this.txtboxSex.ReadOnly = false;
                        this.txtboxAddress.ReadOnly = false;
                        this.txtboxPhone.ReadOnly = false;

                    }
                    else
                    {
                        MessageBox.Show("조회된 아이디가 없습니다.");
                        rdr.Dispose();
                    }


                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message +"\r\n\r\n"+ex.StackTrace, "에러발생"); 
                }
            }
            else
            {
                MessageBox.Show("서버와 연결이 되어있지 않습니다.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String sql_up = String.Format("update member set NAME = ('{0}'), AGE = ('{1}'), SEX = ('{2}')" +
                 ", ADDR = ('{3}'), PHONE = ('{4}') WHERE MEMBER_ID =('{5}')",
                 this.txtboxName.Text, this.txtboxAge.Text, this.txtboxSex.Text, this.txtboxAddress.Text, this.txtboxPhone.Text, this.InsertID.Text);

                MySqlCommand cmd_up = new MySqlCommand(sql_up, mySqlDb.Conn);

                cmd_up.ExecuteNonQuery();

                MessageBox.Show("성공적으로 수정되었습니다");

                this.Dispose();
            }
            catch
            {
                MessageBox.Show("잘못된 입력입니다.");
            }
            
        }

    }
}
