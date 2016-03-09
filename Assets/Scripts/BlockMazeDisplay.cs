using UnityEngine;
using System.Collections;

public class BlockMazeDisplay : MonoBehaviour {

    public GameObject Padlo;
    public GameObject Fal;
    public GameObject Kulcs;

    public float BlokkMeretX = 1;
    public float BlokkMeretZ = 1;

    private BlockMazeGenerator generator;
    private BlockMaze maze;

	void Start () {

        generator = GetComponent<BlockMazeGenerator>();
        maze = generator.generate();

        for (int i=0; i<maze.MeretX; i++)
        {
            for (int j=0; j<maze.MeretY; j++)
            {
                Vector3 pos = new Vector3(i, 0, j);
                if (maze.Fal(i, j))
                {
                    Letrehoz(pos, Fal);
                }
                else
                {
                    Letrehoz(pos, Padlo);
                    if (maze.Kulcs(i, j))
                    {
                        Letrehoz(pos, Kulcs);
                    }
                }
            }
        }

	}

    //Létrehozza a megadott prefab másolatát a pos által definiált relatív pozícióban
    void Letrehoz(Vector3 pos, GameObject epitoElem)
    {
        GameObject instance = (GameObject)Instantiate(epitoElem, transform.position + pos + epitoElem.transform.position, Quaternion.identity);
        instance.transform.parent = transform;
    }


}
