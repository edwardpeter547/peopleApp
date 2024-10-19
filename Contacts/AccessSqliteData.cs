using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Dapper;
using System.Configuration;

namespace Contacts
{
    internal class AccessSqliteData
    {
        public static List<PersonModel> LoadPeople()
        {
            
            
            using( var conn = new OleDbConnection(LoadConnectionString()))
            {
                var result = conn.Query<PersonModel>("select * from person", new DynamicParameters());
                return result.ToList();
            }
        }

        public static void InsertPerson(PersonModel person)
        {
            using(var conn = new OleDbConnection(LoadConnectionString()))
            {
                conn.Execute("insert into person(name, family) values(@name, @family)", person);
            }
        }

        public static string LoadConnectionString(string id = "family")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
