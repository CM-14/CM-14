﻿using Robust.Client.AutoGenerated;
using Robust.Client.Graphics;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._CM14.Vendors;

[GenerateTypedNameReferences]
public sealed partial class CMAutomatedVendorPanel : Control
{
    private static readonly Color Color = Color.FromHex("#141F2F");
    private static readonly Color HoveredColor = Color.FromHex("#4972A1");
    private static readonly Color DisabledColor = Color.FromHex("#999999");

    public CMAutomatedVendorPanel()
    {
        RobustXamlLoader.Load(this);

        Button.OnDrawModeChanged += UpdateColor;
    }

    private void UpdateColor()
    {
        var panel = (StyleBoxFlat) Panel.PanelOverride!;
        if (Button.Disabled)
            panel.BackgroundColor = DisabledColor;
        else
            panel.BackgroundColor = Button.IsHovered ? HoveredColor : Color;
    }
}
