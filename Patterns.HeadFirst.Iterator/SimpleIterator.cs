namespace Patterns.HeadFirst.Iterator
{
    public class SimpleIterator<T> : IIterator<T>
    {
        private readonly List<T> _entities;
        private int Position;

        public SimpleIterator(IEnumerable<T> entities)
        {
            _entities = entities.ToList();
        }
        public bool HasNext()
        {
            return Position < _entities.Count;
        }

        public T Next()
        {
            var entity = _entities[Position];
            Position++;
            return entity;
        }
    }
}