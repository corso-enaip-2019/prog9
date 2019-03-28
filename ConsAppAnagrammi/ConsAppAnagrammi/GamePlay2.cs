using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppAnagrammi
{
    class GamePlay2 //: IGameplay
    {
        readonly WordsRepository _wordsRepository;

        public string Description => "Sfida";

        public GamePlay2(WordsRepository wordsRepository)
        {
            _wordsRepository = wordsRepository;
        }

        public void Run(IUiHandle uiHandle)
        {
            string parolaInserita = uiHandle.AskForString("Inserisci una parola");



        }

        //public string RndString(MemoryDictionaryLoader memoryDictionaryLoader)
        //{
        //    Random rnd = new Random();

        //    int n= rnd.Next(0,);



        //}
    }
}
