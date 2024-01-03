using System.Collections.Generic;
using Godot;

namespace Tak
{
    public class StonePocket
    {
        public static Dictionary<int, (int normal, int cap)> BoardToPocketCounts = new()
        {
            {4,(15,0)},
            {5,(21,1)},
            {6,(30,1)},
            {7,(40,2)},
            {8,(50,2)}
        };

        public int NormalStoneCount;
        public int CapStoneCount;

        public StonePocket(int normalCount, int capCount)
        {
            NormalStoneCount = normalCount;
            CapStoneCount = capCount;
        }

        public StonePocket(int boardSize)
        {
            if (!BoardToPocketCounts.ContainsKey(boardSize))
            {
                GD.Print($"Cannot create pocket for board size {boardSize}. Invalid size.");
                return;
            }

            NormalStoneCount = BoardToPocketCounts[boardSize].normal;
            CapStoneCount = BoardToPocketCounts[boardSize].cap;
        }
    }
}