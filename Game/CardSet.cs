using DevMemo.Models;

namespace DevMemo.Game
{
    public class CardSet
    {
        /// <summary>
        /// Collection of cards used in the current game.
        /// </summary>
        public List<Card> Cards { get; private set; } = new();

        /// <summary>
        /// Creates and shuffles a new set of cards.
        /// </summary>
        public CardSet()
        {
            CreateSet();
            ShuffleCards();
        }

        public void CreateSet()
        {
            // Create eight pairs with unique card IDs and shared pair IDs.
            Cards.Add(new Card(1, 1, "images/cards/angular-original.svg"));
            Cards.Add(new Card(2, 1, "images/cards/angular-original.svg"));

            Cards.Add(new Card(3, 2, "images/cards/azure-original.svg"));
            Cards.Add(new Card(4, 2, "images/cards/azure-original.svg"));

            Cards.Add(new Card(5, 3, "images/cards/csharp-original.svg"));
            Cards.Add(new Card(6, 3, "images/cards/csharp-original.svg"));

            Cards.Add(new Card(7, 4, "images/cards/dotnetcore-original.svg"));
            Cards.Add(new Card(8, 4, "images/cards/dotnetcore-original.svg"));

            Cards.Add(new Card(9, 5, "images/cards/git-original.svg"));
            Cards.Add(new Card(10, 5, "images/cards/git-original.svg"));

            Cards.Add(new Card(11, 6, "images/cards/nextjs-original.svg"));
            Cards.Add(new Card(12, 6, "images/cards/nextjs-original.svg"));

            Cards.Add(new Card(13, 7, "images/cards/react-original.svg"));
            Cards.Add(new Card(14, 7, "images/cards/react-original.svg"));

            Cards.Add(new Card(15, 8, "images/cards/typescript-original.svg"));
            Cards.Add(new Card(16, 8, "images/cards/typescript-original.svg"));
        }


        public void ShuffleCards()
        {
            Cards = Cards.Shuffle().ToList();
        }
    }
}
