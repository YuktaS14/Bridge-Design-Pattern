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
        /// <summary>
        /// _text stores the message which user wants to send.
        /// </summary>
        private readonly string _text;

        /// <summary>
        /// SendText class can be used to implement different functionalities needed for sending text. 
        /// </summary>
        public SendText(string text) {
            _text = text; 
        }
        
        /// <summary>
        /// By default the Application used would be WhatsApp.
        /// Work() is overriden to use the SendText feature.
        /// </summary>
        public override string Work()
        {
            _Application ??=  new WhatsApp();
            return _Application.UseFeature("Sending: {"+ _text +"}");   
        }
}

}
