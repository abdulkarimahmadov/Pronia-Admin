namespace Pronia.Entities
{
    public class PlantCategory:BaseEntity
    {
        public Plant Plant { get; set; }
        public Category Category { get; set; }
    }
}
