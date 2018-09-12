using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUI : MonoBehaviour {

    public GameObject head;

    private void LateUpdate()
    {
        transform.LookAt(head.transform);
    }
}
