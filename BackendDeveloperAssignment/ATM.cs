using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDeveloperAssignment
{
    public class ATM
    {
        List<int> Bills = new List<int>()
            {
                1000,
                1000,
                500,
                500,
                500,
                100,
                100,
                100,
                100,
                100
            };

        public int Withdraw(int requestedAmount)
        {
            int withdrawRequest = requestedAmount;
            List<int> removeList = new List<int>();

            //Starts with largest bills to make sure it will only take smaller if needed.
            for (int i = 0; i < Bills.Count; i++)
            {
                int bill = Bills[i];

                if (withdrawRequest >= bill)
                {
                    withdrawRequest -= bill;
                    removeList.Add(bill);
                }

            }

            if (withdrawRequest == 0)
            {
                //Removes bills if withdraw was successful.
                foreach (var bill in removeList)
                {
                    Bills.Remove(bill);
                }
                return requestedAmount;
            }

            //Will return 0 (declined) if "withdrawRequest" requirement is not matched.
            return 0;
        }
    }
}
