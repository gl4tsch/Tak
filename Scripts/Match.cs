using System.Collections.Generic;

namespace Tak
{
    public class Match
    {
        public Board Board { get; private set; }
        public int PlayersTurn { get; private set; }

        Dictionary<int, StonePocket> stonePockets;

        public Match(int boardSize)
        {
            Board = new Board(boardSize);
            stonePockets.Add(0, new(boardSize));
            stonePockets.Add(1, new(boardSize));
            PlayersTurn = 0;
        }
    }
}