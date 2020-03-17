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
            this.cc.Content = new MainView();
        }

        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "SS: Main Tool Window");
        }
    }
}