using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckPlayer(Player player)
        {
            if (player.BirthOfYear==2000 && player.FirstName=="Faruk" && player.LastName=="Onar"&& player.IdentityNumber=="1234567891")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
