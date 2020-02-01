using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour
{
    public Camera previous;
    public Camera next;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
            previous.gameObject.SetActive(false);
            next.gameObject.SetActive(true);
        }
    }
}
