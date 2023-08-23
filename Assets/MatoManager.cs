using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatoManager : MonoBehaviour
{
    [SerializeField] GameObject prefab_mato;
    public Transform parent;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        GameObject matoInstance = Instantiate(prefab_mato,parent);
        MatoMove matoMoveScript = matoInstance.GetComponent<MatoMove>();

        if (matoMoveScript != null && target != null)
        {
            matoMoveScript.target = target.gameObject;
        }

        DestroyObject destroyObjectScript = matoInstance.GetComponent<DestroyObject>();
        if (destroyObjectScript != null)
        {
            // ScoreManagerオブジェクトを直接検索して参照
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                destroyObjectScript.scoreManager = scoreManager;
            }
            else
            {
                Debug.LogWarning("ScoreManagerオブジェクトが見つかりませんでした。");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}