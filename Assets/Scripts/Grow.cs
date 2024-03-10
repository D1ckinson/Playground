using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _force;

    private void Update() =>
        transform.localScale += _force * Time.deltaTime * Vector3.one;
}
