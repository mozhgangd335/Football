using Contracr;
using Entities;
using service.Players.Contract;
using service.Players.Contract.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace service.Players
{
    public class AppServicePlayer : PlayerService
    {
        private readonly PlayerRepositpry _playerrepository;
        private readonly IUnitOfWork _unit;
        public void Add(PlayerAddDTO dto)
        {
            var player = new Player(dto.FullName, dto.dateTime);
            var player1 = _playerrepository.GetName(dto.FullName);
            if (player.FullName == player1.FullName)
            {
                throw new Exception("this name is duplicade");
            }
          
            else
            {
                _playerrepository.Add(player);
                _unit.Complete();
                _unit.Commit();
            }


        }

        public void Delete(int id)
        {
            var player = _playerrepository.GetById(id);
            
            if (player == null)
            {
                throw new Exception("this player not found");
            }
            _playerrepository.Delete(player);
        }

        public List<PlayerGetDTO> GetAll()
        {
            var players = _playerrepository.GetAll();
            var playersDTO = new List<PlayerGetDTO>();
            foreach (var player in players)
            {
                var playerDTO = new PlayerGetDTO()
                {
                    FullName = player.FullName,
                    Id = player.Id,


                };
                playersDTO.Add(playerDTO);
            }
            return playersDTO;
        }

        public PlayerGetDTO GetById(int id)
        {
            var player = _playerrepository.GetById(id);
            if (player == null)
            {
                throw new Exception();
            }
            var playerDTO = new PlayerGetDTO()
            {
                FullName = player.FullName,
                Id = player.Id,

            };


            return playerDTO;
        }

        public PlayerGetDTO GetByName(string name)
        {
            var player=_playerrepository.GetName(name);
            if(player == null)
            {
                throw new Exception("this player not found");
            }
            var playerDTO = new PlayerGetDTO()
            {
                FullName = player.FullName,
              
            };
            return playerDTO;
        }

        public void Update(int id, PlayerUpdateDTO dto)
        {
            var player = _playerrepository.GetById(id);
            if (player == null)
            {
                throw new Exception("player not found");
            }
            _playerrepository.Update(player);
            _unit.Complete();
        }

    }
}
