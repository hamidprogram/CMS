using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayers
{
    public class PageGroupRepository : IPageGroupRepository
    {
        MyCmsContext db = new MyCmsContext();
        public IEnumerable<PageGroup> GetAllGroups()
        {
            return db.pageGroups;
        }

        public PageGroup GetGroupById(int groupId)
        {
            return db.pageGroups.Find(groupId);
        }

        public bool InsertGroup(PageGroup pageGroup)
        {
            try
            {
                db.pageGroups.Add(pageGroup);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateGroup(PageGroup pageGroup)
        {
            try
            {
                db.Entry(pageGroup).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteGroup(int groupId)
        {
            try
            {
                var group = GetGroupById(groupId);
                DeleteGroup(group);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteGroup(PageGroup pageGroup)
        {
            try
            {
                db.Entry(pageGroup).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void save()
        {
            db.SaveChanges();
        }

    }
}
