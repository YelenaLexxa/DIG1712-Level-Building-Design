using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject arrow; //get arrow prefab
    public Camera cameraPlayer; //get camera gameobject

    // Start is called before the first frame update
    void Start()
    {
        cameraPlayer = GetComponent<Camera>(); // connect camera to gameobject
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject a = Instantiate(arrow, transform.position, transform.rotation); //creates arrow to be fired
        }
    }
}
