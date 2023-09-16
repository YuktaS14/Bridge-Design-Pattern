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
        private readonly string _name;

        public MakeCall(string name) { 
            _name = name;
        }
        public override string Work()
        {
            _Application ??= new WhatsApp();
           return _Application.UseFeature("Calling: " + _name);
        }        
    }
}
