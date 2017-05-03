using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class ComponentChecklist
    {
        private string strMachineType;
        private string strID;
        private string[,] strArrayTestAndDirection;

        public string Machine
        {
            get
            {
                return strMachineType;
            }
            set
            {

            }
        }

        public string IDNum
        {
            get
            {
                return strID;
            }
            set
            {

            }
        }

        public string[,] TestsAndDirections
        {
            get 
            {
                return strArrayTestAndDirection;
            }
        }

        public ComponentChecklist()
        {
            strMachineType = "Full Tower PC";

            strID = "PC101abcd1234";

            strArrayTestAndDirection =  new String [,] 
                                        {
                                            { "Check the case for scratches", "Examine the case closely for any scratches in the paint or the case."},
                                            { "Check for the presence of the CD-ROM drive", "Check if the CD-ROM drive is present."},
                                            { "Check the installed hard/SSD drive", "Check if the hard or SSD drive is present."},
                                            { "The PC powers up", "Check if the PC powers up."},
                                            { "The OS loads fine ", "Check if the OS loads without any problems."}
                                        };
        }

        public ComponentChecklist(string strMachine, string strIDNum, string[,] strTestNamesAndInstructions)
        {
            strMachineType = strMachine;

            strID = strIDNum;

            strArrayTestAndDirection = strTestNamesAndInstructions;
        }
    }
}
