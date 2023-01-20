//ピンク色　プレイヤーに近づくor遠ざかる

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_sound2 : MonoBehaviour{

    // private float vecX;
    // private float vecZ;
    // public Vector3 now;

    [SerializeField] GameObject target;

    // Start is called before the first frame update
    void Start(){
        target = GameObject.Find("OVRPlayerController");  //プレイヤーオブジェクトを取得
    }

    // Update is called once per frame
    void Update(){
        this.transform.position = Vector3.MoveTowards(this.transform.position,target.transform.position,-0.1f);
    }
}
