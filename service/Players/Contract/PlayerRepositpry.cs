using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Players.Contract
{
   public interface PlayerRepositpry
    {

        void Add(Player player);
        Player GetById(int id);
        List<Player> GetAll();
        void Update(Player player);
        void Delete(Player player);
        Player GetName(string name);

    }
}
