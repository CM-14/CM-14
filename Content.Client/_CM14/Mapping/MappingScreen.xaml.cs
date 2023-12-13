﻿using System.Numerics;
using Content.Client.UserInterface.Screens;
using Content.Client.UserInterface.Systems.Chat.Widgets;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._CM14.Mapping;

[GenerateTypedNameReferences]
public sealed partial class MappingScreen : InGameScreen
{
    public override ChatBox ChatBox => GetWidget<ChatBox>()!;

    public MappingScreen()
    {
        RobustXamlLoader.Load(this);

        AutoscaleMaxResolution = new Vector2i(1080, 770);

        SetAnchorPreset(ScreenContainer, LayoutPreset.Wide);
        SetAnchorPreset(ViewportContainer, LayoutPreset.Wide);
        SetAnchorPreset(SpawnContainer, LayoutPreset.Wide);
        SetAnchorPreset(MainViewport, LayoutPreset.Wide);
        SetAnchorAndMarginPreset(Hotbar, LayoutPreset.BottomWide, margin: 5);

        ScreenContainer.OnSplitResizeFinished += () =>
            OnChatResized?.Invoke(new Vector2(ScreenContainer.SplitFraction, 0));
    }

    public override void SetChatSize(Vector2 size)
    {
        ScreenContainer.DesiredSplitCenter = size.X;
        ScreenContainer.ResizeMode = SplitContainer.SplitResizeMode.RespectChildrenMinSize;
    }

    public IEnumerable<Control> GetActions()
    {
        yield return Add;
        yield return Fill;
        yield return Grab;
        yield return Move;
        yield return Pick;
    }

    public void UnPressActionsExcept(Control except)
    {
        Add.Pressed = Add == except;
        Fill.Pressed = Fill == except;
        Grab.Pressed = Grab == except;
        Move.Pressed = Move == except;
        Pick.Pressed = Pick == except;
    }
}
