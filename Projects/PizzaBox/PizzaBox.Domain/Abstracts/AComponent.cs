


namespace PizzaBox.Domain.Abstracts
{
    abstract public class AComponent 
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

        
    }

}