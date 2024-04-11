using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class DetectCollisionsX : MonoBehaviour
{
    public AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0));

    }
}
