using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeeperAttack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerController>().life--;
        }
    }
}
