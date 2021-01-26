using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
