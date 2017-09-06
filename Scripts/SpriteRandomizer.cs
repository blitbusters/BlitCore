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
	/// <summary>
	/// Script for randomizing the sprite from an array of sprites.
	/// This is useful when wanting to acheive variety without putting
	/// this mundane task on the level designer.
	/// </summary>
	[ExecuteInEditMode]
	[RequireComponent(typeof(SpriteRenderer))]
	public class SpriteRandomizer : MonoBehaviour 
	{
		/// <summary>
		/// The threshold for when a variation occurs.
		/// </summary>
		[Range(0f, 1f)]
		public float threshold = 1.0f;

		/// <summary>
		/// The sprites to randomize from;
		/// </summary>
		public Sprite[] sprites;

		/// <summary>
		/// Starts the behaviour.
		/// </summary>
		void Start () {
			if (sprites.Length > 0) {
				if (Random.Range (0.0f, 1.0f) <= threshold) {
					var renderer = GetComponent<SpriteRenderer> ();

					if (renderer != null && sprites.Length > 0)
						renderer.sprite = sprites [Random.Range (0, sprites.Length)];
				}
			}
		}
	}
}
