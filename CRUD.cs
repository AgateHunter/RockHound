using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockHound
{
   
    interface CRUD
    {
        void AddRecord(Climb climb);
        void DeleteRecord(Climb climb);

        void UpdateRecord(int id, Climb climb);
        ICollection<Climb> GetAllRecords();

        Climb FindClimb(int id);

        

    }

 
    class ClimbRepository : CRUD
    {
        ClimbingEntities entities;

        public ClimbRepository()
        {
            entities = new ClimbingEntities();
        }

        public void AddRecord(Climb climb)
        {
            entities.Climbs.Add(climb);
            entities.SaveChanges();
        }

        public void DeleteRecord(Climb climb)
        {
            entities.Climbs.Remove(climb);
            entities.SaveChanges();
        }

        public Climb FindClimb(int id)
        {
            return entities.Climbs.Find(id);
        }

        public ICollection<Climb> GetAllRecords()
        {
            return entities.Climbs.ToList();
        }

        public int GetMaxId()
        {
            return entities.Climbs.Max(c => c.Id);
        }
        public void UpdateRecord(int id, Climb climb)
        {

            var climbupdate = entities.Climbs.Find(id);
            climbupdate.Location = climb.Location;
            climbupdate.Id = climb.Id;
            climbupdate.Date = climb.Date;
            climbupdate.Difficulty = climb.Difficulty;
            climbupdate.Rock_Type = climb.Rock_Type;
            climbupdate.Climb_Type = climb.Climb_Type;
            climbupdate.Name = climb.Name;



        }

    }
    interface CRUD2
    {
        ICollection<Country> GetAllRecords();
    }

    class CountryList : CRUD2
    {
        ClimbingEntities entities1;
        public ICollection<Country> GetAllRecords()
        {
           return entities1.Countries.ToList();
        }
    }
}

