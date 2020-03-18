//------------------------------------------------------------------------------
// <copyright file="SSMainToolWindowControl.xaml.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace SSPrototype
{
    using SSMainControl;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for SSMainToolWindowControl.
    /// </summary>
    public partial class SSMainToolWindowControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SSMainToolWindowControl"/> class.
        /// </summary>
        public SSMainToolWindowControl()
        {
            this.InitializeComponent();
            var mv = new MainView();
            mv.BtnRenderDiagram.Click += BtnRenderDiagram_Click;
            this.cc.Content = mv;
        }

        private void BtnRenderDiagram_Click(object sender, RoutedEventArgs e)
        {
            // show rendered tool window.
        }
    }
}