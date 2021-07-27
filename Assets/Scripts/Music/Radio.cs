using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour{

    [SerializeField] private List<AudioClip> songs = new List<AudioClip>();
    private AudioSource audioSource;
    private int randomIndex;

    void Awake(){
        audioSource = GetComponent<AudioSource>();
        ChooseSong();
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

    public void PauseSong(){
        audioSource.Pause();
    }

    public void PlaySong(){
        audioSource.Play();
    }

}
