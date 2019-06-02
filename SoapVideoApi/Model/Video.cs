namespace SoapVideoApi.Model
{
    public class Video
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Video()
        {
            this.ID = "";
            this.Name = "";
            this.Price = 0;
            this.Description = null;
        }
        public Video(string id, string name, float price, string image, string description)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }
    }
}
