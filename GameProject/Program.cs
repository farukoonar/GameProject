using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player{ Id = 1, FirstName = "Faruk", LastName = "Onar", BirthOfYear = 2000, IdentityNumber = "1234567891" };
            Campaign campaign = new Campaign { Id = 1, Name = "%40 İndirim", Discount = 40 };
            Game game = new Game { Id = 1, Name = "CS:GO", Price = 102 };

            PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());
            playerManager.Add(player);

            IOrderService orderService = new OrderManager(player, campaign);
            orderService.Sell(game);
        }
    }
}
