using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Singletons
{
    public class StoreSingleton
    {
        public List<AStore> Stores { get; set; }

        public StoreSingleton()
        {
            Stores = new List<AStore>()
            {
                new FreddyPizza("Freddy's Store"),
                new MamasPizza("Mama's Store"),
                new PapasPizza("Papa's Store")
            };
//            Stores.Add(new FreddyPizza());
  //          Stores[0].Name = "Freddy Pizza";

            // {
            //     new FreddyPizza()
            //     {
            //         Name = "Freddy Pizza"  
            //     }
            // }
        }

    }

}