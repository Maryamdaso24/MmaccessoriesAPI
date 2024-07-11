using System.Text.Json.Serialization;

namespace MmaccessoriesAPI.Models
{
    public class Kinds 

    {
        
        
            public int Id { get; set; }
            public string Sku { get; set; } = string.Empty;
            public string Name { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public decimal Price { get; set; }
            public bool IsAvailable { get; set; }

            public int CollectionId { get; set; }
            [JsonIgnore]
            public virtual Collection Collection { get; set; }

        }
    }



