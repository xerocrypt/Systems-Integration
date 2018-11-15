using System;
using System.Data.SqlClient;

namespace DatasetLookupWebService.Classes
{
    public class ConstructItem
    {
        public static Dataset AddItem(Dataset targetCategory, SqlDataReader reader)
        {
            targetCategory.Items.Add(new Item()
            {
                Band = reader.GetString(0),
                Name = reader.GetString(1),
                ValidFrom = reader["ValidFrom"] is DBNull || (string)reader["ValidFrom"] == "" ? (DateTime?)null : DateTime.Parse((string)reader["ValidFrom"]),
                ValidTo = reader["ValidTo"] is DBNull || (string)reader["ValidTo"] == "" ? (DateTime?)null : DateTime.Parse((string)reader["ValidTo"]),
                SortOrder = int.Parse((string)reader["SortOrder"])
            });

            return targetCategory;
        }
    }
}