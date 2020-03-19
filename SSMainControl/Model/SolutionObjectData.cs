using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMainControl.Model
{
    public class SolutionObjectData
    {
        private static SSObject solutionItems;

        public SolutionObjectData()
        {
            solutionItems = new SSObject();
        }

        public static SSObject GetSolutionItems()
        {
            
            /**
             * Could use Calebs help here.
             * This is one way to build the objects. 
             * The name and file type can be self assigned if that makes it easier.
             * new SSObject
               {
                Name = "Test Project",
                FileType = SSObjectType.Project
                Items =
                {
                    new SSObject
                    {
                        Name="Testclass.cs",
                        FileType = SSObjectType.SSClass
                    },
                };
             * **/
            return solutionItems;
        }

        public static SSObject SelectedSolutionItems()
        {
            SSObject selectedSolutionItems = new SSObject();

            return selectedSolutionItems;
        }
    }
}
