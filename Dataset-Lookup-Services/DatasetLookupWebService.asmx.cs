using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using DatasetLookupLookupWebService.Classes;
using DatasetLookupWebService.Models;

using System.Web.Services;

namespace DatasetLookupWebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class DatasetLookupWebService : System.Web.Services.WebService
    {
        referenceDatabaseEntities Db = new referenceDatabaseEntities();
        GetDbReader getDbReader = new GetDbReader();
        ConstructItem AddItem = new ConstructItem();

        [WebMethod]
        public GetLookupDataResponse DatasetLookup(string category, bool validItemsOnly)
        {
            SqlCommand SqlCommand;
            GetLookupDataResponse result = new GetLookupDataResponse();
            SqlDataReader reader;
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

                    if (result.Datasets == null)
                    {
                        targetCategory = new Dataset() { Name = "Dataset empty", Value = "Dataset empty" };
                    }
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
            finally
            {
                if(result.Datasets.Count == 0)
                {
                    result.Datasets.Add(new Dataset() { Name = "Error", Value = "Dataset Not Found" });
                }
                SqlCommand.Connection.Close();
            }
            return result;
        }
    }
}

