/******************************************************************************
* Filename    = SendText.cs
*
* Author      = Yukta Salunkhe
*
* Product     = BridgeDesignPattern
* 
* Project     = BridgeDesignPattern
*
* Description = Provides functionality of sending text through various applications
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    /// <summary>
    /// Refined Abstraction
    /// </summary>
    public class SendText : Features
    {
        private readonly string _text;
     
        public SendText(string text) {
            _text = text; 
        }
        public override string Work()
        {
            _Application ??=  new WhatsApp();
            return _Application.UseFeature("Sending: {"+ _text +"}");   
        }
}

}
