﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._CM14.Vendors;

[GenerateTypedNameReferences]
public sealed partial class CMAutomatedVendorWindow : DefaultWindow
{
    public CMAutomatedVendorWindow()
    {
        RobustXamlLoader.Load(this);
    }
}

