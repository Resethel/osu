﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Framework.Localisation;
using osu.Game.Graphics.UserInterface;

namespace osu.Game.Screens.Edit.Components.Menus
{
    public class EditorMenuItem : OsuMenuItem
    {
        private const int min_text_length = 40;

        public EditorMenuItem(LocalisableString text, MenuItemType type = MenuItemType.Standard)
            : base(LocalisableString.Interpolate($"{text,-min_text_length}"), type)
        {
        }

        public EditorMenuItem(LocalisableString text, MenuItemType type, Action action)
            : base(LocalisableString.Interpolate($"{text,-min_text_length}"), type, action)
        {
        }
    }
}
