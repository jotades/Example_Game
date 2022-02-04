using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Property myProperty;
    public GameObject Cube;
    int i = 0;
    private const float secondsToDegrees = 0.1f;
    public Transform seconds;
    // Start is called before the first frame update
    void Start()
    {
        Cube.GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        //automaticRotation();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            i++;
            myProperty.Score += 1;
            // this.transform.Rotate(0, transform.rotation.y + myProperty.Score, 0);
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
    //public void automaticRotation()
    //{

    //    seconds.Rotate(Quaternion.Euler(0, 0, Time.deltaTime * secondsToDegrees).eulerAngles*100);

    //}
}

