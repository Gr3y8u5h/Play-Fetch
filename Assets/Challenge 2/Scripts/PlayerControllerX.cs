using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float Timer = 1;

    // Update is called once per frame
    void Update()
    {

        Timer -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) & Timer <=0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Timer = 1f;


        }
    }
}
