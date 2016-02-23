using UnityEngine;
using System.Collections;

public class BlockMazeDisplay : MonoBehaviour {

    public GameObject Padlo;
    public GameObject Fal;

    public float MeretX = 1;
    public float MeretZ = 1;

    private BlockMazeGenerator generator;
    private BlockMaze maze;

	void Start () {

        generator = GetComponent<BlockMazeGenerator>();
        maze = generator.generate();

        for (int i=0; i<maze.MeretX; i++)
        {
            for (int j=0; j<maze.MeretY; j++)
            {
                LabirintusCella(i, j);
            }
        }

	}

    private void LabirintusCella(int i, int j)
    {
        Vector3 pos = new Vector3(i * MeretX, 0, j * MeretZ);
        if (maze.Fal(i, j))
        {
            if (Fal != null)
                Letrehoz(pos, Fal);
        }
        else
        {
            if (Padlo != null)
                Letrehoz(pos, Padlo);
        }
    }

    //Létrehozza a megadott prefab másolatát a pos által definiált relatív pozícióban
    void Letrehoz(Vector3 pos, GameObject epitoElem)
    {
        GameObject instance = (GameObject)Instantiate(epitoElem, transform.position + pos + epitoElem.transform.position, Quaternion.identity);
        instance.transform.parent = transform;
    }


}
