using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    
    public Camera cameraPlayer;
    public GameObject myPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraPlayer = GetComponent<Camera>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 point = new Vector3(cameraPlayer.pixelWidth / 2, cameraPlayer.pixelHeight / 2, 0);
            Ray ray = cameraPlayer.ScreenPointToRay(point);

            GameObject p = Instantiate(myPrefab, transform.position, transform.rotation);
            p.transform.position = ray.origin;
            p.GetComponent<Rigidbody>().AddForce(ray.direction * 1000);
           
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.visible = true;
        }
    }
}
