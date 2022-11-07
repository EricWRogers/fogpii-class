using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackGroundMusic : MonoBehaviour
{
    public DoNotRepeatRandom noRepeat;
    public AudioSource audioSource;

    public void ChangeMusic() {
        audioSource.clip = noRepeat.PickSound().clip;
        audioSource.Play();
    }
}
