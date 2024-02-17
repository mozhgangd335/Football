using service.Players.Contract.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Teams.Contract
{
    public interface TeamService
    {
        void Add(PlayerAddDTO dto);
        List<PlayerGetDTO> GetAll();
        PlayerGetDTO GetById(int id);
        void Update(int id, PlayerUpdateDTO dto);
        void Delete(int id);
        PlayerGetDTO GetByName(string name);
    }
}
