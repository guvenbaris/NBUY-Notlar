using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Common
{
   public interface IOrm <T> where T: class,new()
   {
        List<T> Select();
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);




   }
}
