using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Standup : MonoBehaviour
{
    public ARRaycastManager m_raycastMangaer;
    public GameObject m_prefCharacter;

    void Update()
    {
        if (0 < Input.touchCount)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                List<ARRaycastHit> hitList = new List<ARRaycastHit>();
                if (m_raycastMangaer.Raycast(touch.position, hitList, TrackableType.AllTypes))
                {
                    Pose hitPose = hitList[0].pose;
                    Instantiate(m_prefCharacter, hitPose.position, hitPose.rotation);
                }
            }
        }
    }
}
