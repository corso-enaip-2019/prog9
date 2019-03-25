using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppAnagrammi
{
    public interface IGameplay
    {
        void Run(IUiHandle uiHandle);
        string Description { get; }
        

    }
}
