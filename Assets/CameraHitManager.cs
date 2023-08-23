using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHitManager : MonoBehaviour
{
    public UIManager uiManager;
    private bool isGameover;
    // Start is called before the first frame update
    void Start()
    {
        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mato") && !isGameover)
        {
            Debug.Log("ゲームオーバー！");
            isGameover = true;
            if (uiManager != null)
            {
                uiManager.ShowGameoverMenu();
            }
            else
            {
                Debug.LogWarning("UIManagerがアサインされていません。");
            }
        }
    }
}
