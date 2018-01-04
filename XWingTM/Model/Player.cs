using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace XWingTM.Model
{
    public class Player
    {

        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public bool Allow_name_surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Faction { get; set; }
        public string Notes { get; set; }
        public string Location { get; set; }

    }
}
