using UnityEngine;

public class Player : MonoBehaviour
{
    float _playerSpeed = 5;
    float _playerRotateSpeed = 5;
    Vector3 _rotateDir;
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

        _rotateDir = moveDir;

        Debug.Log(moveDir);

        _characterController.Move(moveDir * _playerSpeed * Time.deltaTime);
        if (_rotateDir != Vector3.zero)
        {
            transform.forward = Vector3.Slerp(
                transform.forward,
                _rotateDir,
                Time.deltaTime * _playerRotateSpeed);
        }
    }
}
