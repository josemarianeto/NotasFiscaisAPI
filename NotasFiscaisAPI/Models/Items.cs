namespace NotasFiscaisAPI.Models
{
    public class Items
    {
        public Guid id { get; set; }
        public string Name { get; set; }

        public double Value { get; set; }

        public DateTime Bought { get; set; }

        public string Description { get; set; }

        public string PathName { get; set; }

        public Category Category { get; set; }

        public Guid CategoryID { get; set; }

        
        public Items()
        {
            this.id = new Guid();
        }
    }
}
