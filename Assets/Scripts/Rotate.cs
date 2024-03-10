using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationDirection;

    private void Update() =>
        transform.Rotate(_rotationDirection);
}
