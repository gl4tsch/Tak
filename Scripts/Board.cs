
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Godot;

namespace Tak
{
    public class Board
    {
        public int SideLength { get; private set; }
        List<Stone>[,] stones;

        public Board(int sideLength)
        {
            SideLength = sideLength;
            stones = new List<Stone>[sideLength, sideLength];
            Clear();
        }

        void Clear()
        {
            for (int i = 0; i < SideLength; i++)
            {
                for (int ii = 0; ii < SideLength; ii++)
                {
                    stones[i,ii] = new();
                }
            }
        }

        public void Add(int x, int y, Stone stone)
        {
            List<Stone> stoneStack = new(){stone};
            Add(x, y, stoneStack);
        }

        public void Add(int x, int y, List<Stone> newStones)
        {
            stones[x,y].AddRange(newStones);
        }

        public List<Stone> Remove(int x, int y, int stoneCount)
        {
            List<Stone> removedStones = new();
            if (stones[x,y].Count >= stoneCount)
            {
                int botIdx = stones[x,y].Count - stoneCount;
                removedStones.AddRange(stones[x,y].GetRange(botIdx, stoneCount));
                stones[x,y].RemoveRange(botIdx, stoneCount);
            }
            else
            {
                GD.Print($"Cannot remove {stoneCount} stones from {x},{y}. Not enough stones.");
            }
            return removedStones;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            for (int i = 0; i < SideLength; i++)
            {
                for (int ii = 0; ii < SideLength; ii++)
                {
                    sb.Append('[');
                    foreach (var stone in stones[i,ii])
                    {
                        sb.Append(stone.ToString());
                    }
                    sb.Append(']');
                }
                sb.Append('\n');
            }
            return sb.ToString();
        }
    }
}