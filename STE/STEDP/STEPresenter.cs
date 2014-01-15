using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEDP
{
    public class STEPresenter
    {
        
        public void STEPresenterConsoleOutput(STECL.STESimpleTest Test)
        {
            Console.WriteLine(Test.Note.TestNote);
            for (int i = 0; i < Test.TaskBlock.Count; i++)
            {
                Console.WriteLine("TaskBlock {0} :",i);
                for(int j = 0; j < Test.TaskBlock[i].Task.Count; j++)
                {
                    Console.WriteLine("\t Task {0} Question: " + Test.TaskBlock[i].Task[j].Question.QuestionText,j);
                    for (int k = 0; k < Test.TaskBlock[i].Task[j].Answer.Count; k++ )
                        Console.WriteLine("\t\t Answer {0} :" ,k);
                }
             Console.WriteLine();
            }
           
        }
    }
}
