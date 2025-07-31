using UnityEngine;

public class firstPersonLook : MonoBehaviour {
    public float mouseSensitivity = 100f;
    public Transform playerBody;  // ���V Player �� Transform

    float xRotation = 0f;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;  // ��w�ƹ�
    }

    void Update() {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // �������� Camera
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // ����L�ץ��Y�ΧC�Y
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // �������� Player ����
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
