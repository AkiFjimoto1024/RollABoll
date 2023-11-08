using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(1 + 2); // 3
        Debug.Log(30 - 29); // 1
        Debug.Log(9 * 9); // 81
        Debug.Log(120 / 5); // 24
        Debug.Log(120 / 7); // 17 (120/7 = 17...1)
        Debug.Log(120 % 7); // 1 (120/7 = 17...1)
        int sum = 5 + 13; // ŒvZŒ‹‰Ê‚Í•Ï”‚É‘ã“ü‚·‚é‚±‚Æ‚à‚Å‚«‚Ü‚·
        Debug.Log(sum); // 18
        sum += 1;
        Debug.Log(sum); // 20
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
