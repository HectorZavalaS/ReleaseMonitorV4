//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace ReleaseMonitorV4.Class
//{
//    class CMySQL
//    {
//        private MySqlConnection m_conn;
//        private DataTable m_data;
//        private MySqlDataAdapter m_da;
//        private MySqlCommand m_cb;
//        private String m_cadC;

//        public CMySQL()
//        {
//            m_cadC = String.Format("server={0};user id={1}; password={2}; database=siixsem_xml_laser; pooling=false",
//                            "192.168.3.13", "root", "S3m4dm1n2017!");
//            m_cb = new MySqlCommand();
//        }

//        public bool connect()
//        {
//            bool result = false;
//            try
//            {
//                m_conn = new MySqlConnection(m_cadC);
//                m_conn.Open();
//                result = true;
//            }
//            catch (MySqlException ex)
//            {
//                MessageBox.Show("Error connecting to the server: " + ex.Message);
//            }
//            return result;
//        }

//        public bool executeSPWhitoutP(String nameProc)
//        {
//            bool result = false;
//            try
//            {
//                Console.WriteLine("Connecting to MySQL...");
//                connect();
//                m_cb.Connection = m_conn;

//                m_cb.CommandText = nameProc;
//                m_cb.CommandType = CommandType.StoredProcedure;

//                m_cb.ExecuteNonQuery();

//                //Console.WriteLine("Employee number: " + cmd.Parameters["@empno"].Value);
//                //Console.WriteLine("Birthday: " + cmd.Parameters["@bday"].Value);
//            }
//            catch (MySql.Data.MySqlClient.MySqlException ex)
//            {
//                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
//            }
//            m_conn.Close();
//            Console.WriteLine("Done.");
//            return result;
//        }
//        public bool getLastSerial150(String djGroup, ref String lastSerial)
//        {
//            bool result = false;
//            try
//            {
//                Console.WriteLine("Connecting to MySQL...");
//                connect();
//                m_cb.Connection = m_conn;

//                int dia = DateTime.Now.DayOfYear;

//                string query = "SELECT Max(contador) as contador FROM siixsem_xml_laser.siixsem_150b_ldm_t where julian_date = ?jd";

//                MySqlCommand mycomand = new MySqlCommand(query, m_cb.Connection);
//                mycomand.Parameters.AddWithValue("?jd", dia.ToString());


//                MySqlDataReader myreader = mycomand.ExecuteReader();
//                //myreader.Read();

//                if (myreader.HasRows)
//                {
//                    while (myreader.Read())
//                    {
//                        lastSerial = myreader["contador"].ToString();
//                    }
//                    result = true;
//                    if (String.IsNullOrEmpty(lastSerial)) lastSerial = "1";
//                }
//                else
//                {
//                    lastSerial = "1";
//                    result = true;
//                }

//                //return datos;

//                //Console.WriteLine("Employee number: " + cmd.Parameters["@empno"].Value);
//                //Console.WriteLine("Birthday: " + cmd.Parameters["@bday"].Value);
//            }
//            catch (MySql.Data.MySqlClient.MySqlException ex)
//            {
//                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
//                result = false;
//            }
//            m_conn.Close();
//            Console.WriteLine("Done.");
//            return result;
//        }
//        public bool insertLastSerial150(String contador, String julianDay, String batchQty, String djGroup)
//        {
//            bool result = false;
//            try
//            {
//                Console.WriteLine("Connecting to MySQL...");
//                connect();
//                m_cb.Connection = m_conn;

//                int dia = DateTime.Now.DayOfYear;

//                string query = "INSERT INTO siixsem_xml_laser.siixsem_150b_ldm_t (contador, julian_date,cantidad,dj) VALUES (?cont,?jd,?cant,?dj)";

//                MySqlCommand mycomand = new MySqlCommand(query, m_cb.Connection);
//                mycomand.Parameters.AddWithValue("?cont", contador);
//                mycomand.Parameters.AddWithValue("?jd", julianDay);
//                mycomand.Parameters.AddWithValue("?cant", batchQty);
//                mycomand.Parameters.AddWithValue("?dj", djGroup);


//                MySqlDataReader myreader = mycomand.ExecuteReader();

//            }
//            catch (MySql.Data.MySqlClient.MySqlException ex)
//            {
//                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
//                result = false;
//            }
//            m_conn.Close();
//            Console.WriteLine("Done.");
//            return result;
//        }
//    }
//}
