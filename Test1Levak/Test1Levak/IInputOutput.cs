using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Levak
{
    public interface IInputOutput
    {
        string AskForString(string message);
        void WriteMessage(string message);
    }
}
