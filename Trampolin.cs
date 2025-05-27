using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{
    
    public int multiplicador = 2;

    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Jump>())
        {
            other.GetComponent<Jump>().jumpStrength *= multiplicador;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.GetComponent<Jump>())
        {
            other.GetComponent<Jump>().jumpStrength /= multiplicador;
        }
    }
}
