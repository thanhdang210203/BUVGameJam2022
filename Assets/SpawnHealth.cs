using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHealth : MonoBehaviour
{
    public float rate;
    public GameObject[] potion;
    public int waves;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPotions", rate, rate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnPotions()
    {
        for (int i = 0; i < waves; i++)
        {
            Instantiate(potion[(int)Random.Range(0, potion.Length)], new Vector3(Random.Range(-2.5f, 2.5f), 7f, 1), Quaternion.identity);
        }
    }
}
