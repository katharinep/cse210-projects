public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        if (product == null)
            Console.WriteLine("Cannot add a null product.");
        _products.Add(product);
    }

    public string CreatePackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProduct()}\n";
        }
        return packingLabel;
    }

    public string CreateShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetAddress().CompleteAddress()}";
    }

    public float CalculateTotal()
    {
        bool isInternational = _customer.GetAddress().InternationalResidence();
        float total = 0;
        foreach (var product in _products)
        {
            total += product.ProductCost();
        }
        //add shipping cost//
        total += isInternational ? 35 : 5;
        return total;
    }
}