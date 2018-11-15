using System;
using System.Linq;
using System.Data;
using System.Web.Http;
using System.Data.SqlClient;
using DatasetLookupWebService.Classes;
using DatasetLookupWebService.Models;

namespace DatasetLookupWebService.Controllers
{
    public class ValuesController : ApiController
    {
        referenceDatabaseEntities Db = new referenceDatabaseEntities();
        GetDbReader getDbReader = new GetDbReader();
        ConstructItem AddItem = new ConstructItem();
        GetLookupDataResponse result = new GetLookupDataResponse();

        public GetLookupDataResponse Get(string category, bool validItemsOnly)
        {
            SqlCommand SqlCommand;
            SqlDataReader reader;

            // Pass 'category' and 'validItemsOnly' to the DB Reader method
            getDbReader.GetReader(category, validItemsOnly, out SqlCommand, out reader);

            try
            {
                while (reader.Read())
                {
                    var CategoryValue = (string)reader["CategoryValue"];
                    var CategoryName = (string)reader["CategoryName"];
                    var targetCategory = result.Datasets.Where(o => o.Value == CategoryValue).FirstOrDefault();

                    if (targetCategory == null)
                    {
                        targetCategory = new Dataset() { Name = CategoryName, Value = CategoryValue };
                    }

                    targetCategory = ConstructItem.AddItem(targetCategory, reader);

                    result.Datasets.Add(targetCategory);
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }

            // Check whether datasets exist in the response, after the database reader and constructors have executed.
            finally
            {
                if (result.Datasets.Count == 0)
                {
                    result.Datasets.Add(new Dataset() { Name = "Error", Value = "Dataset Not Found" });
                }
                SqlCommand.Connection.Close();
            }
            return result;
        }
    }
}