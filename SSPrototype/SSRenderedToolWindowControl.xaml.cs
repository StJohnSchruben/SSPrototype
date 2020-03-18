//------------------------------------------------------------------------------
// <copyright file="SSRenderedToolWindowControl.xaml.cs" company="Company">
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
    /// Interaction logic for SSRenderedToolWindowControl.
    /// </summary>
    public partial class SSRenderedToolWindowControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SSRenderedToolWindowControl"/> class.
        /// </summary>
        public SSRenderedToolWindowControl()
        {
            this.InitializeComponent();
            this.cc.Content = new RenderedView();
        }
    }
}