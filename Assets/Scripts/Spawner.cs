using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Vector3 _enemyMoveDirection;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _spawnTime;

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
            enemy.SetMoveDirection(GetRandomDirection());

            yield return waitForSecond;
        }
    }

    private Vector3 GetRandomDirection()
    {
        Vector3 direction = Random.insideUnitSphere.normalized;
        direction.y = Vector3.zero.y;

        return direction;
    }
}
