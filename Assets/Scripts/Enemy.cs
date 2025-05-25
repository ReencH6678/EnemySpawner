using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField]private Vector3 _moveDirection;

    private void Update()
    {
        transform.Translate(_moveDirection * _speed, Space.World);
    }

    public void SetMoveDirection(Vector3 direction)
    {
        _moveDirection = direction;
    }
}
