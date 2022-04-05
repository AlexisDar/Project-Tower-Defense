using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    //Classe permettant de cr�er et configurer les sons qui seront
    // ensuite utilis�s dans les scripts avec :
    //   AudioManager.Instance.Play("Nom de l'audio");

    public string Name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(0f, 3f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;


}
