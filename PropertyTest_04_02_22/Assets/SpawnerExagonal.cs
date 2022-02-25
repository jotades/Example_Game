using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnerExagonal : MonoBehaviour
{
    public GameObject[] PuzzleExagonal;
    public GameObject puzzle;
    public Transform pathOne;

    private Vector3 point;
    public Vector3 distance = new Vector3(0.86f, 0, 0);

    public List<Vector3> pathPosition = new List<Vector3>();
    // Update is called once per frame
    void Start()
    {
        int j = 0;
        while (true)
        {            
            int nextdirection = Random.Range(0, 3);
            if (nextdirection == 0)
            {
                SpawnerOne();
            }
            if (nextdirection == 1)
            {
                SpawnerTwo();
            }
            if (nextdirection == 2)
            {
                SpawnerTree();
            }
            if (nextdirection == 3)
            {
                SpawnerFour();
            }
            if (nextdirection == 4)
            {
                SpawnerFive();
            }
            if (nextdirection == 5)
            {
                SpawnerSix();
            }
            j++;
            pathPosition.Add(pathOne.transform.GetComponent<Transform>().position);
            Vector3 _patOne = pathOne.GetComponent<Transform>().position;
            foreach (Vector3 _pathOne in pathPosition)
           {
                Debug.Log(_pathOne);
                //if (!pathPosition.Contains(_patOne))
                //{
                //    Debug.Log("InForeach");
                //    j++;
                //    continue;
               // }
            }
                //    else
                //    {
                //        j--;
                //    }                  
                //}
                if (j > 20)
            break;
        }
    }
    void Update()
    {
    }
        void SpawnerOne()//Q
        {
            pathOne = Instantiate(PuzzleExagonal[Random.Range(0, 3)], point + Vector3.forward, Quaternion.identity).transform;
            point = pathOne.transform.GetChild(0).transform.position;
           // pathPosition.Add(pathOne.GetComponent<Transform>().position);
    }
        void SpawnerTwo()//W
        {
            pathOne = Instantiate(PuzzleExagonal[Random.Range(0, 3)], point + Vector3.forward, Quaternion.identity).transform;
            point = pathOne.transform.GetChild(3).transform.position;
           // pathPosition.Add(pathOne.GetComponent<Transform>().position);
    }
        void SpawnerTree()//E
        {
            pathOne = Instantiate(PuzzleExagonal[Random.Range(0, 3)], point - Vector3.forward, Quaternion.identity).transform;
            point = pathOne.transform.GetChild(3).transform.position;
          //  pathPosition.Add(pathOne.GetComponent<Transform>().position);
    }
        void SpawnerFour()//R
        {
            pathOne = Instantiate(PuzzleExagonal[Random.Range(0, 3)], point - Vector3.forward, Quaternion.identity).transform;
            point = pathOne.transform.GetChild(0).transform.position;
           // pathPosition.Add(pathOne.GetComponent<Transform>().position);
    }
        void SpawnerFive()//T
        {
            pathOne = Instantiate(PuzzleExagonal[Random.Range(0, 3)], point - distance, Quaternion.identity).transform;
            point = pathOne.transform.GetChild(3).transform.position;
        }
        void SpawnerSix()//Y
        {
            pathOne = Instantiate(PuzzleExagonal[Random.Range(0, 3)], point + distance, Quaternion.identity).transform;
            point = pathOne.transform.GetChild(0).transform.position;
        }
    }

    


