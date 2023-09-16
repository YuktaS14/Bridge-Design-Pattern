/******************************************************************************
* Filename    = SendText.cs
*
* Author      = Yukta Salunkhe
*
* Product     = BridgeDesignPattern
* 
* Project     = BridgeDesignPattern
*
* Description = Abstract logic class which has a reference to bridge component (IApplication)
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class Features
    {
        public IApplication? _Application;
        
        public abstract string Work();
    }
}
