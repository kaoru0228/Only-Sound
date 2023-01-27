using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Maze1_nomal : MonoBehaviour{

    // public GameObject EndTextObject;
    // public GameObject Target;
    
    private void OnTriggerEnter(Collider other){  //何かが衝突した時
        //other.gameObject.SetActive(false);  //衝突したオブジェクトを消滅
        // Target.SetActive(false);  //衝突したオブジェクト(Player)を消滅
        // EndTextObject.SetActive(true);  //EditTextを生成
        // ChangeScene();
        SceneManager.LoadSceneAsync("kaoru");
    }
    
    void Start(){
        //Invoke("ChangeScene", 1.5f);
    }

    void Update(){
        
    }

    // void ChangeScene(){
    //     //SceneManager.LoadScene("Title");  //表でシーンの読み込みを行う(重くなるか塗生あり)
    //     SceneManager.LoadSceneAsync("kaoru");  //こっちは裏でシーンの読み込みを行い、読み込み次第実行
    // }
}