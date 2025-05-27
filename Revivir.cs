using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Revivir : MonoBehaviour
{
    public void RevivirJugador ()
    {
        SceneManager.LoadScene("Level_1");
    }
    private void Start()
    {
        Cursor.visible = true;
    }
}
