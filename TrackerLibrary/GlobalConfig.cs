using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TrackerLibrary.DataAccess;
using static TrackerLibrary.Enums;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                //TODO - Set up SQL Connector properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if (db == DatabaseType.TextFile)
            {
                //TODO - Set up File Connector properly
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

        public static string ConnString(string name)
        {
            ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
