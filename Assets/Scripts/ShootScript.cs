using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using UnityEngine.XR.ARCore;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARFoundation.VisualScripting;

public class ShootScript : MonoBehaviour
{
    public GameObject Smoke;
    public int Count;
    public Text CountText;

    void Start()
    {
        {
            Count=0;
        }
    }

    public void Shoot()
    {
        Debug.Log("Shoot");
        RaycastHit hit;
        if(Physics.Raycast(gameObject.transform.position,gameObject.transform.forward,out hit))
            if (hit.transform.CompareTag("enemy")) {
                Destroy(hit.transform.gameObject);
                Instantiate(Smoke, hit.point, Quaternion.LookRotation(hit.normal));
                Count++;
                CountText.text = "Count : " + Count;
            }
    }
  
}
