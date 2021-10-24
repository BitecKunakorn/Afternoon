using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControllerLv : MonoBehaviour
{
    public bool dooropen = false;
    public GameObject door;
    void Update()
    {
       door.SetActive(!dooropen);
    }
}
