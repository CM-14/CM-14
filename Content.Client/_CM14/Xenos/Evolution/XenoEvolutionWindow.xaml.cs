﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._CM14.Xenos.Evolution;

[GenerateTypedNameReferences]
public sealed partial class XenoEvolutionWindow : DefaultWindow
{
    public XenoEvolutionWindow()
    {
        RobustXamlLoader.Load(this);
    }
}
