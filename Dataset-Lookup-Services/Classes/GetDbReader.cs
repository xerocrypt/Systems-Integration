using System.Data.SqlClient;

namespace DatasetLookupWebService.Classes
{
    public class GetDbReader
    {

        // Input parameters: Category name, valid items only, the SQL query string, reader object
        public void GetReader(string category, bool validItemsOnly, out SqlCommand SqlCommand, out SqlDataReader reader)
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["referenceDataServer"].ConnectionString;
            SqlCommand = new SqlCommand();
            SqlCommand.Connection = new SqlConnection(connection);

            // 'DBConnectionParameters = SQL query string
            DBConnectionParameters CommandString = new DBConnectionParameters();
            string query = CommandString.SqlDbCommandString(category, validItemsOnly);
            
            SqlCommand.CommandText = query;
            SqlCommand.Connection.Open();

            reader = SqlCommand.ExecuteReader();
        }
    }
}