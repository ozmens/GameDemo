using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class PlayerManager: IPlayerCheckService
    {
        public void Add(Player player)
        {
            CheckIfRealPerson(player);
            Console.WriteLine("Oyuncu sisteme kayıt edildi : " + player.FirstName + " " + player.LastName);
        }

        private bool CheckIfRealPerson(Player player)
        {
            return true;
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi : " + player.FirstName + " " + player.LastName);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu sistemden silindi : " + player.FirstName + " " + player.LastName);
        }
    }
}
