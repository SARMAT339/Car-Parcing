using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSoundObject : MonoBehaviour
{
    public GameObject SoundController;
    public static bool IsCreated = false;

    void Start()
    {
        if (IsCreated) return;

        IsCreated = true;
        DontDestroyOnLoad(Instantiate(SoundController));
    }

}