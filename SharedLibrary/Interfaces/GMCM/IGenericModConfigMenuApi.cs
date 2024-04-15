﻿namespace SharedLibrary.Interfaces.GMCM;

#region using directives

using System;
using StardewModdingAPI;

#endregion

public interface IGenericModConfigMenuApi
{
	/// <summary>
	/// Register a mod whose config can be edited through the UI.
	/// </summary>
	void Register(IManifest mod, Action reset, Action save, bool titleScreenOnly = false);
	/// <summary>
	/// Add a section title at the current position in the form.
	/// </summary>
	void AddSectionTitle(IManifest mod, Func<string> text, Func<string>? tooltip = null);
	/// <summary>
	/// Add an integer option at the current position in the form.
	/// </summary>
	void AddNumberOption(IManifest mod, Func<int> getValue, Action<int> setValue, Func<string> name, Func<string>? tooltip = null, int? min = null, int? max = null, int? interval = null, Func<int, string>? formatValue = null, string? fieldId = null);
	/// <summary>
	/// Add a float option at the current position in the form.
	/// </summary>
	void AddNumberOption(IManifest mod, Func<float> getValue, Action<float> setValue, Func<string> name, Func<string>? tooltip = null, float? min = null, float? max = null, float? interval = null, Func<float, string>? formatValue = null, string? fieldId = null);
}
