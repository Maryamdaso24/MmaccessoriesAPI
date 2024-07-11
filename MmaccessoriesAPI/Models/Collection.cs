namespace MmaccessoriesAPI.Models
{
    public class Collection
    {
      
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public virtual List<Kinds> Kinds { get; set; }
        }
    }



