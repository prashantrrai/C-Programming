using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Retrieve the connection string from Web.config
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);

        try
        {
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                Console.WriteLine("Database Connected");
            }
            else
            {
                Console.WriteLine("Not Connected");
            }
        }
        catch (Exception err)
        {
            Console.WriteLine("Error: " + err.Message);
        }
        finally
        {
            con.Close();
        }
    }
}
