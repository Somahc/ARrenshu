using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public int damage;
    public ScoreManager scoreManager;
    private GameObject mato;
    //private Hp hp;

    // Start is called before the first frame update
    void Start()
    {
        mato = GameObject.Find("Matos");
        //hp = mato.GetComponent<Hp>();
        //Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        //ぶつかったオブジェクトのTagにBallという名前が書いてあったならば（条件）.
        if (other.CompareTag("Ball"))
        {
            //スコア加算
            scoreManager.AddScore();

            //HPクラスのDamage関数を呼び出す
            //hp.Damage(damage);

            //ボールがぶつかったら自身を消す
            Destroy(gameObject);

            //ぶつかってきたオブジェクトを破壊する.
            Destroy(other.gameObject);
        }
    }
}
