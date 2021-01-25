using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Inteface
{
   public interface IUnitOfWork : IDisposable
    {
        IBranchRepository Branches { get; }

        int Complete();
    }
}
