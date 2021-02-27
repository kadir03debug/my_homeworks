using System;
using System.Collections.Generic;
using System.Text;
using Entities.concrete;
namespace Business.Apstract
{
   public interface ICarımagesService
    {
        void Add(Carımages cım);
        void Update(Carımages cım);
        List<Carımages> Getall();
        void Delete(Carımages cım);



    }
}
