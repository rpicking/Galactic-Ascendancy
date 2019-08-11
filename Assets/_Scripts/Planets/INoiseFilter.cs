using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INoiseFilter {

    float Evaluate(Vector3 point);
}

public abstract class NoiseFilter : INoiseFilter {

    protected Noise noise = new Noise();

    public abstract float Evaluate(Vector3 point);
}
