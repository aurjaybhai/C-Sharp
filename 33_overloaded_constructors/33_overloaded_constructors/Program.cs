// See https://aka.ms/new-console-template for more information

/*
Overloaded construtors ==> technique to create multiple constructors,
                            with a different set of parameters.
                            name + parameters = signature
*/

Pizza pizza = new Pizza("stuffed crust","red sauce","mozzarella","pepperoni");
Pizza pizza2 = new Pizza("stuffed crust","red sauce","mozzarella");



/*
If the customer wants pizza without toppings like a plain cheese pizza
We can't construct a pizza without a topping bcoz we only have one constructor
*/


class Pizza
{
    string bread;
    string sauce;
    string cheese;
    string toppings;
    
    public Pizza(string bread, string sauce, string cheese) // for pizza2
    {
        this.bread = bread;
        this.sauce = sauce;
        this.cheese = cheese;
    }
    
    public Pizza(string bread, string sauce, string cheese, string toppings)
    {
        this.bread = bread;
        this.sauce = sauce;
        this.cheese = cheese;
        this.toppings = toppings;
    }
}
