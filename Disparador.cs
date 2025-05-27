using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public int speed; 
    // Update is called once per frame
    void Update()
    {
        transform.position +=
        transform.forward *
        speed * Time.deltaTime;
    }
}
