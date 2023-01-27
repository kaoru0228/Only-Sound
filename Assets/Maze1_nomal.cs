using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Maze1_nomal : MonoBehaviour{

    // public GameObject EndTextObject;
    // public GameObject Target;
    
    private void OnTriggerEnter(Collider other){  //何かがすり抜けた時
        SceneManager.LoadSceneAsync("kaoru");
        Debug.Log("aaa");
    }
    void Start(){
        //Invoke("ChangeScene", 1.5f);
    }
    void Update(){
        
    }
}