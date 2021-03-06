﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace COBOAM_Admin
{
    class MySql
    {
        private readonly MySqlConnection _connection;
        private MySqlCommand _mCmd;


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
                        MessageBox.Show(@"Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show(@"Invalid username/password, please try again");
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
            string query = Queries.ToString(qi);
            if (args.Length <= 0) return query;
            query = string.Format(query, args);
            return query;
        }

        internal Tuple<List<string>[], int> ExecuteReader(string query)
        {
            int rowCount = 0;
            if (!OpenConnection()) return null;
            _mCmd = new MySqlCommand(query, _connection);
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
                rowCount++;
            }
            mReader.Close();
            CloseConnection();
            return Tuple.Create(list, rowCount);
        }

        internal object ExecuteScalar(string query)
        {
            if (!OpenConnection()) return null;
            _mCmd = new MySqlCommand(query, _connection);
            object mObject = _mCmd.ExecuteScalar();
            _mCmd = null;
            CloseConnection();
            return mObject;
        }
        internal int ExecuteNonQuery(string query)
        {
            if (!OpenConnection()) return -1;
            _mCmd = new MySqlCommand(query, _connection);
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
