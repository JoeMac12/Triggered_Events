using UnityEngine;
using System.Collections;

public class TogglePlayTrigger : MonoBehaviour
{
    public GameObject TimeLine;
    private bool isTriggered = false;

    void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
        {
            isTriggered = true;
            TimeLine.SetActive(true);
            //StartCoroutine(FinishTimeLine());
        }
    }

    //IEnumerator FinishTimeLine()
    //{
        //yield return new WaitForSeconds(5);
        //TimeLine.SetActive(false);
    //}
}
