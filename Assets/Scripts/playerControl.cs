using UnityEngine;

public class playerControl : MonoBehaviour {
    private CharacterController player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update() {
        // Get the horizontal input axis
        float horizontal = Input.GetAxis("Horizontal");

        // Get the vertical input axis
        float vertical = Input.GetAxis("Vertical");

        // Create a movement vector based on input
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        Debug.DrawRay(transform.position, movement, Color.red);

        // move by the direction of the movement vector
        player.SimpleMove(movement * 5f); // Adjust speed as needed // Simple Move is effected by gravity
    }
}