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
        /// <summary>
        /// _Application is a reference to IApplication interface which allows user to decide the application at run time.
        /// </summary>
        public IApplication? _Application;

        /// <summary>
        /// Work() can be overriden to make use of specific feature from user specified application.
        /// </summary>
        public abstract string Work();
    }
}
