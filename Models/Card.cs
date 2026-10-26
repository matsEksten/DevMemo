namespace DevMemo.Models
{
    /// <summary>
    /// Represents a single card in the memory game.
    /// </summary>
    public class Card
    {
        public int Id { get; }
        public int PairId { get; }
        public string ImagePath { get; }
        public bool IsFlipped { get; set; }
        public bool IsMatched { get; set; }

        /// <summary>
        /// Creates a new game card, initially face down and unmatched.
        /// </summary>
        /// <param name="id">Unique ID for the card.</param>
        /// <param name="pairId">ID shared by two matching cards.</param>
        /// <param name="imagePath">Path to the card's front image.</param>
        public Card (int id, int pairId, string imagePath)
        {
            Id = id;
            PairId = pairId;
            ImagePath = imagePath;
            IsFlipped = false;
            IsMatched = false;
        }
    }
}
