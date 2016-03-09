using UnityEngine;
using System.Collections;


/*
Olyan labirintus definicioja, amely téglalap alakú, és minden pontjában vagy fal van, vagy üres.
*/
public class BlockMaze {

    private bool[,] fal;
    private bool[,] kulcs;

    public BlockMaze(bool[,] fal, bool[,] kulcs)
    {
        this.fal = fal;
        this.kulcs = kulcs;
    }

    public bool Fal(int x, int y)
    {
        return fal[x,y];
    }

    public bool Kulcs(int x, int y)
    {
        return kulcs[x, y];
    }

    public int MeretX
    {
        get { return fal.GetLength(0); }
    }

    public int MeretY
    {
        get { return fal.GetLength(1); }
    }

}

public interface BlockMazeGenerator
{
    BlockMaze generate();
}
