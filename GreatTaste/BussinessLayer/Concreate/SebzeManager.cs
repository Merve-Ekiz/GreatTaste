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
   public class SebzeManager:ISebzeService
    {
        ISebzeDal _sebzeDal;

        public SebzeManager(ISebzeDal sebzeDal)
        {
            _sebzeDal = sebzeDal;
        }

        public List<Sebze> Getlist()
        {
            return _sebzeDal.GetListAll();
        }

        public Sebze GetlistById(int id)
        {
            return _sebzeDal.GetById(id);
        }

        public void TAdd(Sebze t)
        {
            _sebzeDal.Insert(t);
        }

        public void TDelete(Sebze t)
        {
            _sebzeDal.Delete(t);
        }

        public void TUpdate(Sebze t)
        {
            _sebzeDal.Update(t);
        }
    }
}
