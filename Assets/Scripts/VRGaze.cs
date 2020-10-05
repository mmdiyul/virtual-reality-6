﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    public Image imgGaze;
    public Text imgText;
    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    public int distanceOfRay = 10;
    private RaycastHit _hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;

            if (imgGaze.fillAmount == 1)
            {
                Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

                if (Physics.Raycast(ray, out _hit, distanceOfRay))
                {
                    switch (_hit.transform.tag)
                    {
                        case "black":
                            imgText.text = "Ini kubus hitam";
                            imgText.gameObject.SetActive(true);
                            break;
                        case "default":
                            imgText.text = "Ini kubus putih";
                            imgText.gameObject.SetActive(true);
                            break;
                        case "red":
                            imgText.text = "Ini kubus merah";
                            imgText.gameObject.SetActive(true);
                            break;
                    }
                }

            }
        }
    }

    public void GVRON()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
        imgText.gameObject.SetActive(false);
    }
}