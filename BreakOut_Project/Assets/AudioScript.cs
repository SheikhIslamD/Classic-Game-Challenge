using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource effectSource;

    public AudioClip bounce;
    public AudioClip fall;
    public AudioClip deflect;
    public AudioClip loss;
    public AudioClip win;
    public AudioClip brick;
    public AudioClip bgm;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playEffect(AudioClip clip)
    {
        effectSource.PlayOneShot(clip);
    }
}
