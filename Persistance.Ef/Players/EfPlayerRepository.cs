using Entities;
using Microsoft.EntityFrameworkCore;
using service.Players.Contract;
using service.Players.Contract.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Ef.Players
{
    public class EfPlayerRepository : PlayerRepositpry
    {
        private EfDataContext _Context;
        public EfPlayerRepository(EfDataContext context)
        {
            _Context = context;
        }
        public void Add(Player player)
        {
            _Context.Players.Add(player);
        }

        public void Delete(Player player)
        {
            _Context.Players.Remove(player);
        }

        public List<Player> GetAll()
        {
            return _Context.Players.ToList();
        }

        public Player GetById(int id)
        {
            return _Context.Players.FirstOrDefault(c => c.Id == id);
        }

        public Player GetName(string name)
        {
            return _Context.Players.FirstOrDefault(a => a.FullName == name);
        }

        public void Update(Player player)
        {
            _Context.Players.Update(player);
        }
    }
}
