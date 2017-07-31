/*
 * BlitCore 2D Framework
 * 
 * Copyright (c) 2016 Håkan Edling 
 * hakan@tidyui.com
 * @tidyui
 * http://github.com/blitbusters
 * 
 */

using System;

namespace BlitCore
{
	/// <summary>
	/// Simple interface for abstracting controller input.
	/// </summary>
	public interface IInput
	{
		/// <summary>
		/// Gets the current value of the horizontal axis.
		/// </summary>
		float GetHorizontal();

		/// <summary>
		/// Gets the current value of the vertical axis.
		/// </summary>
		float GetVertical();

		/// <summary>
		/// Gets if the specified button is pressed.
		/// </summary>
		bool GetButton(string button);
	}
}
