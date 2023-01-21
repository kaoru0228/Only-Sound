//青色　定期的にテレポート

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_Sound : MonoBehaviour{

    public int count;
    public Rigidbody rb;
    public Vector3 now;

    private float time;
    private float vecX;
    private float vecZ;

    [SerializeField] GameObject target;

    public GameObject EndTextObject;
    public GameObject Target;

    private void OnTriggerEnter(Collider other){  //何かが衝突した時
        //other.gameObject.SetActive(false);  //衝突したオブジェクトを消滅
        Target.SetActive(false);  //衝突したオブジェクト(Player)を消滅
        EndTextObject.SetActive(true);  //EditTextを生成
    }

    // Start is called before the first frame update
    void Start(){
        count = 0;
        time = 3.0f;
        rb = this.GetComponent<Rigidbody> ();  // rigidbodyを取得
        target = GameObject.Find("OVRPlayerController");  //プレイヤーオブジェクトを取得
    }

    // Update is called once per frame
    void Update(){
        // rb = this.GetComponent<Rigidbody> ();  // rigidbodyを取得
        // Vector3 now = rb.position;            // 座標を取得
        // if(count % 1000 <250) now =  new Vector3 (38f,2f,-15f);

        // else if(count % 1000 < 500) now = new Vector3 (72f,2f,-15f);
         
        // else if(count % 1000 < 750) now = new Vector3 (72f,2f,20f);
        
        // else now = new Vector3 (34f,2f,20f);
        // rb.position = now; // 値を設定
        // count++;

        time -= Time.deltaTime;
 
        if(time <= 0){
            now = target.transform.position;
            while(true){
                vecX = Random.Range(32f, 75.0f);
                if(now.x-13 >= vecX | now.x+13 <= vecX ) break;
            }

            while(true){
                vecZ = Random.Range(-20f, 22.0f);
                if(now.z-13 >= vecZ | now.z+13 <= vecZ ) break;
            }
            this.transform.position = new Vector3(vecX, 1.5f, vecZ);  //音源（ゴール）の座標を更新
            rb.velocity = Vector3.zero;  //速度を0に
            rb.angularVelocity = Vector3.zero;  //加速度？を0に
            time = 3.0f;
        }
    }

    // void FixedUpdate () {
    //     Rigidbody rb = this.GetComponent<Rigidbody> ();  // rigidbodyを取得
    //     Vector3 now = rb.position;            // 座標を取得
    //     //now = new Vector3 (34f,2f,-15f);
    //     //now += new Vector3 (0.0f,0.0f,-0.1f);
    //     while(){
    //         now =  new Vector3 (34f,2f,-15f);
    //         rb.position = now; // 値を設定

    //         now = new Vector3 (72f,2f,-15f);
    //         rb.position = now; // 値を設定
            
    //         now = new Vector3 (72f,2f,20f);
    //         rb.position = now; // 値を設定
            
    //         now = new Vector3 (34f,2f,20f);
    //         rb.position = now; // 値を設定
    //     }

    //     //rb.position = now; // 値を設定

    // }
}
