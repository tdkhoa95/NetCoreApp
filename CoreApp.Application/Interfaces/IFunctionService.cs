﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreApp.Application.ViewModels.System;

namespace CoreApp.Application.Interfaces
{
    public interface IFunctionService : IDisposable
    {
        void Add(FunctionViewModel function);
        Task<List<FunctionViewModel>> GetAll(string filter);
        IEnumerable<FunctionViewModel> GetAllWithParentId(string parentId);
        FunctionViewModel GetById(string id);
        void Update(FunctionViewModel function);
        void Delete(string id);
        bool CheckExistedId(string id);
        void UpdateParentId(string sourceId, string targetId, Dictionary<string, int> items);
        void ReOrder(string source, string target);

    }
}
