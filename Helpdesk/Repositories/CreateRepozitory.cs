using Helpdesk.Data;
using Helpdesk.Data.Migrations;
using Helpdesk.Models;

namespace Helpdesk.Repositories
{
    public class CreateRepozitory
    {
        private readonly ApplicationDbContext _db;
        public CreateRepozitory(ApplicationDbContext db)
        {
            _db = db;
        }
        public int Create(Companys obj)
        {
            _db.Comp.Add(obj);
            return _db.SaveChanges();
        }
        public void Create1(Programs obj)
        {
            _db.Prog.Add(obj);
            _db.SaveChanges();
        }

        public void Create2(Notification obj)
        {
            _db.Notific.Add(obj);
            _db.SaveChanges();
        }

        public void Create3(Vers obj)
        {
            _db.Vers.Add(obj);
            _db.SaveChanges();
        }
        public void Create4(Request obj)
        {
            _db.Req.Add(obj);
            _db.SaveChanges();
        }


        public void Update(Companys obj)
        {
            throw new NotImplementedException();
        }

        public void Delete (int id)
        {
            throw new NotImplementedException();
        }

        public List<Companys> GetAll()
        {
            throw new NotImplementedException();
        }

     
    }
}
