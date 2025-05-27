using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportador : MonoBehaviour
{
    public int multiplicador = 2;
    public Transform teleportPoint;
    bool estalistoparateletransportarse = true;

    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Player>() & estalistoparateletransportarse)
        {
            other.transform.position = teleportPoint.position;
            estalistoparateletransportarse = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            estalistoparateletransportarse = true;

        }
    }
}

