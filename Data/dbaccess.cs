using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Collections;


public class dbaccess
{
    private static MySqlConnection connection = new MySqlConnection();
    private static MySqlCommand command = new MySqlCommand();
    private static MySqlDataReader dataReader;
    private static MySqlDataAdapter adapter = new MySqlDataAdapter();
    
    private static string dbconnecstring = "Server=127.0.0.1;Port=3306;database=barbershopdb;user id=root;password=Tmq5BJ!Muyi4";
    public static void CreateConnection()
    {
        try
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.ConnectionString = dbconnecstring;
                connection.Open();
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public static void CloseConnection()
    {
        connection.Close();
    }

    public static List<Dictionary<string,object>> IsValidUser(string query, Dictionary<string,object> parameters){
        
        List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
        
        try{
            if (connection.State != ConnectionState.Open)
            {
                CreateConnection();
            }

            MySqlCommand command = new MySqlCommand(query, connection);
            DataTable table = new DataTable();

            if(parameters.Count > 0){
                foreach(var param in parameters){
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
            }else{
                return result;
            }

            adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            foreach(DataRow row in table.Rows){
                Dictionary<string,object> dic = new Dictionary<string, object>();
                foreach(DataColumn col in table.Columns){
                    dic.Add(col.ColumnName, row[col]);
                }
                result.Add(dic);
            }
            CloseConnection();

        }catch{
        }
        
        return result;
    }

    public static DataTable ReadDataThroughtAdapter(string query)
    {
        try
        {
            if (connection.State != ConnectionState.Open)
            {
                CreateConnection();
            }

            DataTable table = new DataTable();
            command.Connection = connection;
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            return table;

        }
        catch (Exception e)
        {
            throw e;
        }

    }

    public static MySqlDataReader ReadDataThroughtReader(string query)
    {
        try
        {
            if (connection.State != ConnectionState.Open)
            {
                CreateConnection();
            }

            command.Connection = connection;
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            return command.ExecuteReader();

        }
        catch (Exception e)
        {
            throw e;
        }

    }

    public static int ExecuteQuery(MySqlCommand dbcommand)
    {
        try
        {
            if (connection.State != ConnectionState.Open)
            {
                CreateConnection();
            }

            dbcommand.Connection = connection;
            dbcommand.CommandType = CommandType.Text;

            return dbcommand.ExecuteNonQuery();

        }
        catch (Exception e)
        {
            throw e;
        }

    }

    public static ArrayList  GetListFromDataBase(string query, string column){
        ArrayList array = new ArrayList();
        dataReader = ReadDataThroughtReader(query);
        while(dataReader.Read()){
            array.Add(dataReader[column].ToString());
        }
        dataReader.Close();
        return array;
    }

}
