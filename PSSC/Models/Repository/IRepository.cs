using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository
{
    interface IRepository
    {
        Models.Subject.Subject GetById(Guid id);
        void Add(Models.Subject.Subject entity);
        void Delete(Models.Subject.Subject entity);
        void Update(Models.Subject.Subject entity);
    }
}
