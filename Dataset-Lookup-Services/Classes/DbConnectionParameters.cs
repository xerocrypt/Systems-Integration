namespace DatasetLookupWebService.Classes
{
    public class DBConnectionParameters
    {
        public string SqlDbCommandString(string category, bool validItemsOnly)
        {
            // SQL query for all items within CategoryName
            string sqlDbCommandString1 = string.Format("SELECT C.Name[CategoryName], B.Category[CategoryValue], B.Name, B.Band[Value]," +
                    " B.DataNode, B.ParentBand[Parent], D.Code1[ValidFrom], D.Code2[ValidTo], D.Code3 SortOrder" +
                    " from BandsTable B Join DetailsTable D on B.Category = D.Category and B.Band = D.Band and B.Owner = D.Owner" +
                    " join CategoriesTable C on c.Category = B.Category where B.Category in (Select Band from BandsTable" +
                    " where Category = '" + category + "')");

            // SQL query for valid items only associated with CategoryName
            string sqlDbCommandString2 = string.Format("SELECT C.Name[CategoryName], B.Category[CategoryValue], B.Name, B.Band[Value]," +
                " B.DataNode, B.ParentBand[Parent], D.Code1[ValidFrom], D.Code2[ValidTo], D.Code3 SortOrder" +
                " FROM BandsTable B JOIN DetailsTable D ON B.Category = D.Category AND B.Band = D.Band" +
                " AND B.Owner = D.Owner AND(CONVERT(DateTime, Code2, 103) = GETDATE())" +
                " JOIN CategoriesTable C on c.Category = B.Category where B.Category" +
                " IN(Select Band from BandsTable WHERE Category = '" + category + "')" +
                " IF @@ROWCOUNT = 0  SELECT 'Dataset' AS CategoryName");


            if (validItemsOnly == false)
            {
                return sqlDbCommandString1;
            }
            if (validItemsOnly == true)
            {
                return sqlDbCommandString2;
            }
            else
            {
                return sqlDbCommandString1;
            }
        }
    }
}