using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour{

    [SerializeField] private List<AudioClip> songs = new List<AudioClip>();
    public AudioSource audioSource;
    private int randomIndex;

    void Awake(){
        audioSource = GetComponent<AudioSource>();
        ChooseSong();
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start() {
        StartCoroutine(PlayAnotherSong());
    }

    private void ChooseSong(){
        randomIndex = Random.Range(0, songs.Count);
        audioSource.clip = songs[randomIndex];
    }

    private IEnumerator PlayAnotherSong(){
        yield return new WaitForSeconds(audioSource.clip.length);
        ChooseSong();
        audioSource.Play();
    }
    
}
