using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleScene_he : MonoBehaviour{
    
    void Start(){
        Invoke("ChangeScene", 1.5f);
        //this.SetActive(false);
    }

    void Update(){
        
    }

    void ChangeScene(){
        //SceneManager.LoadScene("Title");  //表でシーンの読み込みを行う(重くなるか塗生あり)
        SceneManager.LoadSceneAsync("Title");  //こっちは裏でシーンの読み込みを行い、読み込み次第実行
    }
}