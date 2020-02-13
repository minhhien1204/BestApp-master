using BestApp.Core.Models;
using Repository.Repositories;
using Service;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BestApp.Services.CatService;   //The using static directive designates a type whose static members 
                                            //and nested types you can access without specifying a type name
namespace BestApp.Services
{
    public class CatService : Service<Cat>, ICatService //or  CatService.ICatService neu k using static CatService
    {
        public interface ICatService : IService<Cat> //
        {
            IQueryable<Cat> GetAllCats();
            Task<IQueryable<Cat>> GetAllCatsAsync(); //coi lại 
        }
        private readonly IRepositoryAsync<Cat> _repository;

        public CatService(IRepositoryAsync<Cat> repository) : base(repository) //DI dc dung de giam bot su chat che giua 2 component
        {
            _repository = repository;
        }

        public override void Insert(Cat entity)
        {
            // e.g. add business logic here before inserting
            base.Insert(entity);
        }

        public IQueryable<Cat> GetAllCats()
        {
            // add business logic here
            return _repository.Queryable();
        }

        public Task<IQueryable<Cat>> GetAllCatsAsync()
        {
            return Task.Run(() => GetAllCats());
        }

    }
}
