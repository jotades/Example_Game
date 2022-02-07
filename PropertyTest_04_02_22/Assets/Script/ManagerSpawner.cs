using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject puzzle;
    private GameObject clone;
    public GameObject[] Puzzle;
   // int p = 5;
    public Transform path;
    private enum positionCube
     {
         nord=0,
         sud,
         est,
         ovest,
     }
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            Vector3 PathPos = path.position;
            int nextDirection = Random.Range(0, 2);
            if (PathPos.x <=Random.Range(5f,-5f)  && PathPos.z<= Random.Range(5f, -5f))
            {
                if (nextDirection == 0)
                {
                    path = Instantiate(Puzzle[Random.Range(0, 1)], path.position + Vector3.right, Quaternion.identity).transform;
                    //clone = Instantiate(Puzzle[Random.Range(1, 2)], path.position *2 + RandomRange, transform.rotation);

                }
                if (nextDirection == 1)
                {
                    path = Instantiate(Puzzle[Random.Range(0, 1)], path.position + Vector3.forward, Quaternion.identity).transform;
                    // clone = Instantiate(Puzzle[Random.Range(1, 2)], path.position * 2 + RandomRange, transform.rotation);
                }
            }
           // return;                           
            //Vector3 RandomRange = new Vector3(Random.Range(-5, 5),0, Random.Range(-5, 5));
            //clone = Instantiate(Puzzle[Random.Range(1, 2)], RandomRange, transform.rotation);
            //Debug.Log(clone.gameObject.transform.GetChild(0).transform.position);
        }return;
        // Update is called once per frame
        void Update()
        {
        }
        
    }
}

