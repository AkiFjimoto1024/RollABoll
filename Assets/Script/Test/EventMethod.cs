using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMethod : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log("Startより前に1回だけ実行される");
    }
    void Start()
    {
        Debug.Log("Awakeが全て処理された後に1回だけ実行される");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
