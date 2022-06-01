using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixBehaviour : MonoBehaviour
{
    public float rotationspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += new Vector3(0, rotationspeed, 0);
    }
}
