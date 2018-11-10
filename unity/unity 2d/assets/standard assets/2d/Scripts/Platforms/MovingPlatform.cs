using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public GameObject platform;
    public float movspeed;
    public Transform currentpoint;
    public Transform[] points;
    public SpriteRenderer sp;

    public int pointSelection;

     void Start()
    {
        currentpoint = points[pointSelection];
        sp = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update () {
        platform.transform.position = Vector3.MoveTowards(platform.transform.position,currentpoint.position,Time.deltaTime * movspeed);

        if(platform.transform.position == currentpoint.position)
        {
            pointSelection++;
            platform.transform.localScale = new Vector3(1, 1, 1);
            if (pointSelection == points.Length)
            {
                pointSelection = 0;
                
                
                
            }
            currentpoint = points[pointSelection];
            sp = GetComponent<SpriteRenderer>();
        }
	}
}
