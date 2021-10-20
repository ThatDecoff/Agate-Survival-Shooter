using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    public float spinSpeed = 3f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !other.isTrigger)
        {
            OnPlayerEnter(other);

            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        float spinX = Random.Range(-spinSpeed, spinSpeed);
        float spinY = Random.Range(-spinSpeed, spinSpeed);
        float spinZ = Random.Range(-spinSpeed, spinSpeed);
        Vector3 randomSpin = new Vector3(spinX, spinY, spinZ);
        rb.AddTorque(randomSpin);
    }

    public virtual void OnPlayerEnter(Collider player)
    {
        return;
    }
}
