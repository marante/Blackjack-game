using Blackjack.ViewModels;
using Caliburn.Micro;
using System.Collections.Generic;
using System.Windows;

namespace Blackjack
{
    public class AppBootstrapper
      : BootstrapperBase
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        /// <inheritdoc />
        /// <summary>
        /// Bootstrapper file to start the application from.
        /// Part of the Caliburn.Micro framework.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            var settings = new Dictionary<string, object>
            {
                { "SizeToContent", SizeToContent.Manual },
                { "WindowState" , WindowState.Normal }
            };

            DisplayRootViewFor<RootViewModel>(settings);
        }
    }
}