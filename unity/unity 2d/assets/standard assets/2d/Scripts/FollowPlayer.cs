using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject target;
    [SerializeField]
    private float yMax;
    [SerializeField]
    private float yMin;
    [SerializeField]
    private float xMin;
    [SerializeField]
    private float xMax;

    void Start()
    {
        
    }
    void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(target.transform.position.x, xMin, xMax), Mathf.Clamp(target.transform.position.y, yMin, yMax), target.transform.position.z);
    }
}
