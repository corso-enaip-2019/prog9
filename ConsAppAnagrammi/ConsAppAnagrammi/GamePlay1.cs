using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppAnagrammi
{
    public class GamePlay1 : IGameplay
    {
        readonly WordsRepository _wordsRepository;

        public string Description => "Allenamento: Inserisci una parola per visualizzare i possibili anagrammi";

        public GamePlay1(WordsRepository wordsRepository)
        {
            _wordsRepository = wordsRepository;
        }

        public void Run(IUiHandle uiHandle)
        {            
            string parolaInserita = uiHandle.AskForString("Inserisci una parola");

            List<string> anagrams = _wordsRepository.GetAnagrams(parolaInserita);
            uiHandle.WriteMessage($"Gli anagrammi di { parolaInserita } sono:");
            foreach (var anagram in anagrams)
            {
                uiHandle.WriteMessage(anagram); 
            }
        }
    }
}
