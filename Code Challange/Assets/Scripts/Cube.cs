using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public bool b_kin;
    public Vector3 initalPos;
    public Quaternion initalRot;


    // Start is called before the first frame update
    void Start()
    {
        initalPos = this.transform.position;
        initalRot = this.transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        if(b_kin)
        {
            this.GetComponent<Rigidbody>().isKinematic = true;
        }
        else
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
