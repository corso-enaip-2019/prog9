using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppAnagrammi
{
    public interface IUiHandle
    {
        string AskForString(string message);

        void WriteMessage(string message);

    }
}
