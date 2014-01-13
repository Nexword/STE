using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STECL;
namespace STEIL
{
    public class STEDataLoader
    {
        //тестовая версия. Получили из базы XML, сформировали классы, вернули объектом готовый тест.
        public STESimpleTest STEMakeStructure()
        {
            STESimpleTest simpleTest = new STESimpleTest();
            STETaskBlock simpleTaskBlock = new STETaskBlock();
            STETask simpleTask = new STETask();
            STEQuestion quest = new STEQuestion();
            STEAnswer answer = new STEAnswer();
            
            //Заполнение снизу вверх
            quest.QuestionText = "Как написать этот проект быстро и качественно?";
            for (int i = 0; i < 5; i++)
            {
                simpleTask.Answer.Add(answer);
                simpleTask.Answer[0].Id = i;
            }
            simpleTask.Question = quest;
            for (int i = 0; i < 5; i++ )
            {
                simpleTask.Id = i;
                simpleTaskBlock.Task.Add(simpleTask);

            }
            simpleTest.Note.TestNote = "Это пробный тест, французские булочки";
            for (int i = 0; i < 5; i++)
            {
                simpleTaskBlock.Id = i;
                simpleTest.TaskBlock.Add(simpleTaskBlock);
            }


            return simpleTest;
        }
    }
}
