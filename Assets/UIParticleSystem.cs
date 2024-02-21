using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIParticleSystem : MaskableGraphic
{
    [SerializeField] private ParticleSystemRenderer _particleStstemRenderer;
    [SerializeField] private Camera _bakecamera;
    protected override void OnPopulateMesh(Mesh m)
    {
        base.OnPopulateMesh(m);

      //  _particleStstemRenderer.BakeMesh(m, _bakecamera);
    }
}
