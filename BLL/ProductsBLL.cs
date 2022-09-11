using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductsBLL
    {
        ProductsDAL _Pdal = new ProductsDAL();


        public ProductDTO GetProduct(int code)
        {
            Product p = _Pdal.GetProduct(code);
            ProductDTO currentProduct = ConvertProductToProductDTO(p);
            if (p == null)
                return null;
            return currentProduct;
        }


        public List<ProductDTO> GetAllProducts()
        {
            List<Product> prodacts = _Pdal.GetAllProducts();
            List<ProductDTO> productDTO = new List<ProductDTO>();
            foreach (var item in prodacts)
            {
                var p = ConvertProductToProductDTO(item);
                productDTO.Add(p);
            }
            return productDTO;
        }

        private ProductDTO ConvertProductToProductDTO(Product pro)
        {
            ProductDTO productDTO = new ProductDTO();
            productDTO.CodePicture = pro.CodePicture;
            productDTO.NamePicture = pro.NamePicture;
           if(pro.CodeCategory!=null)  productDTO.CodeCategory = (int)(pro.CodeCategory);
            if(pro.Price!=null) productDTO.Price = (int)pro.Price;
            productDTO.Image = pro.Image;
            if(pro.AcountInStore!=null)productDTO.AcountInStore = (int)pro.AcountInStore;
            return productDTO;
        }

        private Product ConvertProductToProductDetail(ProductDTO pro)
        {
            Product productDetail = new Product();
            productDetail.CodePicture = pro.CodePicture;
            productDetail.NamePicture = pro.NamePicture;
            productDetail.CodeCategory = pro.CodeCategory;
            productDetail.Price = pro.Price;
            productDetail.Image = pro.Image;
            productDetail.AcountInStore = pro.AcountInStore;

            return productDetail;
        }
        public List<Product> AddProduct(ProductDTO pro)
        {
            Product currentProduct = ConvertProductToProductDetail(pro);

            return _Pdal.AddProduct(currentProduct);
        }

        public List<Product> UppdateProduct(ProductDTO pro, int id)
        {
            Product currentProduct = ConvertProductToProductDetail(pro);

           
            return  _Pdal.UppdateProduct(currentProduct, id);
        }

        public List<Product> RemoveProduct(int id)
        {
            return _Pdal.RemoveProduct(id);
        }

        public List<Product> GetAllProductsInCategory(int codeCategory)
        {
            return _Pdal.GetAllProductsInCategory(codeCategory);
        }



    }
}
