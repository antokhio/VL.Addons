﻿using System.ComponentModel;

namespace Stride.Graphics.BlendStateDescription
{
    [Flags]
    public enum BlendStateEnum
    {
        [Description("Disabled")]
        Disabled = 0,
        [Description("Add")]
        Add = 1,
        [Description("Blend")]
        Blend = 2,
        [Description("Multiply")]
        Multiply = 3,
        [Description("AlphaAdd")]
        AlphaAdd = 4,
        [Description("TextDefault")]
        TextDefault = 5,
        [Description("Keep")]
        Keep = 6,
        [Description("ConstantFactor")]
        ConstantFactor = 7,
        [Description("BlendDestination")]
        BlendDestination = 8,
        [Description("ReplaceApha")]
        ReplaceApha = 9,
        [Description("MultiplyAlpha")]
        MultiplyAlpha = 10,
    }
}