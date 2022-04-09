﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface ITermRepository
    {
        IEnumerable<Term> GetAll();

        Task AddAsync(Term entity);

        void Update(Term entity);

        void Delete(int id);

        void DeleteRange(IEnumerable<Term> entity);

        Task SaveChangesAsync();
    }
}
