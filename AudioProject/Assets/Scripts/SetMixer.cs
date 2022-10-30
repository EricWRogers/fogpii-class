using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetMixer : MonoBehaviour
{
    public AudioMixer mixer;
    public string slideName;

    public void SetLevel(float sliderValue) {
        sliderValue = Mathf.Clamp(sliderValue, 0.0001f, 1.0f);

        mixer.SetFloat(slideName, Mathf.Log10(sliderValue) * 20);
    }
}
