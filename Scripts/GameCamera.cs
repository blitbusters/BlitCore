/*
 * BlitCore 2D Framework
 * 
 * Copyright (c) 2016 Håkan Edling 
 * hakan@tidyui.com
 * @tidyui
 * http://github.com/blitbusters
 * 
 */

using UnityEngine;
using System.Collections;

namespace BlitCore
{
	[RequireComponent(typeof(Camera))]
	public class GameCamera : MonoBehaviour 
	{
		/// <summary>
		/// The previous screen height.
		/// </summary>
		private float height = 0f;

		/// <summary>
		/// The optional pixels per unit. If this isn't set the
		/// setting from the GameManager will be used.
		/// </summary>
		public int pixelsPerUnit;

		/// <summary>
		/// The target height in pixels.
		/// </summary>
		public int targetHeight;

		/// <summary>
		/// The current screen setup.
		/// </summary>
		public ScreenSetup screen;

		/// <summary>
		/// Checks if any screen properties as been changed since the last update.
		/// </summary>
		protected virtual void FixedUpdate () {
			if (Screen.height != height) {
				var mgr = BlitEngine.Instance;
				var pix = pixelsPerUnit > 0 ? pixelsPerUnit : mgr.pixelsPerUnit;

				if (targetHeight != 0 && mgr.pixelsPerUnit != 0) {
					height = Screen.height;
					screen = ScreenSetup.Get (Screen.width, Screen.height, targetHeight, pix);

					mgr.Zoom = screen.zoom;

					Camera.main.orthographicSize = screen.zoomedCameraHeight;
				}                  
			}
		}

		/// <summary>
		/// Adjusts the camera position to the closes pixel unit.
		/// </summary>
		protected virtual void LateUpdate () {
			transform.position = Utils.RoundToNearestPixel (transform.position);
		}
	}
}
