using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJTalker : MonoBehaviour, IUsable
{
    [SerializeField]
    private AudioClip[] _audioClip;
    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Use() 
    {
        int randomSentence = Random.Range(0, _audioClip.Length);
        _audio.PlayOneShot(_audioClip[randomSentence]);
    }

    private AudioSource _audio;
}
