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
            return new List<string> { "indossate", "disonestà", "desistano", "denotassi", "detassino", "detonassi", "disonesta",

                "inddosate" }; //parolaTest
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
            List<string> anagrams = new List<string>();
            foreach (var p in parole)
            {
                if (IsAnagram(p, word))
                    anagrams.Add(p);
            }

            return anagrams;
        }

        public bool IsAnagram(string sourceWord, string candidateAnagram)
        {
            //test
            if (candidateAnagram.Length == sourceWord.Length)
            {
                List<char> paroledizionario = sourceWord.ToList();
                List<char> paroladaconfrontare = candidateAnagram.ToList();

                foreach (var i in paroladaconfrontare)
                {
                    if (paroledizionario.Contains(i))
                        paroledizionario.Remove(i);
                    else
                        return false;

                }
                


                //for (int i = 0; i < candidateAnagram.Length; i++)
                //{
                //    if (sourceWord.Contains(candidateAnagram[i]))
                //    {

                //    }
                //}


                return true;
            }
            else
                return false;

        }
    }
}
