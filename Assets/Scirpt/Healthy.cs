using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Healthy : MonoBehaviour
{


    [SerializeField] private int health = 100;

    [SerializeField] private Rigidbody rb;

    [SerializeField] private UnityEvent touchChestEvent;



    private void Reset()
    {
        rb = GetComponent<Rigidbody>() ?? GetComponentInChildren<Rigidbody>() ?? GetComponentInParent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Gmal"))
        {
            health -= 10;
            if(health <= 0)
            {
                Die();
            }
            touchChestEvent.Invoke();

        }
    }

    void Die ()
    {
        Destroy(gameObject);
    }
}
