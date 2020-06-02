using System;

namespace Sceny.DependencyInjection
{
    public interface IFactory<T>
    {
        T Create();
    }

    public class Factory<T> : IFactory<T>
    {
        private readonly Func<T> _createFunc;

        public Factory(Func<T> createFunc) => _createFunc = createFunc ?? throw new ArgumentNullException(nameof(createFunc));

        public T Create() => _createFunc();
    }
}