using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator animator = null;
    void OnTriggerEnter2D(Collider2D collision)
    {

        animator.GetComponent<Gamekit2D.HubDoor>().enabled = false;
        animator.Play("DoorClosing");
        
    }
}
