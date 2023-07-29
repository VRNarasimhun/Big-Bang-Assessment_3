namespace KaniniTourismApplication.Interface
{
    public interface ITravellerAgentRepo<K,T>
    {
        public Task<T?> Get(K id);
        public Task<ICollection<T>?> GetAll();
    }
}
