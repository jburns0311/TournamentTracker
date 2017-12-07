using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Model;

namespace TrackerLibrary.DataAccess
{

    //Load the file
    //Convert the text to List<PrizeModel>
    //Find the ID
    //Add the record with the new ID (max + 1)
    //Convert the prizes to list<string>
    //Save the list<string> to the text file
    class TextConnector : IDataConnection
    {
        //TODO - Wire up the Create Prize for text files
    
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.PrizeId = 1;
            return model;
        } 
    }
}
