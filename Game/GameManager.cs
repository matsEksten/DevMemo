using DevMemo.Models;

namespace DevMemo.Game
{
    public class GameManager
    {
        private Card? firstCard;
        private Card? secondCard;
        public int Attempts { get; private set; }
        public int Pairs { get; private set; }

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
            Attempts++;
            if (firstCard.PairId == secondCard.PairId)
            {
                firstCard.IsMatched = true;
                secondCard.IsMatched = true;

                Pairs++;
            } else
            {
                Console.WriteLine("No Match");
            }
        }
    }
}
