using Core.Entities;
namespace Entities.Concrete
{
    public class Fuel:Entity<int>
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public Fuel()
        {

        }
        public Fuel(string name,int id)
        {
            Id = id;
            Name = name;
           
        }
    }
}
