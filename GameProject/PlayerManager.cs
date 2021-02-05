using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager : IPlayerService
    {
        IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public void Add(Player player)
        {
            if (_playerCheckService.CheckPlayer(player))
            {
                Console.WriteLine(player.FirstName + " eklendi.");
            }
            else
            {
                Console.WriteLine("Böyle bir kişi yok!");
            }
            
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " güncellendi.");
        }
    }
}
