﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PxPre
{
    namespace Phonics
    {
        public class GenSine : GenBase
        {
            public GenSine(float freq, double startTime, int samplesPerSec, float amplitude)
                : base(freq, startTime, samplesPerSec, amplitude)
            { }

            public override void AccumulateImpl(float[] data, int size)
            {
                double tIt = this.CurTime;
                double incr = this.TimePerSample;
                for (int i = 0; i < size; ++i)
                {
                    data[i] += Mathf.Sin((float)(tIt * this.TimeToFreq)) * this.amplitude;
                    tIt += incr;
                }
            }

            public override PlayState Finished()
            {
                return PlayState.Constant;
            }
        }
    }
}