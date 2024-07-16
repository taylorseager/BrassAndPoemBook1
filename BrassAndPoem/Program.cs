List<Product> products = new List<Product>()
{
    new Product(name: "Trumpet", price: 50.75M, productTypeId: 1),
    new Product(name: "Falling Up by Shel Silverstein", price: 15.99M, productTypeId: 2),
    new Product(name: "The Final Flight by Unknown", price: 10.99M, productTypeId: 2),
    new Product(name: "French Horn", price: 45.98M, productTypeId: 1),
    new Product(name: "Tuba", price: 64.99M, productTypeId: 1),
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType(title: "Brass", id: 1),
    new ProductType(title: "Poem", id: 2),
};
//put your greeting here

//implement your loop here

void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }