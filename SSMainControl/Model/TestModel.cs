using SSMainControl.Model.Enum;
using SSMainControl.ViewModels;
using SSMainControl.ViewModels.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMainControl.Model
{
    public class TestModel 
    {
        public TestModel()
        {
            this.Items = new List<ISSObjectViewModel>();
        }

        public List<ISSObjectViewModel> Items { get; set; }


        public static SSObject GetSolutionItems()
        {
            // In a real app this method would access a database.
            return new SSObject
            {
                Name = "Test Project",
                FileType = SSObjectType.SSProject,
                Items =
                {
                    new SSObject
                    {
                        Name="Testclass.cs",
                        FileType = SSObjectType.SSClass,
                    },
                    new SSObject
                    {
                        Name="ITestInterface.cs",
                        FileType = SSObjectType.SSInterface,
                    },
                    new SSObject
                    {
                        Name="Derp.xaml",
                        FileType = SSObjectType.SSXaml,
                        Items=
                        {
                            new SSObject
                            {
                                Name="Derp.xaml.cs",
                                FileType = SSObjectType.SSClass,
                            }
                        }
                    },
                    new SSObject
                    {
                        Name="NewClass.cs",
                        FileType = SSObjectType.SSClass,
                    },
                    new SSObject
                    {
                        Name="TestFolder",
                        FileType = SSObjectType.SSFolder,
                        Items=
                        {
                            new SSObject
                            {
                                Name="TestSubFolder",
                                FileType = SSObjectType.SSFolder,
                                Items=
                                {
                                    new SSObject
                                    {
                                        Name="TestClassInSubFolder.cs",
                                        FileType = SSObjectType.SSClass,
                                    },
                                    new SSObject
                                    {
                                        Name="TestClassInSubFolder2.cs",
                                        FileType = SSObjectType.SSClass,
                                    }
                                }
                            },
                            new SSObject
                            {
                                Name="TestClassInFolder.cs",
                                FileType = SSObjectType.SSClass,
                            }
                        }
                    }
                }
            };
        }
    }
}
