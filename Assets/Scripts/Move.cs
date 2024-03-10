using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] protected float _speed;

    private void Update() =>
        transform.Translate(_speed * Time.deltaTime * _direction);
}
