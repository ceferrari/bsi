using System;

namespace Universidade
{
    public interface IRelacionavel<T> where T : IComparable
    {
        Tuple<T, int> Chaves { get; set; }
        int GetHashCode();
        bool Equals(object obj);
    }
}
