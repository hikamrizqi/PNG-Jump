using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscript : MonoBehaviour
{
    float time = 0;
    float timer = 2;
    public GameObject udud;
    
    void Update()
    {
        if(time<=0)
        {
            Instantiate(udud, transform.position, Quaternion.identity);
            time = timer;
        }    
        else
        {
            time -= Time.deltaTime;
        }
    }
}
