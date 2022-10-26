using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal class CoronaDashBoard
    {
        public List<Corona> listCorona = new List<Corona>();
        public void addCoronaData(int code, String name, int active, int recorded, int death, int total)
        {
            //new Corona(code, name, active, recorded, death, total);
            listCorona.Add(new Corona(code, name, active, recorded, death, total));

        }
        public void updateCoronaData(int code, String name, int active, int recorded, int death, int total)
        {
            Console.WriteLine("After Updation");
            listCorona.Add(new Corona(code, name, active, recorded, death, total));
        }
        int ind = -1;
        public List<int> a =new List<int>();
        public void displayTopStates()
        {
            foreach(var rate in listCorona)
            {
               
                a.Add( rate.death);
              
        
                break;
                
            }
            Console.WriteLine("Top death rate");
            Console.WriteLine(a.Max());
        }
        public void deleteCorona(String name)
        {
          
            Console.WriteLine("After Deleted");
           
            foreach(var dele in listCorona)
            {
                if (dele.name == name)
                {
                    ind = listCorona.IndexOf(dele);
                    break;
                }
            }
            listCorona.RemoveAt(ind);
        }
        public void listCoronaData()
        {
          
            foreach (var item in listCorona)
            {
                Console.WriteLine(item.info());
            }
        }
    }
}
