using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSpher : MonoBehaviour
{
    public GameObject sphere;
    public Rigidbody _sphere;
    public float forceMulti = 5;
    public SpawnerExagonal _SpawnerExagonal;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
        _sphere = sphere.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        _sphere.AddForce(sphere.transform.forward*forceMulti * Time.deltaTime);

    }
    public void Instantiate()
    {

        Instantiate(sphere, _SpawnerExagonal.firstValue+Vector3.up, Quaternion.identity);
      
    }

    IEnumerator Timer()
    {
        var wait = new WaitForSeconds(2f); 
        while (true)
        {
            yield return wait;
            Instantiate();
            break;
        }
        
    }

}
