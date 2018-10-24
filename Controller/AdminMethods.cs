using System;
using System.Collections.Generic;
using System.Text;

namespace Controllers
{
    interface AdminMethods<T> where T : class
    {
        void Create(T t);  
        void Update(T t);
        void Delete(T t);
    }
}
