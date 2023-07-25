using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupInstantiater : MonoBehaviour
{
    public GameObject Pickup;
    public GameObject marker;
    public GameObject Map;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void instantiatePickup(Transform ballTransform)
    {
        GameObject instantiatedPickup = Instantiate(Pickup, ballTransform.position + new Vector3(0, 0, 0.05f), Quaternion.identity);
        GameObject InstantiatedMarker = Instantiate(marker, Map.GetComponent<RectTransform>());
        InstantiatedMarker.GetComponent<Tracktomap>().objectTorack = instantiatedPickup.transform;
    }
}
