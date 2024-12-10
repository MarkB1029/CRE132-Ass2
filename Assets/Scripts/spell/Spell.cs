using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spell : MonoBehaviour
{


    [SerializeField] private GameObject spell;
    [SerializeField] private Transform SpellSpawnPoint;

    private GameObject spellInst;





    // Update is called once per frame
    void Update()
    {
        HandeleSpell();
    }



    private void HandeleSpell()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            spellInst = Instantiate(spell, SpellSpawnPoint.position, transform.rotation);
        }
    }
}
