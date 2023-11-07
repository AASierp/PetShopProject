using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopPart1
{
	public class ProductLogic
	{
		private Dictionary<string, DogLeash> _newLeash;

		private Dictionary<string, CatFood> _meowMix;			

		private List<Product> _products;

		public ProductLogic()
		{
			_products = new List<Product>();
			_newLeash = new Dictionary<string, DogLeash>();
			_meowMix = new Dictionary<string, CatFood>();
		}

		public void addProduct(Product product)
		{
			_products.Add(product); 

			if (product is DogLeash) 
			{
				_newLeash.Add(product.Name, product as DogLeash);
			}
			if (product is CatFood)
			{
				_meowMix.Add(product.Name, product as CatFood);
			}
		}

		public List<Product> GetAllProducts() 
		{
			return _products;
		}

        public DogLeash GetDogLeashByName(string name)
        {
			try
			{
				return _newLeash[name];
			}
			catch (Exception ex) 
			{
				return null;
			}
        }	
    }
}