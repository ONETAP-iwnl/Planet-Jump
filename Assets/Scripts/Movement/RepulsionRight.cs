using UnityEngine;

public class RepulsionRight : MonoBehaviour
{
    [Header("сила отталкивания")]
    [Space]
    [SerializeField] private float _force;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.rigidbody.AddForce(Vector2.left * _force, ForceMode2D.Impulse);
        }
    }
}
