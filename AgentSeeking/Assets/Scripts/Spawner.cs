using UnityEngine;
using System.Collections;
using System.Security.Cryptography;

public class Spawner : MonoBehaviour
{

    public GameObject Boid;
    private Vector3 Spawn;
    public int amount;
	// Use this for initialization
	void Start ()
    { 
        for (int i = 0; i <= amount; ++i)
	            {
	                int x = Random.Range(1, 100);
	                int y = Random.Range(1, 100);
	                int z = Random.Range(1, 100);
	                Spawn = new Vector3(x, y, z);
	                Instantiate(Boid, Spawn, Quaternion.identity);
	            }
	}
	
	// Update is called once per frame
	void Update ()
	{
	    
	}
}
