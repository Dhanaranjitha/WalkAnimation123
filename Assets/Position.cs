using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject playerCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Player2()
    {
        GameObject cube1 = Instantiate(playerCube, new Vector3(0, 0, 0), Quaternion.identity);
        cube1.transform.SetParent(GameObject.Find("mixamorig:Spine2").transform);
        cube1.transform.localPosition = new Vector3(-0.0002f, 0.7039f, -7.8985f);
        cube1.transform.localRotation = Quaternion.Euler(0, 0, 0);

    }
}
