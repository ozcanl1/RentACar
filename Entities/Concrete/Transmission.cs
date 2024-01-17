using Core.Entities;
namespace Entities.Concrete
{
    public class Transmission : Entity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Transmission()
        {

        }
        public Transmission(string name, int id)
        {
            Id = id;
            Name = name;

        }
    }
}
