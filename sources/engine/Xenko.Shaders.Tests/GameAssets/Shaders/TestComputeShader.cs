﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using Xenko.Core;
using Xenko.Effects;
using Xenko.Graphics;
using Xenko.Shaders;
using Xenko.Core.Mathematics;
using Buffer = Xenko.Graphics.Buffer;

namespace Xenko.Effects
{
    public static partial class TestComputeShaderKeys
    {
        public static readonly ParameterKey<Vector3> ThreadGroupCountGlobal = ParameterKeys.New<Vector3>();
        public static readonly ParameterKey<uint> ParticleCount = ParameterKeys.New<uint>();
        public static readonly ParameterKey<uint> ParticleStartIndex = ParameterKeys.New<uint>();
        public static readonly ParameterKey<Buffer> ParticleSortBuffer = ParameterKeys.New<Buffer>();
        public static readonly ParameterKey<Buffer> ParticleSortBufferRO = ParticleSortBuffer;
    }
}
