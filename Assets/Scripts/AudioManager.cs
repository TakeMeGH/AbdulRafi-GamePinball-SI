using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource bgmAudioSource;
    [SerializeField] GameObject sfxAudioSource;
    [SerializeField] GameObject sfxSwitchOn;
    [SerializeField] GameObject sfxSwitchOff;


    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayBGM()
    {
        bgmAudioSource.Play();
    }
    // Note : Rasanya SFX ini bisa dibuat array gameobject agar tidak buat fungsi terus setiap tambah SFX
    public void PlaySFX(Vector3 spawnPosition)
    {
        Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXSwitchOn(Vector3 spawnPosition)
    {
        Instantiate(sfxSwitchOn, spawnPosition, Quaternion.identity);
    }
    public void PlaySFXSwitchOff(Vector3 spawnPosition)
    {
        Instantiate(sfxSwitchOff, spawnPosition, Quaternion.identity);
    }


}
