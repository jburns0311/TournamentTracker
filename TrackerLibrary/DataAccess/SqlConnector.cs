using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Model;

namespace TrackerLibrary.DataAccess 
{
    public class SqlConnector : IDataConnection
    {
        //TODO - Make the create prize method actually save to the database
        /// <summary>
        /// Saves a new Prize to the Database
        /// </summary>
        /// <param name="model"> The Prize Information</param>
        /// <returns>The prize information, including the unique ID</returns>
        /// 
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //This is I want want to Create a new DB Connection
            //We are using a IDBConnection that could be either a SQL or Text Connections
            //The using statement here say I want to take the below statement when we get to the end 
            //brace we end the connection and do it properly
            //We will use this multiple times to open and close connections
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("TournamentDB1")))
            {
                //We are setting parameters between our model and how we will connect
                //them to our procedures to add them to the DB
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@PrizeId", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                //You are just going to call something insert, update or delete
                //And not expect anything back
                //TODO - Check if the sql and param additionn will mess anything up later
                connection.Execute("dbo.spPrizesInsert", p, commandType: CommandType.StoredProcedure);

                //It will look at P and find Prize_Id and give me the value of it
                //So that way we can put into the model.PrizeId
                model.PrizeId = p.Get<int>("@PrizeId");

                return model;

            }

            
        }
    }
}
