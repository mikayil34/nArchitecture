namespace Core.Persistence.Repositories;

public class Entity
{
    public int Id { get; set; }

    public Entity()
    {
    }

    public Entity(int id) : this()
    {
        Id = id;
    }
}
 
public class Entity<T>
{

    public T Id { get; set; }

    public Entity()
    {
    }

    public Entity(T id) : this()
    {
        Id = id;
    }
}