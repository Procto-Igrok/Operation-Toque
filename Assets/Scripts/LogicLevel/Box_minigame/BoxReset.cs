using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxReset : MonoBehaviour
{
    public GameObject Box;
    public GameObject BoxDot;

    public void BoxRes() 
    {
        Box.transform.position = BoxDot.transform.position;
        Box.transform.rotation = BoxDot.transform.rotation;
    }
}
