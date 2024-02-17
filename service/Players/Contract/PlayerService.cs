using service.Players.Contract.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Players.Contract
{
    public interface PlayerService
    {
        void Add(PlayerAddDTO dto);
        List<PlayerGetDTO> GetAll();
        PlayerGetDTO GetById(int id);
        void Update(int id, PlayerUpdateDTO dto);
        void Delete(int id);
        PlayerGetDTO GetByName(string name);
    }
}
