using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 200f;

    void Update()
    {
        // Rotate around Y-axis for a flip effect
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}