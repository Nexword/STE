using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STEIL;
using STECL;
using STEDP;
namespace STE
{
    class STEMain
    {
        static void Main()
        {
            Console.WriteLine("First");
            //Сам dataLoader в будущем будет создаваться в другом месте при разборе базы
            STEDataLoader dataLoader = new STEDataLoader();
            STESimpleTest myTest;
            STEPresenter DrawMaster = new STEPresenter();
            myTest = dataLoader.STEMakeStructure();
            DrawMaster.STEPresenterConsoleOutput(myTest);
            Console.WriteLine("Fucking WPF");
        }
    }
}
