using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Player
    {
        public Player(string fullName, DateTime dateTime)
        {
            FullName = fullName;
            this.dateTime = dateTime;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime dateTime { get; set; }
        public int TeamId { get; set; }
        Team Team { get; set; }

        public void Edit(string name,DateTime dateTime)
        {
            if(name !=   null)
            {
                name = name;
            }
            if (dateTime != dateTime)
            {

            }dateTime=dateTime;
        }

    }
}
