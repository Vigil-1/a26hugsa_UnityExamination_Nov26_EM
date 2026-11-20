using UnityEngine;

public class RandomPitchAudio : MonoBehaviour
{
    public AudioClip soundClip;
    public float pitchVariance = 0.05f; // ±5% from normal pitch

    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundClip;
    }

    public void PlayRandomPitch()
    {
        float randomPitch = Random.Range(1f - pitchVariance, 1f + pitchVariance);
        GetComponent<AudioSource>().pitch = randomPitch;
        GetComponent<AudioSource>().PlayOneShot(soundClip);
    }
}