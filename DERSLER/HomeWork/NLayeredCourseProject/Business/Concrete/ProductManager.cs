using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using FluentValidation.TestHelper;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal; //field

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),"Ürünler Listelendi");
        }
        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == id),"Ürün getirildi.");
        }



        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            // Burada Validator'ün instance oluşturduk ve o şekilde validation yaptık.///////////////////7
            //var productValidator = new ProductValidator();
            //var validateResult = productValidator.Validate(product);
            //if (!validateResult.IsValid)
            //{
            //    throw new ValidationException(validateResult.Errors);
            //}
            //_productDal.Add(product);
            //return new SuccessResult("Ürün eklendi");

            //Validation aracı yazdık kod tekrarı olmaması için.///////////////////////////
            //ValidationTool.Validate(new ProductValidator(),product); 

            // iş Kuralları if bloğu ile./////////////////////////////
            //if (CheckIfProductCountOfCorrect(product.CategoryId).Success && CheckIfProductNameExists(product.ProductName).Success)
            //{
            //    _productDal.Add(product);
            //    return new SuccessResult("Ürün eklendi");
            //}

            //return new ErrorResult();

            //İş Kurallarını tek bir yerden çalıştırmak için./////////////////////////
            //IResult result = BusinessRules.Run(CheckIfProductCountOfCorrect(product.CategoryId),
            //    CheckIfProductNameExists(product.ProductName));

            //if (result != null)
            //{
            //    return result;
            //}
            //_productDal.Add(product);
            //return new SuccessResult("Product Added");
            
            _productDal.Add(product);
            return new SuccessResult();

        }
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult("Ürün güncellendi.");
        }
        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult("Ürün Silindi");
        }

        private IResult CheckIfProductCountOfCorrect(int categoryId)
        {
            var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;
            if (result >= 20)
            {
                return new ErrorResult("Bu kategori ye daha fazla ürün eklenemez");
            }

            return new SuccessResult();
        }
        private IResult CheckIfProductNameExists(string productName)
        {
            var result = _productDal.GetAll(p => p.ProductName == productName).Any();
            if (result)
            {
                return new ErrorResult("Aynı isimde ürün eklenemez");
            }
            return new SuccessResult();
        }
    }
}
