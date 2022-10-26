using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal class CoronaTest
    {
        public static void ee()
        {
           
            CoronaDashBoard dash = new CoronaDashBoard();
            
            dash.addCoronaData(40, "Maharashtra", 8000, 7000, 1000, 9000);
            dash.addCoronaData(40, "Kerala", 6000, 4000, 900, 8000);
            dash.addCoronaData(40, "Karnataka", 9000, 5000, 700, 6000);
            dash.addCoronaData(40, "Tamil Nadu", 2000, 8000, 400, 4000);
            dash.addCoronaData(40, "Andhra Pradesh", 4000, 7000, 200, 2000);

            dash.listCoronaData();
            dash.updateCoronaData(40,"Uttar Pradesh",2000,3000,200,3000);
            dash.listCoronaData();
            dash.deleteCorona("Kerala");
            dash.listCoronaData();
            dash.displayTopStates();
            
        }
    }
}
