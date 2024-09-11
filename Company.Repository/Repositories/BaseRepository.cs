using Company.Data.Context;
using Company.Data.Models;
using Company.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Repositories
{
    public class BaseRepository<T> :IBaseRepository<T> where T : BaseEntity
    {
    
        private readonly CompanyDbContext _context;

        public BaseRepository(CompanyDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        
          =>  _context.Set<T>().Add(entity);
        



        public void Delete(T entity) 
        
           => _context.Remove(entity); 
            
        

        

        public IEnumerable<T> GetAll()
        =>_context.Set<T>().ToList();
          
        

        public T GetById(int? id)
        {
          return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        
           =>_context.Update(entity);
           
        
    }
}
