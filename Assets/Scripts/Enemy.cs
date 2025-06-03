using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _target;

    private void Update()
    {
        if(_target != null)
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed);
    }

    public void SetMoveTarget(Transform target)
    {
        _target = target;
    }
}
