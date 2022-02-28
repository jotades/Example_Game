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
    
    public int nextdirection;
    //public co _collider;


    // Update is called once per frame
    void Start()
    {
        int j = 0;
        while (true)
        {
            nextdirection = Random.Range(0, 4);
            if (nextdirection == 0 )
            {
                SpawnerOne();
                Vector3 _patOne = pathOne.GetComponent<Transform>().position;
               
                if (pathPosition.Contains(_patOne))
                    {
                    pathPosition.Remove(_patOne);
                    Destroy(pathOne.gameObject);
                    Debug.Log("Destroied");
                    nextdirection = Random.Range(1, 3);
                    j--;
                }
                else
                {
                    pathPosition.Add(pathOne.transform.GetComponent<Transform>().position);
                }
            }            
            if (nextdirection == 1 )
            {                                                
                SpawnerTwo();
                Vector3 _patOne = pathOne.GetComponent<Transform>().position;
               
                if (pathPosition.Contains(_patOne))
                {
                    pathPosition.Remove(_patOne);
                    Destroy(pathOne.gameObject);
                    Debug.Log("Destroied");
                    nextdirection = Random.Range(1, 3);
                    j--;
                }
                else
                {
                    pathPosition.Add(pathOne.transform.GetComponent<Transform>().position);
                }

            }
            if (nextdirection == 2 )
            {                 
                SpawnerTree();
                Vector3 _patOne = pathOne.GetComponent<Transform>().position;
               
                if (pathPosition.Contains(_patOne))
                {
                    pathPosition.Remove(_patOne);
                    Destroy(pathOne.gameObject);
                    Debug.Log("Destroied");
                    nextdirection = Random.Range(0 ,1);
                    nextdirection= Random.Range(3, 4);
                    j=j-2;
                }
                else
                {
                    pathPosition.Add(pathOne.transform.GetComponent<Transform>().position);
                }
            }
            if (nextdirection == 3)
            {
                SpawnerFour();              
                Vector3 _patOne = pathOne.GetComponent<Transform>().position;
             
                if (pathPosition.Contains(_patOne))
                {
                    pathPosition.Remove(_patOne);
                    Destroy(pathOne.gameObject);
                    Debug.Log("Destroied");
                    nextdirection = Random.Range(0, 3);
                    j--;
                }
                else
                {
                    pathPosition.Add(pathOne.transform.GetComponent<Transform>().position);
                }
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
            if (j > 10)
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
    //protected void OnTriggerEnter(Collider other)
    //{
    //    if (pathOne.gameObject.tag == "path") { 
    //        contact = true;
    //        Debug.Log("contact");
    //    }

    //}
}

    


