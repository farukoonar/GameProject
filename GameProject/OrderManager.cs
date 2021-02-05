using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        Player _player;
        Campaign _campaign;
        public OrderManager(Player player,Campaign campaign)
        {
            _player = player;
            _campaign = campaign;
        }
        public void Sell(Game game)
        {
            Console.WriteLine(game.Name + ", " +_campaign.Name +" ile "+_player.FirstName + " isimli kişiye satıldı.");
        }
    }
}
