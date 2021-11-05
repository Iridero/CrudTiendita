using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudTiendita.Models;
using Microsoft.EntityFrameworkCore;
namespace CrudTiendita.Repositories
{
    public class Repository<T> where T:class
    {
        private tienditaContext context;
        private DbSet<T> table=null;
        public Repository(tienditaContext context)
        {
            this.context = context;
            table = context.Set<T>()
;        }

        virtual public IEnumerable<T> GetAll()
        {
            
        }
    }
}
