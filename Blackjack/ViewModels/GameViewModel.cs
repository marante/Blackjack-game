using Core.Helpers;
using Core.Models;
using Core.PresentationCore;
using System;

namespace Blackjack.ViewModels
{
    public class GameViewModel : ViewModelBase
    {
        #region Initializing some properties needed for the Gameview.
        private Dealer _dealer;

        public Dealer Dealer
        {
            get { return Dealer; }
            set
            {
                _dealer = value;
                NotifyOfPropertyChange(() => Dealer);
            }
        }
        private Player _player;

        public Player Player
        {
            get { return _player; }
            set
            {
                _player = value;
                NotifyOfPropertyChange(() => Player);
            }
        }

        private Deck _deck;

        public Deck Deck
        {
            get { return _deck; }
            set
            {
                _deck = value;
                NotifyOfPropertyChange(() => Deck);
            }
        }

        private Hand _hand;

        public Hand Name
        {
            get { return _hand; }
            set
            {
                _hand = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        private Card _card;

        public Card Card
        {
            get { return _card; }
            set
            {
                _card = value;
                NotifyOfPropertyChange(() => Card);
            }
        }
        #endregion

        public GameViewModel(string name, double money)
        {
            // Initializing objects needed for the game.
            Dealer = new Dealer();
            Player = new Player(name, money);
            Deck = new Deck
            {
                Cards = DeckHelper.InitializeDeck()
            };

            // Helper method to load up deck with cards.

            Player.Name = name;
            Player.Money = money;
            Console.WriteLine(Deck.Cards);
            Console.WriteLine();
        }
    }
}
