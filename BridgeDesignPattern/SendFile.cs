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
        private readonly string _fileName;

        public SendFile(string file) {
            _fileName = file;
        }
        public override string Work()
        {
            _Application ??= new WhatsApp();
           return _Application.UseFeature("Sending File: " + _fileName);
        }

    }
}
