using System;
interface IPaymentStrategy{
    void Pay(decimal amount);}
class CreditCardPayment : IPaymentStrategy{
    public void Pay(decimal amount){
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }}
class PayPalPayment : IPaymentStrategy{
    public void Pay(decimal amount){
        Console.WriteLine($"Paid {amount} using PayPal.");
    }}
class UpiPayment : IPaymentStrategy{
    public void Pay(decimal amount){
        Console.WriteLine($"Paid {amount} using UPI.");
    }}
class ShoppingCart{
    private IPaymentStrategy paymentStrategy;
public void SetPaymentStrategy(IPaymentStrategy strategy)    {
        paymentStrategy = strategy;
    }
public void Checkout(decimal amount)    {
        paymentStrategy.Pay(amount);
    }}
class Program{
    static void Main(){
        ShoppingCart cart = new ShoppingCart();
        cart.SetPaymentStrategy(new CreditCardPayment());
        cart.Checkout(500);
        cart.SetPaymentStrategy(new PayPalPayment());
        cart.Checkout(1000);
        cart.SetPaymentStrategy(new UpiPayment());
        cart.Checkout(750);
    }
}
