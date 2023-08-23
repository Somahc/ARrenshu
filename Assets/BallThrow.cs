using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    public GameObject m_prefBall;
    public Transform m_transformCamera;
    public ScoreManager scoreManager;
    TimerManager timerManager;

    private void Start()
    {
        timerManager = FindObjectOfType<TimerManager>();
    }

    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began && timerManager.GetIsFirstGameover)
            {
                scoreManager.BallUsed();

                Rigidbody rigidbodyBall = Instantiate(m_prefBall).GetComponent<Rigidbody>();
                rigidbodyBall.transform.position = m_transformCamera.position;
                rigidbodyBall.velocity = m_transformCamera.forward * 20f;
            }
        }
    }
}
