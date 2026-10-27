using DevMemo.Models;

namespace DevMemo.Game
{
    public class GameManager
    {
        private Card? firstCard;
        private Card? secondCard;
        public void SelectCard(Card card)
        {
            if (card.IsFlipped || card.IsMatched)
            {
                return;
            }

            

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

            if (firstCard != null && secondCard != null)
            {
                EvaluateCards(firstCard, secondCard);
                firstCard = null;
                secondCard = null;
            }
        }

        public void EvaluateCards(Card firstCard, Card secondCard)
        {
            if (firstCard.PairId == secondCard.PairId)
            {
                Console.WriteLine("Match");
            } else
            {
                Console.WriteLine("No Match");
            }
        }
    }
}
