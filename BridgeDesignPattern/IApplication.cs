/******************************************************************************
* Filename    = IApplication.cs
*
* Author      = Yukta Salunkhe
*
* Product     = BridgeDesignPattern
* 
* Project     = BridgeDesignPattern
*
* Description = Implementer for Bridge Pattern.
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    /// <summary>
    /// Implementor Interface
    /// </summary>
    public interface IApplication
    {
        string UseFeature(string feature);
    }
}
