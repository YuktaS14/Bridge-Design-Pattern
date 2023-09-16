/******************************************************************************
* Filename    = BridgeDesignUnitTests.cs
*
* Author      = Yukta Salunkhe
*
* Product     = BridgeDesignPattern
* 
* Project     = UnitTests
*
* Description = BridgeDesignUnitTests contains test methods to validate the implementation of the Bridge Design Pattern.
*****************************************************************************/

using BridgeDesignPattern;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class BridgeDesignUnitTests
    {
        /// <summary>
        /// TestSendingFile tests the 'SendFile' feature of the WhatsApp.
        /// </summary>
        [TestMethod]
        public void TestSendingFile()
        {
            Features feature = new SendFile( "file.txt" )
            {
                _Application = new WhatsApp()
            };
            string returnValue = feature.Work();
            Assert.AreEqual( returnValue , "Sending File: file.txt using WhatsApp." );
        }

        /// <summary>
        /// TestMakingCall tests the 'MakeCall' feature of Discord.
        /// </summary>
        [TestMethod]
        public void TestMakingCall()
        {

            Features feature = new MakeCall( "John Doe" )
            {
                _Application = new Discord()
            };
            string returnValue = feature.Work();
            Assert.AreEqual( returnValue , "Calling: John Doe using Discord." );

        }

        ///<summary>
        /// TestSendingText tests the 'SendText' feature
        /// </summary>
        [TestMethod]
        public void TestSendingText() {

            Features feature = new SendText( "Hello! its Me" );
            string returnValue = feature.Work();
            Assert.AreEqual( returnValue , "Sending: {Hello! its Me} using WhatsApp." );

        }
    }
}
