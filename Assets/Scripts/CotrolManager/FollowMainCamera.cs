using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMainCamera : MonoBehaviour
{   
    Camera _camera;
    public Transform Player;

    void Start()
    {        
        _camera = Camera.main;
    }

    void FixedUpdate()
    {
        _camera.transform.position = new Vector3(Player.position.x, Player.position.y, -10);  
    }
}
