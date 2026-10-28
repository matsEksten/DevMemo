using DevMemo.Models;

namespace DevMemo.Game
{
    public class GameManager
    {
        // Register the two selected cards
        private Card? firstCard;
        private Card? secondCard;
        public int Attempts { get; private set; }
        public int Pairs { get; private set; }
        public bool IsBoardLocked { get; private set; }

        /// <summary>
        /// Handles card selection and checks if the card can be selected
        /// </summary>
        public async Task SelectCard(Card card)
        {
            // Ignore clicks if the board is locked or the card is already flipped or matched
            if (IsBoardLocked || card.IsFlipped || card.IsMatched)
            {
                return;
            }

            // Save the first and second selected cards
            if (firstCard == null)
            {
                firstCard = card;
            }
            else if (secondCard == null)
            {
                secondCard = card;
            }
            else
            {
                return;
            }

            card.IsFlipped = true;

            // When two cards have been selected, send them to evaluate method
            if (firstCard != null && secondCard != null)
            {
                await EvaluateCards(firstCard, secondCard);
                firstCard = null;
                secondCard = null;
            }
        }

        // Checks if the two selected cards match and updates the game.
        private async Task EvaluateCards(Card firstCard, Card secondCard)
        {
            Attempts++;
            if (firstCard.PairId == secondCard.PairId)
            {
                firstCard.IsMatched = true;
                secondCard.IsMatched = true;

                Pairs++;
            } else 
            {
                // Keep the board locked while waiting before flipping the cards back
                IsBoardLocked = true;

                await Task.Delay(2000);

                firstCard.IsFlipped = false;
                secondCard.IsFlipped = false;

                IsBoardLocked = false;
            }

        }
    }
}
