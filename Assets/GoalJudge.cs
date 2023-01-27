using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalJudge : MonoBehaviour{

    public GameObject EndTextObject;
    public GameObject Target;
    
    private void OnTriggerEnter(Collider other){  //何かがすり抜けた時
        //other.gameObject.SetActive(false);  //衝突したオブジェクトを消滅
        //Target.SetActive(false);  //衝突したオブジェクト(Player)を消滅
        EndTextObject.SetActive(true);  //EditTextを生成

        Invoke("ChangeScene", 1.5f);
    }
    void ChangeScene(){
        SceneManager.LoadSceneAsync("Title");  //こっちは裏でシーンの読み込みを行い、読み込み次第実行
    }

    // void Start(){
        
    // }

    // void Update(){
        
    // }
}
