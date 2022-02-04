using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Property myProperty;
    public GameObject Cube;
    private Vector3 cubeRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            myProperty.Score += 1;
            this.transform.Rotate(0, transform.rotation.y+myProperty.Score,0);
            Debug.Log(myProperty.Score);
            Debug.Log(transform.rotation.y + myProperty.Score);
            

        }
    }
}
