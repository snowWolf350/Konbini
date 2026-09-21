using UnityEngine;

public class Player : MonoBehaviour
{
    float _playerSpeed = 5;

    CharacterController _characterController;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        Vector2 inputVector = PlayerInput.Instance.GetInputVector();
        Vector3 moveDir = new Vector3(inputVector.y, 0, -inputVector.x);

        Debug.Log(moveDir);

        _characterController.Move(moveDir * _playerSpeed * Time.deltaTime);
    }
}
