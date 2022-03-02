using AbstractFactory.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Class
{
    public class AnkaragucuFactory : ITeamAbstactFactory
    {
        public ITeam CreateTeam()
        {
            return new Ankaragucu();
        }
    }
}
