using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReload : MonoBehaviour
{
    // Start is called before the first frame update
       public void OnCollisionEnter2D(Collision2D other) {
    if(!other.gameObject.CompareTag("Ball")) return;
    SceneManager.LoadScene("MainGame");
   }
}
