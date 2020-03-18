using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SSMainControl
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
           //this.btnRender.Click += BtnRender_Click;
        }

        private void BtnRender_Click(object sender, RoutedEventArgs e)
        {
           /// MessageBox.Show("Routed click event to the MainView");
        }

        public RadioButton RbClass
        {
            get { return this.rbClass; }
        }

        public RadioButton RbActivity
        {
            get { return this.rbActivity; }
        }

        public Button BtnRenderDiagram
        {
            get { return this.btnRender; }
        }
    }
}
