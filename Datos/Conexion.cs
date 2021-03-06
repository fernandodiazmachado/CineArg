﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;

namespace Datos
{
    public class Conexion
    {
        private string connection = string.Empty;
        private MySqlConnection connect;
        private MySqlCommand command;
        private MySqlDataAdapter da;
        private DataTable dt;
        private DataSet ds;
        private DataRow dr;

        public Conexion()
        {
            connect = new MySqlConnection();
            connection = "server=127.0.0.1; port=3306; database=cinearg; user id=root; password=1234";
        }

        private MySqlConnection ConnectToBBDD()
        {
            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.ConnectionString = connection;
                    connect.Open();
                }
                catch(Exception e)
                {
                    
                }
            }

            return connect;
        }

        private void CloseConnection()
        {
            if (connect.State != ConnectionState.Closed)
                connect.Close();
        }

        public string TraerString(string query)
        {
            string cadena = string.Empty;
            try
            {
                ConnectToBBDD();
                command = new MySqlCommand(query, connect);
                cadena = command.ExecuteScalar().ToString();
            }
            catch
            {
                cadena = string.Empty;
            }
            finally
            {
                CloseConnection();
            }

            return cadena;
        }

        public double TraerDouble(string query)
        {
            double valor = 0;
            try
            {
                ConnectToBBDD();
                command = new MySqlCommand(query, connect);
                valor =  Convert.ToDouble(command.ExecuteScalar().ToString());
            }
            catch
            {
                valor = 0;
            }
            finally
            {
                CloseConnection();
            }

            return valor;
        }

        public int TraerInt(string query)
        {
            int valor = 0;
            try
            {
                ConnectToBBDD();
                command = new MySqlCommand(query, connect);
                valor = Convert.ToInt32(command.ExecuteScalar().ToString());
            }
            catch
            {
                valor = 0;
            }
            finally
            {
                CloseConnection();
            }

            return valor;
        }

        public bool ExecuteComand(string query)
        {
            bool exito;
            try
            {
                ConnectToBBDD();
                command = new MySqlCommand(query, connect);
                command.ExecuteNonQuery();
                exito = true;
            }
            catch(Exception e)
            {
                exito = false;
            }
            finally
            {
                CloseConnection();
            }

            return exito;
        }

        public DataTable SelectDataTable(string query)
        {
            dt = new DataTable();
            try
            {
                ConnectToBBDD();
                da = new MySqlDataAdapter(query, connect);
                da.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }

        

        public DataSet SelectDataSet(string query, string table)
        {
            ds = new DataSet();
            try
            {
                ConnectToBBDD();
                da = new MySqlDataAdapter(query, connect);
                da.Fill(ds, table);
            }
            catch
            {

            }
            finally
            {
                CloseConnection();
            }

            return ds;
        }

    }
}
