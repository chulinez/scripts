using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;

    private int monedas;
    public AudioSource audiosource;
    public AudioClip collectSound;
    public AudioClip damageSound;
    public int vida = 10;
   public void CollectCoins()
   {
        monedas++;

        audiosource.PlayOneShot(collectSound);

        print("Collected coins: " + monedas);
   }
    public void TakeDamage(int damage)
    {

        vida -= damage;
        print("Player's health: " + vida);

        if (vida > 0)
        {
            audiosource.PlayOneShot(collectSound);
        }   
        else
        {
            SceneManager.LoadScene("Game Over");
        }

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
} 
