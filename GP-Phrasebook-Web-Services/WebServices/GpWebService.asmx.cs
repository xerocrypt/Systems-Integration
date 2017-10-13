using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace GP_Web_Service
{
    /// <summary>
    /// Summary description for GpWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GpWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public DataTable GetAllPhrases()
        {
            string dbstring = ConfigurationManager.ConnectionStrings["PhrasebookDB"].ConnectionString;
            using (SqlConnection gpconnection = new SqlConnection(dbstring))
            {
                using (SqlCommand gpcommand = new SqlCommand("spGetAllPhrases"))
                {
                    using (SqlDataAdapter gpadapter = new SqlDataAdapter())
                    {
                        gpcommand.Connection = gpconnection;
                        gpadapter.SelectCommand = gpcommand;
                        using (DataTable phraseTable = new DataTable())
                        {
                            phraseTable.TableName = "allphrases";
                            gpadapter.Fill(phraseTable);
                            return phraseTable;
                        }
                    }
                }
            }
        }

        [WebMethod]
        public DataTable GetIntroductionPhrases()
        {
            string dbstring = ConfigurationManager.ConnectionStrings["PhrasebookDB"].ConnectionString;
            using (SqlConnection gpconnection = new SqlConnection(dbstring))
            {
                using (SqlCommand gpcommand = new SqlCommand("spGetIntroductionPhrases"))
                {
                    using (SqlDataAdapter gpadapter = new SqlDataAdapter())
                    {
                        gpcommand.Connection = gpconnection;
                        gpadapter.SelectCommand = gpcommand;
                        using (DataTable phraseTable = new DataTable())
                        {
                            phraseTable.TableName = "introphrases";
                            gpadapter.Fill(phraseTable);
                            return phraseTable;
                        }
                    }
                }
            }
        }
        
        [WebMethod]
        public DataTable GetMiscellaneousPhrases()
        {
            string dbstring = ConfigurationManager.ConnectionStrings["PhrasebookDB"].ConnectionString;
            using (SqlConnection gpconnection = new SqlConnection(dbstring))
            {
                using (SqlCommand gpcommand = new SqlCommand("spGetMiscPhrases"))
                {
                    using (SqlDataAdapter gpadapter = new SqlDataAdapter())
                    {
                        gpcommand.Connection = gpconnection;
                        gpadapter.SelectCommand = gpcommand;
                        using (DataTable phraseTable = new DataTable())
                        {
                            phraseTable.TableName = "Miscellaneous";
                            gpadapter.Fill(phraseTable);
                            return phraseTable;
                        }
                    }
                }
            }
        }

        [WebMethod]
        public DataTable GetPersonalInfoPhrases()
        {
            string dbstring = ConfigurationManager.ConnectionStrings["PhrasebookDB"].ConnectionString;
            using (SqlConnection gpconnection = new SqlConnection(dbstring))
            {
                using (SqlCommand gpcommand = new SqlCommand("spGetPersonalInfoPhrases"))
                {
                    using (SqlDataAdapter gpadapter = new SqlDataAdapter())
                    {
                        gpcommand.Connection = gpconnection;
                        gpadapter.SelectCommand = gpcommand;
                        using (DataTable phraseTable = new DataTable())
                        {
                            phraseTable.TableName = "PersonalInfo";
                            gpadapter.Fill(phraseTable);
                            return phraseTable;
                        }
                    }
                }
            }
        }

        [WebMethod]
        public DataTable GetMiscPhrases()
        {
            string dbstring = ConfigurationManager.ConnectionStrings["PhrasebookDB"].ConnectionString;
            using (SqlConnection gpconnection = new SqlConnection(dbstring))
            {
                using (SqlCommand gpcommand = new SqlCommand("spGetMiscPhrases"))
                {
                    using (SqlDataAdapter gpadapter = new SqlDataAdapter())
                    {
                        gpcommand.Connection = gpconnection;
                        gpadapter.SelectCommand = gpcommand;
                        using (DataTable phraseTable = new DataTable())
                        {
                            phraseTable.TableName = "Miscellaneous";
                            gpadapter.Fill(phraseTable);
                            return phraseTable;
                        }
                    }
                }
            }
        }

        [WebMethod]
        public DataTable GetPhrasesByCategory(string categoryName)
        {

            string dbstring = ConfigurationManager.ConnectionStrings["PhrasebookDB"].ConnectionString;
            using (SqlConnection gpconnection = new SqlConnection(dbstring))
            {
                using (SqlCommand gpcommand = new SqlCommand("spGetPhrasesByCategory"))
                {
                    using (SqlDataAdapter gpadapter = new SqlDataAdapter())
                    {

                        gpcommand.CommandType = CommandType.StoredProcedure;
                        gpcommand.Parameters.AddWithValue("@Category", categoryName);
                        gpcommand.Connection = gpconnection;
                        gpadapter.SelectCommand = gpcommand;
                        using (DataTable phraseTable = new DataTable())
                        {
                            phraseTable.TableName = "phrasesByCategory";
                            gpadapter.Fill(phraseTable);
                            return phraseTable;
                        }
                    }
                }
            }
        }

        [WebMethod]
        public string AddPhrase(string englishPhrase, string germanPhrase, string phraseNote, string categoryName)
        {

            string dbstring = ConfigurationManager.ConnectionStrings["PhrasebookDB"].ConnectionString;
            using (SqlConnection gpconnection = new SqlConnection(dbstring))
            {
                using (SqlCommand gpcommand = new SqlCommand("spAddPhrase"))
                {
                    try
                    {
                        gpcommand.CommandType = CommandType.StoredProcedure;
                        gpcommand.Parameters.AddWithValue("@English", englishPhrase);
                        gpcommand.Parameters.AddWithValue("@German", germanPhrase);
                        gpcommand.Parameters.AddWithValue("@Note", phraseNote);
                        gpcommand.Parameters.AddWithValue("@Category", categoryName);
                        gpcommand.Connection = gpconnection;
                        gpconnection.Open();
                        gpcommand.ExecuteNonQuery();
                        gpconnection.Close();
                        return "Phrase successfully added.";
                    }
                    catch
                    {
                        return "Failed to add phrase.";
                    }
                }
            }
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
