using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DB_Management
{
    public partial class MainForm : Form
    {
        public MySqlDb mySqlDb
        {
            get; set;
        }
        public MainForm()
        {
            InitializeComponent();
            mySqlDb = null;
        }

        private void Logout_Click(object sender, EventArgs e)
        {

            mySqlDb?.Close();
            mySqlDb = null;
            this.Dispose();
            Login login = new Login();
            login.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

            mySqlDb?.Close();
            mySqlDb = null;
            Application.Exit();
        }
        private void 추가_Click(object sender, EventArgs e)
        {
            Add AddFrm = new Add();

            if (mySqlDb?.IsOpen == true)
            {
                if (AddFrm.ShowDialog(this) == DialogResult.OK)
                {

                    String query = String.Format("INSERT INTO member (name, age, sex, addr, phone) VALUES ('{0}', '{1}',  '{2}',  '{3}',  '{4}')",
                            AddFrm.AddName.Text, AddFrm.AddAge.Text, AddFrm.AddSex.Text, AddFrm.AddAddr.Text, AddFrm.AddPhone.Text);

                    MySqlCommand cmd_insert = new MySqlCommand(query, mySqlDb.Conn);
                    try
                    {
                        cmd_insert.ExecuteNonQuery();
                        MessageBox.Show("성공적으로 추가되었습니다");
                        tsslblStatus.Text = "추가 완료";
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message + "\r\n\r\n" + ex.StackTrace, "에러발생");
                    }
                }
            }
            else
            {
                MessageBox.Show("서버와 연결이 되어있지 않습니다.");
            }
        }

        private void 수정_Click(object sender, EventArgs e)
        {
            Update UpFrm = new Update();
            UpFrm.mySqlDb = this.mySqlDb;
            UpFrm.ShowDialog();
            tsslblStatus.Text = "수정 완료";
        }


        private void 제거_Click(object sender, EventArgs e)
        {
            Delete DelFrm = new Delete();
            DelFrm.mySqlDb = this.mySqlDb;
            DelFrm.ShowDialog();
            tsslblStatus.Text = "제거 완료";
        }

        private MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

        private void Select_Table()
        {
            dataGridView1.Columns[0].HeaderText = "MEMBER_ID";
            dataGridView1.Columns[0].Width = 80;

            dataGridView1.Columns[1].HeaderText = "이름";
            dataGridView1.Columns[1].Width = 100;
            
            dataGridView1.Columns[2].HeaderText = "나이";
            dataGridView1.Columns[2].Width = 90;

            dataGridView1.Columns[3].HeaderText = "성별";
            dataGridView1.Columns[3].Width = 90;

            dataGridView1.Columns[4].HeaderText = "주소";
            dataGridView1.Columns[4].Width = 450;

            dataGridView1.Columns[5].HeaderText = "전화번호";
            dataGridView1.Columns[5].Width = 150;
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            if (mySqlDb?.IsOpen == true)
            {
                dataGridView1.DataSource = bindingSource1;
                GetData("select * from member");

                Select_Table();
                tsslblStatus.Text = "조회 완료";
            }
            else
            {
                MessageBox.Show("서버와 연결이 되어있지 않습니다.");
            }
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            if (mySqlDb?.IsOpen == true)
            {
                dataGridView1.DataSource = bindingSource1;
                GetData("select * from member");

                Select_Table();
                tsslblStatus.Text = "조회 완료";
            }
            else
            {
                MessageBox.Show("서버와 연결이 되어있지 않습니다.");
            }
        }

        private void SelectName_Click(object sender, EventArgs e)
        {
            SelectToName STN = new SelectToName();
            if (mySqlDb?.IsOpen == true)
            {
                if (STN.ShowDialog(this) == DialogResult.OK)
                {
                    dataGridView1.DataSource = bindingSource1;
                    String Select_Name = String.Format("select * from member WHERE NAME =('{0}')", STN.InsertName.Text);

                    GetData(Select_Name);
                    Select_Table();
                    MessageBox.Show("조회가 완료되었습니다.");
                    tsslblStatus.Text = "조회 완료";

                }
            }
            else
            {
                MessageBox.Show("서버와 연결이 되어있지 않습니다.");
            }

        }


        private void SelectAdress_Click(object sender, EventArgs e)
        {
            SelectToAdr STA = new SelectToAdr();
            STA.mySqlDb = this.mySqlDb;
            STA.ShowDialog();

            if (mySqlDb?.IsOpen == true)
            {
                if (STA.ShowDialog(this) == DialogResult.OK)
                {
                    dataGridView1.DataSource = bindingSource1;
                    String Select_Adr = String.Format("select * from member WHERE ADDR =('{0}')", STA.InsertAdr.Text);

                    GetData(Select_Adr);
                    Select_Table();
                    MessageBox.Show("조회가 완료되었습니다.");
                    tsslblStatus.Text = "조회 완료";
                }
            }
            else
            {
                MessageBox.Show("서버와 연결이 되어있지 않습니다.");
            }
        }



        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new MySqlDataAdapter(selectCommand, mySqlDb.Conn);

                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (MySqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            mySqlDb?.Close();
            mySqlDb = null;
            Application.Exit();
        }


        private void Info_help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void Info_info_Click(object sender, EventArgs e)
        {
            Infomation infomation = new Infomation();
            infomation.ShowDialog();
        }

    }
}
