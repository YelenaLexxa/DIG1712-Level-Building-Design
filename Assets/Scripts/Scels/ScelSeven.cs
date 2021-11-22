using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScelSeven : MonoBehaviour
{
    public int Score;
    public GameObject prefab;

    public Canvas MyGUI;
    public Slider slider;
    Slider ShowEnemyHP;
    public Transform metka;
    public Camera Camera;
    public bool useRayCast;
    public float objectSize = 2;

    // Start is called before the first frame update
    void Start()
    {
        Score = 10;
        ShowEnemyHP = (Slider)Instantiate(slider);
        ShowEnemyHP.transform.SetParent(MyGUI.transform, true);
    }

    // Update is called once per frame
    void Update()
    {
        if (ShowEnemyHP != null)
        {
            Vector3 screenPos = Camera.WorldToScreenPoint(metka.position);

            Vector3 cameraRelative = Camera.transform.InverseTransformPoint(transform.position);
            if (cameraRelative.z > 0)
            {
                if (useRayCast)
                {
                    RaycastHit hit;

                    // направление луча
                    Vector3 direction = transform.position - Camera.transform.position;

                    // сам луч
                    Ray ray = new Ray(Camera.transform.position, direction);

                    // посылаем луч
                    if (Physics.Raycast(ray, out hit))
                    {
                        // если дистанция до цели удовлетворяет условиям, то отображаем имя
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
        if (Score <= 0)
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
}
