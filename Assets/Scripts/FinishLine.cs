using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

[SerializeField] float delay;
[SerializeField] ParticleSystem finishEffect;
[SerializeField] AudioClip finishSFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag =="Player")
        {
            //finishEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(finishSFX);
            Invoke("ReloadScene", delay);
            //Debug.Log("Congratulations!");
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
