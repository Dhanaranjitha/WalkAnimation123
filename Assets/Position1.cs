using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position1 : MonoBehaviour
{
    public GameObject player2Cube;
    public GameObject player2Helmet;
    public GameObject player2Shield;
    public GameObject cube1;
    public GameObject helmetPlayer2;
    public GameObject shieldPlayer2;

   

    public GameObject player3Cube;
    public GameObject player3Helmet;
    public GameObject player3Shield;

    public GameObject cubeplayer3;
    public GameObject helmetPlayer3;
    public GameObject shieldplayer3;

    //player4
    public GameObject player4Armor;

    public GameObject armorPlayer4;
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
       
        cube1 = Instantiate(player2Cube, new Vector3(0, 0, 0), Quaternion.identity);
        cube1.transform.SetParent(GameObject.Find("mixamorig:Spine").transform);
        cube1.transform.localPosition = new Vector3(0.001f, 0.0384f, 0.0124f);
        cube1.transform.localRotation = Quaternion.Euler(0, 0, 0);

        helmetPlayer2 = Instantiate(player2Helmet, new Vector3(0, 0, 0), Quaternion.identity);
        helmetPlayer2.transform.SetParent(GameObject.Find("humanBody").transform);
        helmetPlayer2.transform.localPosition = new Vector3(-5.319f, 5.51f, 0.07f);
        helmetPlayer2.transform.localRotation = Quaternion.Euler(0, 0, 0);

         shieldPlayer2 = Instantiate(player2Shield, new Vector3(0, 0, 0), Quaternion.identity);
        shieldPlayer2.transform.SetParent(GameObject.Find("mixamorig:LeftHand").transform);
        shieldPlayer2.transform.localPosition = new Vector3(-0.015f, 0.02f, -0.015f);
        shieldPlayer2.transform.localRotation = Quaternion.Euler(0, 180, 0);

    }
    public void Player3()
    {
        cube1.gameObject.SetActive(false);
        
        GameObject cubeplayer3 = Instantiate(player3Cube, new Vector3(0, 0, 0), Quaternion.identity);
        cubeplayer3.transform.SetParent(GameObject.Find("mixamorig:Spine").transform);
        cubeplayer3.transform.localPosition = new Vector3(0.001f, 0.0384f, 0.0124f);
        cubeplayer3.transform.localRotation = Quaternion.Euler(0, 0, 0);

        helmetPlayer2.gameObject.SetActive(false);
        helmetPlayer3 = Instantiate(player3Helmet, new Vector3(0, 0, 0), Quaternion.identity);
        helmetPlayer3.transform.SetParent(GameObject.Find("humanBody").transform);
        helmetPlayer3.transform.localPosition = new Vector3(-5.319f, 5.51f, 0.07f);
        helmetPlayer3.transform.localRotation = Quaternion.Euler(0, 0, 0);
        
        shieldPlayer2.gameObject.SetActive(false);
        shieldplayer3 = Instantiate(player3Shield, new Vector3(0, 0, 0), Quaternion.identity);
       shieldplayer3.transform.SetParent(GameObject.Find("mixamorig:LeftHand").transform);
        shieldplayer3.transform.localPosition = new Vector3(-0.015f, 0.02f, -0.015f);
        shieldplayer3.transform.localRotation = Quaternion.Euler(0, 180, 0);

    }
    public void Player4()
    {
        armorPlayer4 = Instantiate(player4Armor, new Vector3(0, 0, 0), Quaternion.identity);
        armorPlayer4.transform.SetParent(GameObject.Find("mixamorig:RightHand").transform);
        armorPlayer4.transform.localPosition = new Vector3(-0.0025f, -0.0026f, 0.0021f);
        armorPlayer4.transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
}
