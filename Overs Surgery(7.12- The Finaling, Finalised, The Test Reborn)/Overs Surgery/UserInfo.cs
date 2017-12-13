using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overs_Surgery
{
    class UserInfo
    {
        //Creating the 1st login's private strings
        private string u1UseName = "Christian";
        private string u1Pass = "one";
        //Creating get methods for the first username and password
        public string U1useName
        {
            get
            {
                return u1UseName;
            }
        }
        public string U1Pass
        {
            get
            {
                return u1Pass;
            }
        }

        //Creating the 2nd login's private strings
        private string u2UseName = "Ricardo";
        private string u2Pass = "two";
        //Creating get methods for the second username and password
        public string U2useName
        {
            get
            {
                return u2UseName;
            }
        }
        public string U2Pass
        {
            get
            {
                return u2Pass;
            }
        }

        //Creating the 3rd login's private strings
        private string u3UseName = "Niall";
        private string u3Pass = "three";
        //Creating get methods for the third username and password
        public string U3useName
        {
            get
            {
                return u3UseName;
            }
        }
        public string U3Pass
        {
            get
            {
                return u3Pass;
            }
        }

    }
}
