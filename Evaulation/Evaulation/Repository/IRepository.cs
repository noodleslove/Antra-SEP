namespace Evaulation.Repository
{
    public interface IRepository<T>
    {
        public List<T> GetAll();
        public List<T> Search(Predicate<T> predicate);
    }
}