using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PYHDATA.NETFramework.Data;
using PYHDATA.NETFramework.Models;

namespace HMZ.App.Services
{
    public class ItemService
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public ItemService()
        {
        }

        public List<Item> GetAll()
        {
            return _context.Items.OrderByDescending(x => x.CreatedAt).ToList();
        }
        public int Add(Item item)
        {
            _context.Items.Add(item);
            return _context.SaveChanges();
        }
        public int Update(Item item, string id)
        {
            var itemToUpdate = _context.Items.FirstOrDefault(x => x.Id.ToString().Equals(id));
            if (itemToUpdate == null)
            {
                return 0;
            }
            itemToUpdate.Name = item.Name;
            itemToUpdate.Desciption = item.Desciption;
            itemToUpdate.ImageUrl = item.ImageUrl;
            itemToUpdate.CateogryName = item.CateogryName;
            itemToUpdate.Location = item.Location;
            itemToUpdate.Status = item.Status;

            _context.Entry(itemToUpdate).State = EntityState.Modified;
            return _context.SaveChanges();
        }
        public int Delete(string id)
        {
            var itemToDelete = _context.Items.FirstOrDefault(x => x.Id.ToString().Equals(id));
            if (itemToDelete == null)
            {
                return 0;
            }
            _context.Items.Remove(itemToDelete);
            return _context.SaveChanges();
        }
        //  search by name 
        public Item GetItemByName(string name)
        {
            return _context.Items.FirstOrDefault(i => i.Name == name);
        }
    }

}
