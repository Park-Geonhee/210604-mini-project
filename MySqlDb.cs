using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Management
{
    public class MySqlDb
    {
        private String connStr
        {
            get; set;
        }

        public MySqlConnection Conn
        {
            get; set;
        }

        public bool IsOpen
        {
            get; set;
        }

        public MySqlDb(string connStr)
        {
            if (String.IsNullOrWhiteSpace(connStr))
                return;

            this.connStr = connStr;
            try
            {
                Conn = new MySqlConnection(connStr);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "MySQL DB 접속정보 에러");
            }
        }

        public bool Open()
        {
            if (IsOpen)
                return true;

            IsOpen = false;
            try
            {
                Conn.Open();
                IsOpen = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "MySQL DB 접속 에러");

                return false;
            }

            return true;
        }

        public void Close()
        {
            IsOpen = false;
            Conn?.Close();
        }
    }
}
