using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class co : MonoBehaviour
{
  //  SpawnerExagonal _spawnerExagonal = new SpawnerExagonal();
    public bool contact=false;
    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "path")
        {
            contact = true;
            Debug.Log("contact");
        }
        else
        {
            contact = false;
        }

    }
}
