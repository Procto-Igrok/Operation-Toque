using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChase : MonoBehaviour
{
    public GameObject player;
    public GameObject cam;
    public GameObject Dot;
    
    void Update()
    {
        cam.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1.5f, cam.transform.position.z); 
    }
}
