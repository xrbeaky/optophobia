using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 100f;

    float rotateX = 0f;
    float rotateY = 90f;
    public Transform camPivot;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {   
        float mouseX = Input.GetAxisRaw("Mouse X") * mouseSensitivity * 10 * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * mouseSensitivity * 10 * Time.deltaTime;

        rotateY += mouseX;
        rotateX -= mouseY;
        rotateX = Mathf.Clamp(rotateX, -90f, 90f);


        camPivot.transform.localRotation = Quaternion.Euler(rotateX, 0f, 0f);
        transform.localRotation = Quaternion.Euler(0f, rotateY, 0f);
    }
}