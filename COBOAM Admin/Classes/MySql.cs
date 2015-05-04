using System;
using System.Collections.Generic;
using System.Windows.Forms;
using COBOAM_Admin.Properties;
using MySql.Data.MySqlClient;

namespace COBOAM_Admin.Classes
{
    class MySql
    {
        private readonly MySqlConnection _connection;
        private MySqlCommand _mCmd;
        private string[] argArray = new[] { "{0}", "{1}", "{2}", "{3}", "{4}", "{5}", "{6}", "{7}", "{8}", "{9}" };

        //private const string QueryPath = "Queries\\";

        public MySql(string server, string port, string database, string username, string password)
        {
            string conString = "SERVER=" + server + ";" + "Port=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";Convert Zero Datetime=True;";
            _connection = new MySqlConnection(conString);
        }

        private bool OpenConnection()
        {
        Reconnect:
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 1042:
                        MessageBox.Show(Resources.Mysql_1042);
                        break;
                    case 1045:
                        MessageBox.Show(Resources.Mysql_1045);
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
            catch (InvalidOperationException)
            {
                _connection.Close();
                goto Reconnect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        internal static string GetQuery(QueryIndex qi, params object[] args)
        {
            string query = Queries.Value(qi);
            if (args.Length <= 0) return query;
            query = string.Format(query, args);
            return query;
        }

        internal List<string>[] ExecuteReader(QueryIndex qi, params object[] args)
        {
            if (!OpenConnection()) return null;
            string query = Queries.Value(qi);
            _mCmd = new MySqlCommand(query, _connection);
            for (int i = 0; i < args.Length; i++)
                _mCmd.Parameters.AddWithValue("?p" + i, args[i]);
            MySqlDataReader mReader = _mCmd.ExecuteReader();
            _mCmd = null;
            List<string>[] list = new List<string>[mReader.FieldCount];

            for (int i = 0; i < (list.Length); i++)
            {
                list[i] = new List<string>();
            }
            while (mReader.Read())
            {
                for (int i = 0; i < (list.Length); i++)
                    list[i].Add(mReader[i].ToString());
            }
            mReader.Close();
            CloseConnection();
            return list;
        }

        internal object ExecuteScalar(QueryIndex qi, params object[] args)
        {
            if (!OpenConnection()) return null;
            string query = Queries.Value(qi);
            _mCmd = new MySqlCommand(query, _connection);
            for (int i = 0; i < args.Length; i++)
                _mCmd.Parameters.AddWithValue("?p" + i, args[i]);
            object mObject = _mCmd.ExecuteScalar();
            _mCmd = null;
            CloseConnection();
            return mObject;
        }
        internal int ExecuteNonQuery(QueryIndex qi, params object[] args)
        {
            if (!OpenConnection()) return -1;
            string query = Queries.Value(qi);
            _mCmd = new MySqlCommand(query, _connection);
            for (int i = 0; i < args.Length; i++)
                _mCmd.Parameters.AddWithValue("?p" + i, args[i]);
            int result = _mCmd.ExecuteNonQuery();
            _mCmd = null;
            CloseConnection();
            return result;
        }

        private void CloseConnection()
        {
            try
            {
                _connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
