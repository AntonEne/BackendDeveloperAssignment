using System;
using System.Collections.Generic;
using Xunit;

namespace BackendDeveloperAssignment.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void ATMTest()
        {
            ATM ATM = new ATM();

            var withdrawal1 = ATM.Withdraw(1500);
            var withdrawal2 = ATM.Withdraw(700);
            var withdrawal3 = ATM.Withdraw(400);
            var withdrawal4 = ATM.Withdraw(1100);
            var withdrawal5 = ATM.Withdraw(1000);
            var withdrawal6 = ATM.Withdraw(700);
            var withdrawal7 = ATM.Withdraw(300);

            //0 == declined
            Assert.Equal(1500, withdrawal1);
            Assert.Equal(700, withdrawal2);
            Assert.Equal(0, withdrawal3);
            Assert.Equal(1100, withdrawal4);
            Assert.Equal(0, withdrawal5);
            Assert.Equal(700, withdrawal6);
            Assert.Equal(0, withdrawal7);
        }
    }
}
