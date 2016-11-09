using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Sort
{
    public interface ISort
    {
        List<Card> Sort(List<Card> cards);
    }
}
