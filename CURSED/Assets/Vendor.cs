using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MainHero;

public class Vendor : MonoBehaviour
{

    public GameObject interactButton;
    public GameObject UIButtons;
    public GameObject tradeMenu;

    [SerializeField]
    private GameObject mainCharacter;
    public bool isNearVendor;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mainCharacter.GetComponent<ThirdPersonController>().vendor = gameObject.GetComponent<Vendor>();
            interactButton.SetActive(true);
            isNearVendor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactButton.SetActive(false);
            isNearVendor = false;
        }
    }
    public void OnExitButtonPressed()
    {
        tradeMenu.SetActive(false);
        UIButtons.SetActive(true);
    }

    public void BuyAxe()
    {
        // �������� �� ����
        
        mainCharacter.GetComponent<PlayerInventory>().addAxe();
        mainCharacter.GetComponent<PlayerInventory>().CheckWeaponInventory();
    }

    public void BuySpear()
    {

    }

    public void BuyFlask()
    {

    }

    public void BuySpell()
    {

    }
}
