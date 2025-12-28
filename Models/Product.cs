namespace Console1.Models
{
    public class Product
    {
        public int Id { get; set; }
        private string? Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name} costs {Price}";
        }

        public bool SetName(string Name)
        {
            this.Name = Name;
            return true;
        }
    }
}
