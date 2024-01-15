﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._CM14.Admin;

[GenerateTypedNameReferences]
public sealed partial class CMTransformButton : Button
{
    private static readonly Color HumanoidColor = Color.FromHex("#25A343");
    private static readonly Color HumanoidHighlightColor = Color.FromHex("#2EBA4F");
    private static readonly Color XenoColor = Color.FromHex("#8B36A6");
    private static readonly Color XenoHighlightColor = Color.FromHex("#BA58DB");

    private TransformType _type;

    public TransformType Type
    {
        get => _type;
        set
        {
            if (_type == value)
                return;

            _type = value;
            UpdateColor();
        }
    }

    public CMTransformButton()
    {
        RobustXamlLoader.Load(this);

        ModulateSelfOverride = Type switch
        {
            TransformType.Humanoid => HumanoidColor,
            TransformType.Xeno => XenoColor,
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    protected override void DrawModeChanged()
    {
        base.DrawModeChanged();
        UpdateColor();
    }

    private void UpdateColor()
    {
        ModulateSelfOverride = (Type, IsHovered) switch
        {
            (TransformType.Humanoid, true) => HumanoidHighlightColor,
            (TransformType.Humanoid, false) => HumanoidColor,
            (TransformType.Xeno, true) => XenoHighlightColor,
            (TransformType.Xeno, false) => XenoColor,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}

public enum TransformType
{
    Humanoid,
    Xeno
}
