/******************************************************************************
* Filename    = WhatsApp.cs
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

namespace BridgeDesignPattern
{
    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class WhatsApp : IApplication
    {
        /// <summary>
        /// UseFeature allows you to use a feature provided by WhatsApp Application.
        /// </summary>
        public string UseFeature(string feature)
        {
            return (feature + " using WhatsApp.");
        }
    }
}
