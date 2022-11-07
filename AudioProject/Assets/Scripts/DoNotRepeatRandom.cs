using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotRepeatRandom : MonoBehaviour
{
    public List<RandomItem> items;

    void Awake() {
        if (items == null)
            items = new List<RandomItem>();
        
        List<TestGen<int>> testGen = new List<TestGen<int>>();

        testGen.Add(new TestGen<int>(){item = 5});

        foreach (TestGen<int> gen in testGen)
        {
            Debug.Log("test : " + gen.item);
        }
    }

    public Sound PickSound() {
        if (items.Count == 0)
            return null;

        // get number of valid points
        int numOfValidPoints = 0;
        for(int i = 0; i < items.Count; i++)
            if(items[i].count > 0)
                numOfValidPoints++;
        
        // check for reset
        if (numOfValidPoints < 2)
            for(numOfValidPoints = 0; numOfValidPoints < items.Count; numOfValidPoints++)
                items[numOfValidPoints].count = items[numOfValidPoints].defaultCount;

        int index = Random.Range(0,numOfValidPoints-1);

        int validPoints = -1;
        for(int i = 0; i < items.Count; i++)
        {
            if(items[i].count > 0)
                validPoints++;
            if (validPoints == index) {
                items[i].count--;
                return items[i].sound;
            }
        }

        return new Sound();
    }
}

[System.Serializable]
public class RandomItem {
    public int count;
    public int defaultCount;
    public Sound sound;
}

[System.Serializable] //Forces unity to show us this in the inspector.
public class Sound
{
    public string name;
    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume = 1; //This float will now only operate between 0 and 1
    [Range(.1f, 3f)]
    public float pitch = 1;

    public float spatialBlend = 1;

    public float maxDistance;

    public bool playOnAwake;


    public AudioSource source;
}

public class TestGen<T> {
    public T item;
}
