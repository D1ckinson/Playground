using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed;

    private void Update() =>
        transform.Rotate(_speed * Time.deltaTime * _direction);
}
