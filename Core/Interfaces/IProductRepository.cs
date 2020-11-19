using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        // Réupérer un produit avec son Id
        Task<Product> GetProductByIdAsync(int id);

        //Récupérer la liste des produits
        Task<IReadOnlyList<Product>> GetProductsAsync();

        //Récupérer la liste des marques des produits
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();

        //Récupérer la liste des types des produits
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();

    }
}
