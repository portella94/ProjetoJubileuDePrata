using UnityEngine;

public class RotateMainCamara : MonoBehaviour
{
    public float rotationsPerSecond = .1f;

    bool ida = true;

    void Update()
    {
        if (ida)
            this.transform.eulerAngles += Time.deltaTime * Vector3.up * rotationsPerSecond * 360;
        else
            this.transform.eulerAngles -= Time.deltaTime * Vector3.up * rotationsPerSecond * 360;
        
        if (this.transform.eulerAngles[1] >= 130)
            ida = false;
        else if (this.transform.eulerAngles[1] <= 45)
            ida = true;
    }
}
