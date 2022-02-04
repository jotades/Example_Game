using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Property myProperty;
    public GameObject Cube;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
         
        if (Input.GetKeyDown(KeyCode.Space))
        {
            i++;
            myProperty.Score += 1;
            this.transform.Rotate(0, transform.rotation.y + myProperty.Score, 0);
            Debug.Log(myProperty.Score);
            var cubeRenderer = Cube.GetComponent<Renderer>();
            if (i % 2 == 0)
            {
                cubeRenderer.material.SetColor("_Color", Color.red);
            }
            else
            { 
            cubeRenderer.material.SetColor("_Color", Color.green);
            }

        }

        }
    }

