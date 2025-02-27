using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public Text levelUp, maxLevel, livesUp;
    //GameObject a, b;

    
    public Rigidbody2D rb;    

    //public bool rampageMode = false;
    //public AudioClip explode;
    public float speed;
    public int AsteroidDamage = 5;
    public int RockDamage = 1;
    public int PotionHeal;
    public bool rampageMode = false;
    public AudioClip explode;

    //public AudioClip livesUp;
    //public AudioClip levelUp;

    public int PlayerHealth = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerHealth <= 0)
        {
            Destroy(gameObject);
        }  
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            PlayerHealth -= AsteroidDamage;
        }
        if(collision.gameObject.tag == "Rock")
        {
            PlayerHealth -= RockDamage;
        }
        if (collision.gameObject.tag == "Potion")
        {
            PlayerHealth += PotionHeal;
        }
    }

}
