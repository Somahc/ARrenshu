using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatoManager : MonoBehaviour
{
    [SerializeField] GameObject prefab_mato;
    public Transform parent;
    public Transform target;

    //敵生成時間間隔
    private float interval;
    //経過時間
    private float time = 0f;
    public float minTime = 0.2f;
    public float maxTime = 0.5f;
    //X座標の最小値
    public float xMinPosition = -2f;
    //X座標の最大値
    public float xMaxPosition = 2f;
    //Y座標の最小値
    public float yMinPosition = 0f;
    //Y座標の最大値
    public float yMaxPosition = 2f;
    //Z座標の最小値
    public float zMinPosition = 0.5f;
    //Z座標の最大値
    public float zMaxPosition = 1f;

    // Start is called before the first frame update
    void Start()
    {
        interval = GetRandomTime();

        //GameObject matoInstance = Instantiate(prefab_mato,parent);
        //MatoMove matoMoveScript = matoInstance.GetComponent<MatoMove>();

        //// 生成した的インスタンスに変数targetを設定
        //if (matoMoveScript != null && target != null)
        //{
        //    matoMoveScript.target = target.gameObject;
        //}

        //// 生成した的インスタンスに変数Score Managerを設定
        //DestroyObject destroyObjectScript = matoInstance.GetComponent<DestroyObject>();
        //if (destroyObjectScript != null)
        //{
        //    // ScoreManagerオブジェクトを直接検索して参照
        //    ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        //    if (scoreManager != null)
        //    {
        //        destroyObjectScript.scoreManager = scoreManager;
        //    }
        //    else
        //    {
        //        Debug.LogWarning("ScoreManagerオブジェクトが見つかりませんでした。");
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //Debug.Log(time);

        if(time > interval)
        {
            GameObject matoInstance = Instantiate(prefab_mato, parent);
            // ランダムな位置に的を配置
            matoInstance.transform.position = GetRandomPosition();
            MatoMove matoMoveScript = matoInstance.GetComponent<MatoMove>();

            // 生成した的インスタンスに変数targetを設定
            if (matoMoveScript != null && target != null)
            {
                matoMoveScript.target = target.gameObject;
            }

            // 生成した的インスタンスに変数Score Managerを設定
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
            interval = GetRandomTime();
            time = 0f;
        }
    }

    // ランダムな時間を生成する関数
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    //ランダムな位置を生成する関数
    private Vector3 GetRandomPosition()
    {
        //それぞれの座標をランダムに生成する
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);
        float z = Random.Range(zMinPosition, zMaxPosition);

        //Vector3型のPositionを返す
        return new Vector3(x, y, z);
    }
}