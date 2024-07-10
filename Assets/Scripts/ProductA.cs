using UnityEngine;

public class ProductA : MonoBehaviour, IProduct
{
    [SerializeField] string _productName = "ProductA";
    public string ProductName { get => ProductName; set => ProductName = value; }
    private ParticleSystem particleSystem;

    public void Initialize()
    {
        gameObject.name = _productName;
        particleSystem = GetComponentInChildren<ParticleSystem>();
        particleSystem?.Stop();
        particleSystem?.Play();
    }
}

public class ConcreteFactoryA : Factory
{
    [SerializeField] ProductA productPrefab;

    public override IProduct GetProduct(Vector3 position)
    {
        GameObject instance = Instantiate(productPrefab.gameObject, position, Quaternion.identity);

        ProductA newProduct = instance.GetComponent<ProductA>();

        newProduct.Initialize();
        return newProduct;
    }
}
