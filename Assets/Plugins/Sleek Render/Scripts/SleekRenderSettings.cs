﻿using System;
using UnityEngine;

namespace SleekRender
{
    [CreateAssetMenu(menuName = "Sleek Render Settings")]
    [Serializable]
    public class SleekRenderSettings : ScriptableObject
    {
        [Header("Bloom")]
        public bool bloomExpanded = false;
        public bool bloomEnabled = true;

        public float bloomThreshold = 0.6f;

        public float bloomIntensity = 2.5f;
        public Color bloomTint = Color.white;

        public bool preserveAspectRatio = false;
        public int bloomTextureWidth = 128;
        public int bloomTextureHeight = 128;

        public LumaVectorType bloomLumaCalculationType = LumaVectorType.Uniform;
        public Vector3 bloomLumaVector = new Vector3(1f / 3f, 1f / 3f, 1f / 3f);

        [Header("Color overlay (alpha sets intensity)")]
        public bool colorizeExpanded = true;
        public bool colorizeEnabled = true;

        public Color32 colorize = Color.clear;

        [Header("Vignette")]
        public bool vignetteExpanded = true;
        public bool vignetteEnabled = true;


        public float vignetteBeginRadius = 0.166f;

        public float vignetteExpandRadius = 1.34f;

        public Color vignetteColor = Color.black;

        [Header("Contrast")]
        public bool contrastExpanded = false;
        public bool contrastEnabled = true;

        public float contrast = 1f;

        [Header("Brightness")]
        public bool brightnessExpanded = false;
        public bool brightnessEnabled = true;

        public float brightness = .5f;

        [Header("Total Cost")]
        public bool totalCostExpanded = false;
    }

    public enum LumaVectorType
    {
        Uniform,
        sRGB,
        Custom
    }
}