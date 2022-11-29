using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField]float delay;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasDamage = false;

    [SerializeField] Color32 damagedColor = new Color32(255, 255, 255, 255);

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag =="Ground" && !hasDamage)
        {
            hasDamage = true;
            crashEffect.Play();
            FindObjectOfType<PlayerController>().DisableControl();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", delay);
            hasDamage = true;
            spriteRenderer.color = damagedColor;
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
