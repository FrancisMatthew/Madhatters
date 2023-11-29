using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHitParticlePlayer : MonoBehaviour
{
    public ParticleSystem leftArrowParticle;
    public ParticleSystem rightArrowParticle;
    public ParticleSystem aKeyParticle;
    public ParticleSystem dKeyParticle;

    // If the left arrow is hit, the left arrow particle plays
    public void LeftArrowHit()
    {
        leftArrowParticle.Play();
    }

    // If the right arrow is hit, the right arrow particle plays
    public void RightArrowHit()
    {
        rightArrowParticle.Play();
    }

    // If the A key is hit, the A key particle plays
    public void AKeyHit()
    {
        aKeyParticle.Play();
    }

    // If the D key is hit, the D key particle plays
    public void DKeyHit()
    {
        dKeyParticle.Play();
    }
}
