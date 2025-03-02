using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisableColider : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI countText;
    public GameObject extraMesh;
    public GameObject winTextObject;
    public int pickupQuota;
    
    // Start is called before the first frame update
    void Start()
    {
        count = 0;

        SetCountText();

        winTextObject.SetActive(false);
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString() + "/" + pickupQuota;

        if (count >= pickupQuota)
        {
            winTextObject.SetActive (true);
            extraMesh.SetActive (false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);

            if (count < pickupQuota)
            {
                count = count + 1;
            }

            SetCountText();
        }
    }
}
