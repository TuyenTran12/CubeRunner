using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicAudioSource;
    public AudioSource VFXAudioSource;

    public AudioClip musicClip;
    public AudioClip JumpClip;
    public AudioClip LoseClip;
    // Start is called before the first frame update
    void Start()
    {
        musicAudioSource.clip = musicClip;
        musicAudioSource.Play();
    }

   public void PlaySFX(AudioClip vfxClip)
    {
        VFXAudioSource.clip = vfxClip;
        VFXAudioSource.PlayOneShot(vfxClip);
    }    
}
