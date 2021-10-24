using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerController : MonoBehaviour
{
    public DoorController door;
    public bool playerStay = false;
    public GameObject Canvas;
    private void Update()
    {
        Canvas.SetActive(playerStay);

        if (playerStay && Input.GetKeyDown(KeyCode.E))
        {
            door.dooropen = !door.dooropen;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerStay = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerStay = false;
        }
    }
}
