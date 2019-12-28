using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour {

    public Transform target;

    void FixedUpdate()
    {
        Vector3 newposition = target.position;
        newposition.z = -10;

        transform.position = newposition;
    }
}
