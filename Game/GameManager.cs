using DevMemo.Models;

namespace DevMemo.Game
{
    public class GameManager
    {
        private Card? FirstCard { get; set; }
        private Card? SecondCard { get; set; }
        public void SelectCard(Card card)
        {
            if (card.IsFlipped || card.IsMatched)
            {
                return;
            }

            card.IsFlipped = true;

            if (FirstCard == null)
            {
                FirstCard = card;
            }
            else if (SecondCard == null)
            {
                SecondCard = card;
            }
            else
            {
                return;
            }

            if (FirstCard != null && SecondCard != null)
            {
                EvaluateCards(FirstCard, SecondCard);
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
