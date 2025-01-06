using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public abstract class User
{
    public string name { get; set; }
    public string phone { get; set; }
    public string address { get; set; }

    // Abstract method to calculate the price
    public abstract decimal CalculatePrice(int quantity, string pizzaSize);
    
}
public class Delivery : User
{
    
    public string pizzaSize { get; set; }
    public string toppings { get; set; }
    public int quantity { get; set; }
    public decimal totalPrice { get; set; }

    public override decimal CalculatePrice(int quantity, string pizzaSize)
    {
        if (pizzaSize == "Small")
        {
            return quantity * 1000;
        }
        else if (pizzaSize == "Medium")
        {
            return quantity * 1500;
        }
        else if (pizzaSize == "Large")
        {
            return quantity * 2000;
        }
        else
        {
            return 0;
        }
    }

}