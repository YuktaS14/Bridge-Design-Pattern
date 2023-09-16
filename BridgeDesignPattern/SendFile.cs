/******************************************************************************
* Filename    = SendFile.cs
*
* Author      = Yukta Salunkhe
*
* Product     = BridgeDesignPattern
* 
* Project     = BridgeDesignPattern
*
* Description = Provides functionality of sending files through various applications
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    /// <summary>
    /// Refined Abstraction
    /// </summary>
    public class SendFile : Features
    {  
        /// <summary>
        /// _fileName stores the name of the file, which user wants to send.
        /// </summary>
        private readonly string _fileName;

        /// <summary>
        /// SendFile class can be used to implement different functionalities needed for sending a file from different applications. 
        /// </summary>
        public SendFile(string file) {
            _fileName = file;
        }

        /// <summary>
        /// By default the Application used would be WhatsApp.
        /// Work() is overriden to use the SendFile feature.
        /// </summary>
        public override string Work()
        {
            _Application ??= new WhatsApp();
           return _Application.UseFeature("Sending File: " + _fileName);
        }

    }
}
