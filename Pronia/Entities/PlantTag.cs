namespace Pronia.Entities
{
    public class PlantTag:BaseEntity
    {
        public Tag Tag { get; set; }
        public Plant Plant { get; set; }
    }
}
