using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public SpriteRenderer spriteRenderer;
    public Sprite[] states;

    private void Awake() {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void start() {
        this.health = this.states.Length;
        this.spriteRenderer.sprite = this.states[this.health-1];
    }

    public void OnCollisionEnter2D(Collision2D other) {
        if(!other.gameObject.CompareTag("Ball")) return;
        this.health--;
        if (this.health <= 0) {
            this.gameObject.SetActive(false);
        }
        else {
            this.spriteRenderer.sprite = this.states[this.health-1];
        }
   }
}
