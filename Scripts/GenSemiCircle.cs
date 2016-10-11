using UnityEngine;
using System.Collections.Generic;
public class GenSemiCircle : MonoBehaviour {

    public struct Vertex
    {
        public Vector3 Position;
    };
        public Vertex genSemiCircle(int points, int r, int slices)
        {
            slices = 10;
            int m_semi = points / slices;
            List<Vertex> Vertices = new List<Vertex>();
            Vertices[];
            for (int Vert = 0; Vert <= m_semi; ++Vert)
            {
                float theta = Vert * (Mathf.PI / (m_semi - 1));
                Vertices[Vert].Position = new Vector3(r * Mathf.Sin(theta), r * Mathf.Cos(theta), 0);
                ;
            }
            return Vertices;
        }
        public Vertex latheSphere()
        {
            Vertex Vertices = new Vertex();
            return Vertices;
        }

        public bool genSphere()
        {
            return true;
        }

	// Use this for initialization
	void Start ()
	{
        List<Vertex> jeff = new List<Vertex>();
	    jeff[100] = genSemiCircle(100, 4, 10);

	}
    // Update is called once per frame
    void Update () {

    }
}