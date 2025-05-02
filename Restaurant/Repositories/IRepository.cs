namespace Restaurant.Repositories
{
    public interface IRepository<Entity>
    {
        void Add(Entity Entity);
        void Update(int id, Entity Entity);
        void ChangeStatus(int id, Entity Entity);
        void Delete(int id, Entity Entity);
        Entity Find(int id);
        List<Entity> View();
        List<Entity> ViewClient();

    }
}
