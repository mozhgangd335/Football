using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Players.Contract.Dto
{
    public class PlayerGetDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime dateTime { get; set; }
    }
}
