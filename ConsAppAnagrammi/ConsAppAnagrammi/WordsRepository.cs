using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppAnagrammi
{
    public interface IDictionaryLoader
    {
        List<string> LoadDictionary();
    }

    public class MemoryDictionaryLoader : IDictionaryLoader
    {
        public List<string> LoadDictionary()
        {
            return new List<string> { "sopra", "parso", "prosa", "aspro", "sparo", "saprò", "sparò" };
        }
    }

    public class WordsRepository
    {
        List<string> parole;

        public WordsRepository(IDictionaryLoader dictionaryLoader)
        {
            parole = dictionaryLoader.LoadDictionary();
        }





        public List<string> GetAnagrams(string word)
        {
            //TODO restituire lista di anagrammi della parola passata in base al dizionario
            return new List<string>();
        }

        public bool IsAnagram(string sourceWord, string candidateAnagram)
        {
            var anagrams = GetAnagrams(sourceWord);
            return anagrams.Contains(candidateAnagram);
        }
    }
}
