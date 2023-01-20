//黄色　反射し続ける

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_Sound3 : MonoBehaviour{
    
    public Rigidbody rb;
    Vector3 force,direction;
    private float speed;

    void Start(){
        rb = this.GetComponent<Rigidbody> ();  // rigidbodyを取得
        force = new Vector3 (7.0f,0.0f,10.0f);    // 力を設定
        rb.AddForce (force,ForceMode.Impulse);  // 力を加える
        speed = 10f;
    }

    void Update(){
        direction = rb.velocity;
        //速度が10以下なら力を加える
        if (rb.velocity.magnitude < 10.0f) {
            rb.AddForce (direction,ForceMode.Impulse);  // 力を加える
            rb.velocity = rb.velocity.normalized * speed;  //速度を強制的に調整
        }
    }
}
