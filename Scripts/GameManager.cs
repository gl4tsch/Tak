using Godot;
using System;

namespace Tak
{
	public partial class GameManager : Node
	{
		public static GameManager Instance;

		public GameManager()
		{
			Instance = this;
		}

		public override void _Ready()
		{
			Board board = new(4);
			GD.Print(board);
			board.Add(0, 0, new Stone(0, StoneType.Flat));
			board.Add(0, 0, new Stone(0, StoneType.Wall));
			board.Remove(0, 0, 1);
			board.Add(3, 3, new Stone(1, StoneType.Wall));
			GD.Print(board);
		}

		public override void _Process(double delta)
		{
		}
	}
}
