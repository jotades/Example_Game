using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ManagerSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject puzzle;
    public List<Vector3> pathPosition = new List<Vector3>();
    public GameObject[] PuzzlePath;
    public GameObject[] PuzzleSurround;

    public Transform path;
    public Transform surround;

    public int gridX;
    public int gridZ;
    public float gridSpacingOffset = 1f;
    public Vector3 gridOrigin = Vector3.zero;

    //private enum positionCube
    //{
    //    nord = 0,
    //    sud,
    //    est,
    //    ovest,
    //}
    public void Start()
    {
        float pathDimension = Random.Range(50f, 50f);
        int i = 0;
        int cForward = 0;
        int cRight = 0;
        int cLeft = 0;
        for (i = 0; i < 50; i++)
        {
            Vector3 pathposforward = path.position + Vector3.forward;
            Vector3 pathposright = path.position + Vector3.right;
            int nextdirection = Random.Range(0, 3);

            if (pathposforward.x <= pathDimension && pathposforward.z <= pathDimension && pathposright.x <= pathDimension && pathposright.z <= pathDimension)
            {
                if (nextdirection == 0)
                {
                    cForward++;
                    path = Instantiate(PuzzlePath[Random.Range(0, 1)], path.position + Vector3.right, Quaternion.identity).transform;
                }
                if (nextdirection == 1)
                {
                    cRight++;
                    path = Instantiate(PuzzlePath[Random.Range(0, 1)], path.position + Vector3.forward, Quaternion.identity).transform;
                }
                if (nextdirection == 2)
                {
                    cLeft++;
                    path = Instantiate(PuzzlePath[Random.Range(0, 1)], path.position + Vector3.left, Quaternion.identity).transform;
                    int newdirection = Random.Range(0, 3);
                    if (newdirection == 0)
                    {
                        path = Instantiate(PuzzlePath[Random.Range(0, 1)], path.position + Vector3.forward, Quaternion.identity).transform;
                    }
                    if (newdirection == 1)
                    {
                        path = Instantiate(PuzzlePath[Random.Range(0, 1)], path.position + Vector3.right, Quaternion.identity).transform;
                    }
                    if (newdirection == 2)
                    {
                        path = Instantiate(PuzzlePath[Random.Range(0, 1)], path.position + Vector3.left, Quaternion.identity).transform;
                    }

                }

                //if (cForward > 3)
                //{
                //    path = Instantiate(PuzzlePath[Random.Range(0, 1)], path.position + Vector3.left, Quaternion.identity).transform;

                //}
                pathPosition.Add(path.transform.GetComponent<Transform>().position);
            }
        }
        for (int a = 0; a < gridX; a++)
        {
            for (int b = 0; b < gridZ; b++)
            {
                gridSpacingOffset = 1f;
                Vector3 spawnPosition = new Vector3(a * gridSpacingOffset, 0, b * gridSpacingOffset) + gridOrigin;
                Debug.Log(spawnPosition);
                if (!pathPosition.Contains(spawnPosition))
                {
                    gridSpacingOffset = 1f;
                    surround = Instantiate(PuzzleSurround[Random.Range(0, 3)], spawnPosition, Quaternion.identity).transform;
                }
            }
        }
    }
    // Update is called once per frame
}


    



