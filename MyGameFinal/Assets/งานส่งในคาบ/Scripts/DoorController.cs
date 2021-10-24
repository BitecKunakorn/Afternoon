using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool dooropen = false;
    Animator animator;
    public GameObject door;
    // Update is called once per frame
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        //door.SetActive(!dooropen);
        animator.SetBool("DoorOpen",dooropen);
    }
}