using UnityEngine;

public class MoveSpeedBonus : MonoBehaviour
{
    public float _moveSpeedBonus;
    // Update is called once per frame
    public void BonusSpeed()
    {
        transform.position += Vector3.down * _moveSpeedBonus * Time.deltaTime;
    }
}
