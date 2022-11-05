using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();// for Restful services the ffront-end also needs success/error messages, so put retur ndata into a DataResult.
        IDataResult<List<Product>> GetAllByCategory(int categoryId);
        IResult Add(Product product);
        bool CheckStock(int productId);
    }
}
