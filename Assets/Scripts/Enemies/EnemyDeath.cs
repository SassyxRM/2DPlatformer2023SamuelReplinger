using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{

    public GameObject deathEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void EnemyDeathController()
    {
        transform.gameObject.SetActive(false);
        Instantiate(deathEffect, transform.GetChild(0).position, transform.GetChild(0).rotation);
        AudioManager.sharedInstance.PlaySFX(3);
    }
}
