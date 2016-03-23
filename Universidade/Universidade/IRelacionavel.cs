using System;

namespace Universidade
{
    public interface IRelacionavel<T> where T : IComparable
    {
        T Chaves { get; set; }
        int GetHashCode();
        bool Equals(object obj);
    }
}
