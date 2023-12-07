using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{
    public GameObject TimeLine;

    void OnTriggerEnter(Collider other)
    {
        TimeLine.SetActive(true);
    }
}