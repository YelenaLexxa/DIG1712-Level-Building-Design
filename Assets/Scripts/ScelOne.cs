using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScelOne : MonoBehaviour
{
    public int Score;
    public GameObject prefab;

    public Canvas MyGUI;
    public Slider slider;
    Slider ShowEnemyHP;
    public Transform metka;
    public Camera camera;
    public bool useRayCast;
    public float objectSize = 2;

    // Start is called before the first frame update
    void Start()
    {
        Score = 10; // enemy health
        camera = gameObject.GetComponent<Camera>();
        ShowEnemyHP = (Slider)Instantiate(slider);
        ShowEnemyHP.transform.SetParent(MyGUI.transform, true);
    }

    // Update is called once per frame
    void Update()
    {
        if (ShowEnemyHP != null)
        {
            Vector3 screenPos = camera.WorldToScreenPoint(metka.position);

            Vector3 cameraRelative = camera.transform.InverseTransformPoint(transform.position);
            if (cameraRelative.z > 0)
            {
                if (useRayCast)
                {
                    RaycastHit hit;

                    // beam direction
                    Vector3 direction = transform.position - Camera.transform.position;

                    // the beam itself
                    Ray ray = new Ray(Camera.transform.position, direction);

                    // sending a beam
                    if (Physics.Raycast(ray, out hit))
                    {
                        // if the distance to the target satisfies the conditions, then display the name
                        if (hit.distance >= (direction.magnitude - objectSize))
                        {
                            ShowEnemyHP.transform.position = screenPos;
                            ShowEnemyHP.value = Score;
                        }
                    }
                }
            }
        }  
    }

    void UpdateScore()
    {
        if (Score <=0 )
        {
            Destroy(gameObject);
            Destroy(ShowEnemyHP.gameObject);
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }

    public void MinusScore(int value)
    {
        Score = Score - value;
        UpdateScore();
    }

    public void MinusScore()
    {
        Score = Score - 1;
        UpdateScore();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Arrow")
        {
            MinusScore();
        }
    }
}
