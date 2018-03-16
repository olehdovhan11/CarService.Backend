namespace CarService.DbAccess.Entities
{
    public class Photo : IEntity
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public int? ReviewId { get; set; }
        public Review Review { get; set; }
    }
}