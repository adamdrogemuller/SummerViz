using UnityEngine;
using System.Collections;

public class Branch : MonoBehaviour {

    public Transform[] points;
    public float branchWidth = 0.01f;
    public Material mat;
    private GameObject g;
    private int numOfLines = 0;
    private LineRenderer l;
    public bool update = false;

	// Use this for initialization
	void Start () {
        foreach(Transform t in points) {
           g = new GameObject("Edge");
           l = g.AddComponent<LineRenderer>();
           l.SetPosition(0,transform.position);
           l.SetPosition(1,t.position);
           l.SetWidth(branchWidth,branchWidth);
           if(mat != null) {
                l.material = mat;
           }
        }
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnDrawGizmos() {
        if(points.Length > 0) { 
            foreach(Transform t in points) {
                if(t != null) {               
                    Gizmos.DrawLine(transform.position, t.position);
                }
            }
        }
    }
}
