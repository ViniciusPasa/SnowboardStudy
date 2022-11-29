using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrails : MonoBehaviour
{
    bool touch;
    [SerializeField] ParticleSystem trailEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    
         void OnTriggerStay2D(Collider2D other) 
    {
    
        if(other.tag =="Ground")
        {
            trailEffect.Play();
        }
        else
        {
            trailEffect.Stop();
        }
    }
    
}
