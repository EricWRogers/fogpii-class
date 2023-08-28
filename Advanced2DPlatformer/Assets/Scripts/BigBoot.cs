using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.GamePlay2D;

public class BigBoot : MonoBehaviour
{
    public List<string> tagsToCheck;
    public float downOffset = 0.2f;
    public int damage = 1;

    private CharacterController2D m_characterController2D;
    
    void Start()
    {
        m_characterController2D = GetComponent<CharacterController2D>();
    }

    
    void Update()
    {
        List<RaycastHit2D> hits = new List<RaycastHit2D>();

        if(!m_characterController2D.TestMove(Vector2.down, downOffset, tagsToCheck, hits))
        {
            foreach(RaycastHit2D hit in hits)
            {
                SuperPupSystems.Helper.Health hitHealth =
                    hit.collider.gameObject.GetComponent<SuperPupSystems.Helper.Health>();
                
                if (hitHealth)
                {
                    hitHealth.Damage(damage);
                }
            }
        }
    }
}
