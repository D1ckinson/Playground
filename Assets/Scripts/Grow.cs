using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _growForce;

    private void Update() =>
        transform.localScale += new Vector3(_growForce, _growForce, _growForce);
}
