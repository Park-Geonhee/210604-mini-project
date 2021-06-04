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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        public MySqlDb mySqlDb
        {
            get; set;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (mySqlDb?.IsOpen == true)
            {
                try
                {
                    String sql = String.Format("select * from member WHERE MEMBER_ID ={0}", this.Del_Id.Text);
                    MySqlCommand cmd = new MySqlCommand(sql, mySqlDb.Conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();


                    if (rdr.HasRows)
                    {
                        rdr.Dispose();
                        String query = String.Format("delete from member where MEMBER_ID =('{0}')", this.Del_Id.Text);
                        MySqlCommand cmd_insert = new MySqlCommand(query, mySqlDb.Conn);
                        cmd_insert.ExecuteNonQuery();
                        MessageBox.Show("성공적으로 제거되었습니다");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("조회된 아이디가 없습니다.");
                        rdr.Dispose();
                    }
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + "\r\n\r\n" + ex.StackTrace, "에러발생");
                }
            }
            else
            {
                MessageBox.Show("서버와 연결이 되어있지 않습니다.");
            }
        }
        
    }
}
