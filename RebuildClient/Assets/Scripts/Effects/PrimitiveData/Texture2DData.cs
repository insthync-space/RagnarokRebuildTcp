﻿using UnityEngine;
using UnityEngine.U2D;

namespace Assets.Scripts.Effects.PrimitiveData
{
    public class Texture2DData
    {
        public Vector2 Size;
        public Vector2 Speed;
        public Vector2 Acceleration;
        public Vector2 ScalingSpeed;
        public Vector2 ScalingAccel;
        public Vector2 MaxSize;
        public Vector2 MinSize;
        public Sprite Sprite;

        public float Alpha;
        public float AlphaSpeed;
        public Color Color = Color.white;
    }
}