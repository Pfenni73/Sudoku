using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.SolverLogic
{
    public interface ISolverLogic
    {
        void Solve();
        void SetContainers(List<FieldContainer> fieldContainers);
    }
}
