using System;
using System.Collections.Generic;
using System.Text;
using core.Utilities.Externalprocessor;
using core.DataAccess;
using DataAccess.Apstract;
using Business.Apstract;
using Entities.concrete;

namespace Business.Concrete
{
   public class Carımagesmanager:ICarımagesService
    {
        ICarımagesdal _carımagesdal;
        public Carımagesmanager(ICarımagesdal carımagesdal )
        {
            _carımagesdal = carımagesdal;
        }

        public void Add(Carımages cım)
        {
            bool result = Externalfileprocessortool.fileextensionsfilters(png, jpg);
            if (result == true) { cım.path = Externalfileprocessortool.Fileaddres; _carımagesdal.Add(cım); } else { throw new Exception("resim dosyası vermeniz gerekmektedir"); }

        }

        public void Delete(Carımages cım)
        {
            _carımagesdal.Delete(cım);
        }

        public List<Carımages> Getall()
        {
            return _carımagesdal.getall();
        }

        public void Update(Carımages cım)
        {
            bool result = Externalfileprocessortool.fileextensionsfilters("jpg", "png");
            if (result == true) { cım.path = Externalfileprocessortool.Fileaddres; _carımagesdal.Update(cım); } else { throw new Exception("bir resim dosyası girmeniz gerekmektedir. lütfen tekrar deneyiniz"); }

        }
    }
}
