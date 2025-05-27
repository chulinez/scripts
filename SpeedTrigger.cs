using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
    
{
    public int multiplicador = 2;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.GetComponent<FirstPersonMovement>())
        {
            other.GetComponent<FirstPersonMovement>().runSpeed *= multiplicador;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.GetComponent<FirstPersonMovement>())
        {
            other.GetComponent<FirstPersonMovement>().runSpeed /= multiplicador;
        }
    }
}
