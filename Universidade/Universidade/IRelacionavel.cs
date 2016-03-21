using System;

namespace Universidade
{
    public interface IRelacionavel
    {
        int Codigo { get; set; }
        Tuple<int, int> Chaves { get; set; }
    }
}
