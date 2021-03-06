using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float velocity;
    private Vector3 shootDirection;

    private IEnumerator Start()
    {
        // wait one frame before starting, to ensure all objects are affected
        yield return null;

    }

    public void Setup(Vector3 shootDirection)
    {
        this.shootDirection = shootDirection;
    }

    private void Update()
    {
        transform.position += shootDirection * velocity * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Rigidbody>())
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(0, 250, 0);
        }
        Destroy(gameObject);
    }
}
