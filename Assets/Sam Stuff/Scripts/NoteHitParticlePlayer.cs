using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHitParticlePlayer : MonoBehaviour
{
    public ParticleSystem leftArrowParticle;
    public ParticleSystem rightArrowParticle;
    public ParticleSystem aKeyParticle;
    public ParticleSystem dKeyParticle;

    public void LeftArrowHit()
    {
        leftArrowParticle.Play();
    }

    public void RightArrowHit()
    {
        rightArrowParticle.Play();
    }

    public void AKeyHit()
    {
        aKeyParticle.Play();
    }

    public void DKeyHit()
    {
        dKeyParticle.Play();
    }
}
