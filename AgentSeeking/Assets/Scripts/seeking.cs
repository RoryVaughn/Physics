using UnityEngine;
using System.Collections;
using System;

public class seeking : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject Target;

   

    public Vector3 Norm(Vector3 x)
    {
        float e = (x.x * x.x + x.y * x.y + x.z * x.z);
        float d = Mathf.Sqrt(e);
        float q = x.x / d;
        float w = x.y / d;
        float t = x.z / d;
        Vector3 c = new Vector3(q, w, t);
        return c;
    }

    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
	{



	    if (Sphere.transform.position.x > Target.transform.position.x)
	    {
            Sphere.transform.position =  Sphere.transform.position - Norm(Target.transform.position) * Time.deltaTime;
        }
        if (Sphere.transform.position.x < Target.transform.position.x)
        {
            Sphere.transform.position =  Sphere.transform.position + Norm(Target.transform.position) * Time.deltaTime;
        }



    }
}
