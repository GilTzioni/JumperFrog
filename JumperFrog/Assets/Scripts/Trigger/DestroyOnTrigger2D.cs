using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    private bool isDead=false;
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    public GameManagerScript gameManager;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled && !isDead) {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            isDead=true;
            gameManager.gameOver();
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}