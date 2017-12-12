using Core.PresentationCore;

namespace Blackjack.ViewModels
{
    public class RootViewModel
        : ViewModelBase
    {
        /// <summary>
        ///     Visual states are used to control whether certain controls are to be visible
        ///     This is to enabled so players can join whilst the game is going on.
        /// </summary>
        public enum BeginViewModelVisualStates
        {
            BeginViewModelOpenState,
            BeginViewModelCollapsedState
        }


        private BeginViewModel beginView;

        public BeginViewModel BeginView
        {
            get => beginView;
            set
            {
                beginView = value;
                NotifyOfPropertyChange(() => BeginView);
            }
        }


        /// <summary>
        ///     Property for getting the value of the Visual state model.
        /// </summary>
        private BeginViewModelVisualStates beginViewModelVisualState = BeginViewModelVisualStates.BeginViewModelOpenState;
        public BeginViewModelVisualStates BeginViewModelVisualState
        {
            get => beginViewModelVisualState;
            set
            {
                beginViewModelVisualState = value;
                NotifyOfPropertyChange(() => BeginViewModelVisualState);
            }
        }

        /// <summary>
        ///     Handles starting the game initially. Waits for input from the user,
        ///     and then hides the greetingwindow
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="startingMoney"></param>
        internal void BeginGame(string playerName, double startingMoney)
        {
            BeginViewModelVisualState = BeginViewModelVisualStates.BeginViewModelCollapsedState;
        }

        public RootViewModel()
        {
            BeginView = new BeginViewModel(this);
        }
    }
}
