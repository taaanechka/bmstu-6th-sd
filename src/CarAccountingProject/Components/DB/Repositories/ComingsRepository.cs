using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using BL;

namespace DB
{
    public class ComingsRepository: IComingsRepository
    {
        private ApplicationContext db;

        public ComingsRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public List<BL.Coming> GetComings(int offset = 0, int limit = -1)
        {
            if (offset < 0)
                offset = 0;

            var comings = db.Comings.OrderBy(p => p.Id).Skip(offset);

            if (limit > 0 && (offset + limit) <= db.Comings.Count())
            {
                comings = comings.Take(limit);
            }
            
            var comingsDB = comings.AsNoTracking().ToList();

            List<BL.Coming> res = new List<BL.Coming>();

            foreach (var elem in comingsDB)
            {
                res.Add(ComingConverter.DBToBL(elem));
            }

            return res;
        }

        public List<BL.Coming> GetComingsByDate(DateTime date)
        {
            List<Coming> comingsDB = (from p in db.Comings.AsNoTracking()
                            where p.ComingDate == date
                            select p).ToList();

            List<BL.Coming> res = new List<BL.Coming>();

            foreach (var elem in comingsDB)
            {
                res.Add(ComingConverter.DBToBL(elem));
            }

            return res;
        }

        public List<BL.Coming> GetComingsByUserId(int uId)
        {
            List<Coming> comingsDB = (from p in db.Comings.AsNoTracking()
                            where p.UserId == uId
                            select p).ToList();

            List<BL.Coming> res = new List<BL.Coming>();

            foreach (var elem in comingsDB)
            {
                res.Add(ComingConverter.DBToBL(elem));
            }

            return res;
        }

        public BL.Coming GetComingById(int id)
        {
            try
            {
                return ComingConverter.DBToBL(db.Comings.Find(id));
            }
            catch (Exception) // ArgumentNullException
            {
                throw new ComingNotFoundException();
            }
        }

        public void AddComing(BL.Coming coming)
        {
            // Validation
            try
            {
                Coming comingDB = ComingConverter.BLToDB(coming);
                ComingsValidator.ValidateComing(comingDB);
            }
            catch (Exception)
            {
                throw new ComingsValidatorFailException();
            }

            // Exists
            Coming? comingDupl = db.Comings.Find(coming.Id);

            if (comingDupl != null)
            {
                throw new ComingExistsException();
            }

            db.Comings.Add(ComingConverter.BLToDB(coming));
            db.SaveChanges();      
        }

        public void DeleteComing(int id)
        {
            Coming? coming = db.Comings.Find(id);

            // NotFound
            if (coming == null)
            {
                throw new ComingNotFoundException();
            }

            db.Comings.Remove(coming);
            db.SaveChanges();
        }
    }
}