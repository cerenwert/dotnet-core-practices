using System.Collections.Generic;

namespace TodoBoardApp
{
    public class Board
    {
        public List<Card> Todo { get; set; } = new List<Card>();

        public List<Card> InProgress { get; set; } = new List<Card>();

        public List<Card> Done { get; set; } = new List<Card>();
    }
}