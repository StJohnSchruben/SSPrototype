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
                Items =
                {
                    new SSObject
                    {
                        Name="Testclass.cs",
                    },
                    new SSObject
                    {
                        Name="ITestInterface.cs",
                    },
                    new SSObject
                    {
                        Name="Derp.xaml",
                        Items=
                        {
                            new SSObject
                            {
                                Name="Derp.xaml.cs",
                            }
                        }
                    },
                    new SSObject
                    {
                        Name="NewClass.cs",
                    },
                    new SSObject
                    {
                        Name="TestFolder",
                        Items=
                        {
                            new SSObject
                            {
                                Name="TestSubFolder",
                                Items=
                                {
                                    new SSObject
                                    {
                                        Name="TestClassInSubFolder.cs",
                                    },
                                    new SSObject
                                    {
                                        Name="TestClassInSubFolder2.cs",
                                    }
                                }
                            },
                            new SSObject
                            {
                                Name="TestClassInFolder.cs",
                            }
                        }
                    }
                }
            };
        }
    }
}
