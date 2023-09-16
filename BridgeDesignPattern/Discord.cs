/******************************************************************************
* Filename    = Discord.cs
*
* Author      = Yukta Salunkhe
*
* Product     = BridgeDesignPattern
* 
* Project     = BridgeDesignPattern
*
* Description = Concrete Implementor of IApplication interface
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BridgeDesignPattern
{
    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class Discord : IApplication
    {
        public string UseFeature(string feature)
        {
            return (feature + " using Discord.");
        }
    }
}
