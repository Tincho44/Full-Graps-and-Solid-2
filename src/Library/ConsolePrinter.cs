using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public void PrintRecipe(Recipe recipe)
            {
                Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
                foreach (Step step in this.steps)
                {
                    Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
                }
            }

    }
}                