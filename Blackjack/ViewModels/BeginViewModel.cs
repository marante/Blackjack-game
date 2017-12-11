using Core.Extensions;
using Core.PresentationCore;
using System.Windows.Input;

namespace Blackjack.ViewModels
{
    public class BeginViewModel
      : ViewModelBase
    {
        private string playerName;
        public string PlayerName
        {
            get => playerName;
            set
            {
                playerName = value;
                NotifyOfPropertyChange(() => PlayerName);
            }
        }

        private string startingMoney = "";
        public string StartingMoney
        {
            get => startingMoney;
            set
            {
                startingMoney = value;
                NotifyOfPropertyChange(() => StartingMoney);
            }
        }

        private RootViewModel _parentReference;

        /// <summary>
        ///     Default constructor. This is used for maintaining the parent reference in order 
        ///     for the state manager to work.
        /// </summary>
        /// <param name="parentReference"></param>
        public BeginViewModel(RootViewModel parentReference)
        {
            _parentReference = parentReference;
        }

        /// <summary>
        /// ICommand implementation to start the game, and validate that the username and
        /// starting money is not incorrect.
        /// </summary>
        public ICommand PlayCommand => new Command(
          param =>
          {
              var startingMoneyNumeric = double.Parse(StartingMoney);
              _parentReference.BeginGame(PlayerName, startingMoneyNumeric);

          },
          param =>
          {
              if (!double.TryParse(StartingMoney, out var startingMoneyNumeric))
                  return false;
              return startingMoneyNumeric > 0 && PlayerName.IsNotNullOrEmptyEx();
          });
    }
}
