using System;

namespace Universidade
{
    public interface IRelacionavel<T> where T : IComparable
    {
        T Chaves { get; set; }
        bool Equals(object obj);
        int GetHashCode();
    }
}
