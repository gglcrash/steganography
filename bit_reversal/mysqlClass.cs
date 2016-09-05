using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bit_reversal
{
    class mysqlClass
    {


        private static void setConnString()
        {

            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";
            mysqlCSB.Database = "imghash";
            mysqlCSB.UserID = "root";
            mysqlCSB.Password = "rootpassword";

        }


        static MySqlConnectionStringBuilder mysqlCSB;

        public static List<int> GetAllID()
        {
            setConnString();

            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = mysqlCSB.ConnectionString;

                MySqlCommand com = new MySqlCommand(@"select id_man from man", con);

                try
                {
                    con.Open();

                    // com.ExecuteNonQuery();
                    using (MySqlDataReader reader = com.ExecuteReader())
                    {
                        List<int> myList = new List<int>();
                        while (reader.Read())
                        {
                            myList.Add(reader.GetInt32("ID_Man"));
                        }
                        return myList;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return null;
            }
        }
        public static List<ulong> GetAllHash(int n)
        {
            setConnString();

            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = mysqlCSB.ConnectionString;

                MySqlCommand com = new MySqlCommand(@"select hash" + n + " from man", con);

                try
                {
                    con.Open();

                    // com.ExecuteNonQuery();
                    using (MySqlDataReader reader = com.ExecuteReader())
                    {
                        List<ulong> myList = new List<ulong>();
                        while (reader.Read())
                        {
                            myList.Add(reader.GetUInt64("Hash" + n));
                        }
                        return myList;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return null;
            }
        }


        public static void DoCommand(string queryString)
        {
            setConnString();

            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = mysqlCSB.ConnectionString;

                MySqlCommand com = new MySqlCommand(queryString, con);

                try
                {
                    con.Open();

                    com.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        }

        public static string GetData(string queryString)
        {
            setConnString();

            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = mysqlCSB.ConnectionString;

                MySqlCommand com = new MySqlCommand(queryString, con);

                try
                {
                    con.Open();

                    return Convert.ToString(com.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }
            return "";
        }

    }
}