using BussinessLayer.Abstract;
using DAL.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concreate
{
    public class YemekManager:IYemekService
    {
        IYemekDal _yemekdal;

        public YemekManager(IYemekDal yemekdal)
        {
            _yemekdal = yemekdal;
        }

        public List<Yemek> Getlist()
        {
            return _yemekdal.GetListAll();
        }

        public Yemek GetlistById(int id)
        {
            return _yemekdal.GetById(id);
        }

        public void TAdd(Yemek t)
        {
            _yemekdal.Insert(t);
        }

        public void TDelete(Yemek t)
        {
            _yemekdal.Delete(t);
        }

        public void TUpdate(Yemek t)
        {
            _yemekdal.Update(t);
        }
    }
}
