using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalJudge : MonoBehaviour{

    public GameObject EndTextObject;
    public GameObject Target;
    
    private void OnTriggerEnter(Collider other){  //何かが衝突した時
        //other.gameObject.SetActive(false);  //衝突したオブジェクトを消滅
        Target.SetActive(false);  //衝突したオブジェクト(Player)を消滅
        EndTextObject.SetActive(true);  //EditTextを生成
    }
    // void Start(){
        
    // }

    // void Update(){
        
    // }
}
