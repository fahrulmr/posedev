using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform TargetObj;
    public Vector3 cameraoffset;    
    // Start is called before the first frame update
    void Start()
    {
        cameraoffset = transform.position - TargetObj.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = TargetObj.transform.position + cameraoffset;
        transform.position = newPosition;
    }
}
