using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSuperGuai : MonoBehaviour
{
    public float velocidad;
    public Transform target;
    public int playerDamage;

    void Update()
    {
        transform.position =
        Vector3.MoveTowards(transform.position,
        target.position, velocidad * Time.deltaTime);

        transform.LookAt(target.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            Player player = other.GetComponent<Player>();

            player.TakeDamage(playerDamage);
        }
 
    }
}
