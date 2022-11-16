using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CubeTouchSound : MonoBehaviour
{
    void Update()
    {
        float dx = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        float dz = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        transform.position = new Vector3 (
            transform.position.x + dx, 0.5f, transform.position.z + dz
        );
    }
 
    void OnCollisionEnter(Collision col) {
      if (col.gameObject.name == "Cube") {
            GetComponent<AudioSource>().Play();
        }
      }
}