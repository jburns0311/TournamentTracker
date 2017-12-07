using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    //This class can't be instantiated hence why static
    public static class GlobalConfig
    {
        //The reason we have a list of connections is so that we can pick and choose the connections we want
        //By setting private only methods within this class can set the connections
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        //This method will be establish the database or textfiles we want to connect with
        //Think about pontential changes: Don't over or underdesign
        //This will help us filter out what connections we will put in IDataConnection
        public static void InitializeConnections(bool database, bool textfile)
        {
            //We don't need equals because the variable is already true or false
            if(database)
            {
                //TODO - Set up the SQL Connector Properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);

            }

            if(textfile)
            {
                //TODO - Set up the Text Connector Properly
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
