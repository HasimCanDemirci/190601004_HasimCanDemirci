using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public GameObject PlayersCar;
    public GameObject PlayersYacht;
    public GameObject PlayersAircraft;
    public GameObject AreasCar;
    public GameObject AreasYacht;
    public GameObject AreasAircraft;
    public GameObject quitCar;
    public GameObject quitYacht;
    public GameObject quitAircraft;
    public SkinnedMeshRenderer skinnedMesh;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            PlayersCar.SetActive(true);
            AreasCar.SetActive(false);
            quitCar.SetActive(true);

        }

        if (other.CompareTag("Yacht"))
        {
            PlayersYacht.SetActive(true);
            AreasYacht.SetActive(false);
            quitYacht.SetActive(true);
        }

        if (other.CompareTag("Aircraft"))
        {
            PlayersAircraft.SetActive(true);
            AreasAircraft.SetActive(false);
            quitAircraft.SetActive(true);
            skinnedMesh.enabled = false;
        }
    }

    public void ExitCar()
    {
        PlayersCar.SetActive(false);
        AreasCar.SetActive(true);
        this.transform.position = new Vector3(this.transform.position.x - 3, this.transform.position.y, this.transform.position.z);
        quitCar.SetActive(false);

    }

    public void ExitYacth()
    {
        PlayersYacht.SetActive(false);
        AreasYacht.SetActive(true);
        this.transform.position = new Vector3(100, this.transform.position.y,-1);
        quitYacht.SetActive(false);
    }

    public void ExitAircraft()
    {
        PlayersAircraft.SetActive(false);
        AreasAircraft.SetActive(true);
        this.transform.position = new Vector3(100, this.transform.position.y, -1);
        quitAircraft.SetActive(false);
        skinnedMesh.enabled = true;
    }
}
