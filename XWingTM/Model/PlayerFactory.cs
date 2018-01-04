using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace XWingTM.Model
{
    public class PlayerFactory
    {
        public MongoClient client;
        public MongoServer server;
        public MongoDatabase db;
        public MongoCollection<Player> collection;

        public PlayerFactory(MongoDatabase db)
        {
            this.db = db;
            this.collection = db.GetCollection<Player>("Players");
        }

        public MongoCursor<Player> GetList()
        {
            return collection.FindAll();
        }

        public Boolean Remove(Player player)
        {
            collection.Remove(Query.EQ("_id", player.Id));
            return true;
        }

        public Boolean Save(Player player) {
            try
            {
                Boolean result = false;

               /* BsonDocument b_player = new BsonDocument();

                if (player.Name != null && !player.Name.Equals(""))
                    b_player.Add("Name", player.Name);

                if (player.Surname != null && !player.Surname.Equals(""))
                    b_player.Add("Surname", player.Surname);

                if (player.Nickname != null && !player.Nickname.Equals(""))
                    b_player.Add("Nickname", player.Nickname);

                b_player.Add("Allow_name_surname", player.Allow_name_surname);

                if (player.Email != null && !player.Email.Equals(""))
                    b_player.Add("Email", player.Email);

                if (player.Phone != null && !player.Phone.Equals(""))
                    b_player.Add("Phone", player.Phone);

                if (player.Faction != null && !player.Faction.Equals(""))
                    b_player.Add("Faction", player.Faction);

                if (player.Notes != null && !player.Notes.Equals(""))
                    b_player.Add("Notes", player.Notes);

                if (player.Location != null && !player.Location.Equals(""))
                    b_player.Add("Location", player.Location);*/

                collection.Save(player);

                return true;
            }
            catch (Exception e) {
                return false;
            }
           
        }
    }
}
