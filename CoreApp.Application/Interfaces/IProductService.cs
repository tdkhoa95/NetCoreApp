﻿using System;
using System.Collections.Generic;
using CoreApp.Application.ViewModels.Product;
using CoreApp.Utilities.DTOs;

namespace CoreApp.Application.Interfaces
{
    public interface IProductService:IDisposable
    {
        List<ProductViewModel> GetAll();
        PageResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int pageSize, int page);
        ProductViewModel GetById(int id);
        ProductViewModel Add(ProductViewModel productViewModel);
        void Update(ProductViewModel productViewModel);
        void Delete(int id);
    }
}
