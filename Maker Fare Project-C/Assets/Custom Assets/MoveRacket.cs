using UnityEngine;
using System.Collections;

public class MoveRacket : MonoBehaviour {
    // up and down keys (to be set in the Inspector)
    public KeyCode up;
    public KeyCode down;
	public KeyCode left;
	public KeyCode right;

    void FixedUpdate () {
        // up key pressed?
        if (Input.GetKey(up)) {
            transform.Translate(new Vector3(0.0f, 0.01f, 0.1f));
        }

        // down key pressed?
        if (Input.GetKey(down)) {
            transform.Translate(new Vector2(0.0f, -0.1f));
        }

		// down key pressed?
		if (Input.GetKey(left)) {
			transform.Translate(new Vector2(-0.1f, 0.0f));
		}

		// down key pressed?
		if (Input.GetKey(right)) {
			transform.Translate(new Vector2(0.1f, 0.0f));
		}
    }
}
