using AbstractFactory.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Class
{
    public class Ankaragucu : ITeam
    {
        public string getStadium()
        {
            return "19 MAYIS STADYUM";

           
        }
        public string getTeamColor()
        {
            return "Sarı-Lacivert";
        }
    } 
}
