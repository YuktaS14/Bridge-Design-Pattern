/******************************************************************************
* Filename    = MakeCall.cs
*
* Author      = Yukta Salunkhe
*
* Product     = BridgeDesignPattern
* 
* Project     = BridgeDesignPattern
*
* Description = Provides functionality of making call through various applications
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
    /// Refined Abstraction
    /// </summary>
    public class MakeCall : Features
    {
        /// <summary>
        /// _name stores the name of the the person whom user wants to contact.
        /// </summary>
        private readonly string _name;

        /// <summary>
        /// MakeCall class can be used to implement different functionalities needed for using call feature. 
        /// </summary>
        public MakeCall(string name) { 
            _name = name;
        }

        /// <summary>
        /// By default the Application used would be WhatsApp.
        /// Work() is overriden to use the MakeCall feature.
        /// </summary>
        public override string Work()
        {
            _Application ??= new WhatsApp();
           return _Application.UseFeature("Calling: " + _name);
        }        
    }
}
