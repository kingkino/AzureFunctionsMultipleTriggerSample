using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleTriggerSample.Logic
{
    public static class Logic
    {
        public static string GetMessage(int no)
        {
            var msg = "";
            switch(no)
            {
                case 1:
                    msg = "Hello World";
                    break;
                case 2:
                    msg = "Hello Japan";
                    break;
                case 3:
                    msg = "Hello Tokyo";
                    break;
                default: break;
            }
            return msg;
        }
    }
}
