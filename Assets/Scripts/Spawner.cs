using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _spawnTime;

    [SerializeField] private Transform _target;

    private bool _isOn = true;
    private float _startSpawnDeley = 0;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var waitForSecond = new WaitForSeconds(_spawnTime);

        while (_isOn)
        {
            Enemy enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
            enemy.SetMoveTarget(_target);

            yield return waitForSecond;
        }
    }
}
