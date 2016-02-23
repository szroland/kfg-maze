using UnityEngine;
using System.Collections;


/*
Olyan labirintus definicioja, amely téglalap alakú, és minden pontjában vagy fal van, vagy üres.
*/
public class BlockMaze {

    private bool[,] maze;

    public BlockMaze(bool[,] maze)
    {
        this.maze = maze;
    }

    public bool Fal(int x, int y)
    {
        return maze[x,y];
    }

    public int MeretX
    {
        get { return maze.GetLength(0); }
    }

    public int MeretY
    {
        get { return maze.GetLength(1); }
    }

}

public interface BlockMazeGenerator
{
    BlockMaze generate();
}
