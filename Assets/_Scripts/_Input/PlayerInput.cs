using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static PlayerInput Instance;

    PlayerInputAction _playerInput;

    void Awake()
    {
        Instance =this;

        _playerInput = new PlayerInputAction();
    }
    void OnEnable()
    {
        _playerInput.Enable();
    }
    void OnDisable()
    {
        _playerInput.Disable();
    }

    public Vector2 GetInputVector()
    {
        Vector2 inputVector = _playerInput.player.move.ReadValue<Vector2>();
        return inputVector;
    }
}
