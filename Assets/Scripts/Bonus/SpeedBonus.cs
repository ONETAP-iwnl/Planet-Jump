using UnityEngine;

public class SpeedBonus : MonoBehaviour
{
    public float timeMax;
    private float time;

    public GameObject SpeedBonusPrefab;
    GameObject _speedBonus;
    // Start is called before the first frame update
    void Start()
    {
        time = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(time > timeMax)
        {
            _speedBonus = Instantiate(SpeedBonusPrefab);
            _speedBonus.transform.position = transform.position + new Vector3(Random.Range(-1.71f, 1.62f), 4.6f, 0);
            time = 0;
        }
        time += Time.deltaTime;
        Destroy(_speedBonus);
    }
}
