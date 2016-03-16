using UnityEngine;
using System.Collections;

public class Block
{
	public const char padlo = ' ';
	public const char fal = '#';
	public const char ajto = 'A';
	public const char kulcs = 'K';

	public char data;

	public Block (char c)
	{
		data = c;
	}

}

public class BlockMaze
{
	private Block[,] maze;

	public Block this [int x, int y] {
		get{ return maze [x, y]; }
		set{ maze [x, y] = value; }
	}

	public BlockMaze (int x,int y)
	{
		maze = new Block[x, y];
	}

	public bool Fal (int x, int y)
	{
		return maze [x, y].data == Block.fal;
	}

	public bool Kulcs (int x, int y)
	{
		return maze [x, y].data == Block.kulcs;
	}

	public bool Ajto (int x, int y)
	{
		return maze [x, y].data == Block.ajto;
	}

	public int MeretX {
		get { return maze.GetLength (0); }
	}

	public int MeretY {
		get { return maze.GetLength (1); }
	}
}

public interface BlockMazeGenerator
{
	BlockMaze generate ();
}
