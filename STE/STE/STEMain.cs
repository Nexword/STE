using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STEIL;
using STECL;
namespace STE
{
    class STEMain
    {
        static void Main()
        {
            Console.WriteLine("First");
            //Сам dataLoader в будущем будет создаваться в другом месте при разборе базы, а сюда
            STEDataLoader dataLoader = new STEDataLoader();
            STESimpleTest myTest = new STESimpleTest();
            myTest = dataLoader.STEMakeStructure();
        }
    }
}
