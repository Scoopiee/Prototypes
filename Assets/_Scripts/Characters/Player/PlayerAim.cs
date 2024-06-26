/**************************************************************************************************************
* <Player Aim> Class
*
* Rotates a child object on the player 'rotation point' to show an aim widget useful for
* determining where a throw will be. 
* 
* Created by: <Aidan McCarthy> 
* Date: <11/06/2024>
*
***************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        int playerDirection = player.movementDirection;
        
        
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y * playerDirection, rotation.x * playerDirection) * Mathf.Rad2Deg;   
        transform.rotation = Quaternion.Euler(0,0, rotZ);
    }
    
}
