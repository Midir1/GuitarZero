using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] private float boardSpeed;

    private void Update()
    {
        if (!GameTo.IsPlaying) return;
        
        BoardMovement();
    }

    private void BoardMovement()
    {
        transform.position += Vector3.back * (Time.deltaTime * boardSpeed);
    }
}