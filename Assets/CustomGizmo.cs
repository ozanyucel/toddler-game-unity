using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGizmo : MonoBehaviour {

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 0.2f);
    }
}
