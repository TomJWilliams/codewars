using System;
using System.Linq;

namespace core
{
  public class CountingDuplicates
  {
    public static int DuplicateCount(string str)
    {
      return str.ToLower().GroupBy(x => x).Where(x => x.Count() > 1).Count();
    }
  }
}
