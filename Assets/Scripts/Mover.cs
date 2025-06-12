using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform[] _targets;
    [SerializeField] private float _speed;
    [SerializeField] private float _offset = 1;

    private int _targetIndex = 0;

    void Update()
    {
        if (Vector3.Distance(_targets[_targetIndex].position, transform.position) > _offset)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targets[_targetIndex].position, _speed * Time.deltaTime);
        }
        else
        {
            if (_targetIndex + 1 < _targets.Length)
                _targetIndex++;
            else
                _targetIndex = 0;
        }
    }
}
