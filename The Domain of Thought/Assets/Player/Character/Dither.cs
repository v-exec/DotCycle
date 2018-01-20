using UnityEngine;

namespace Assets.Scripts.Cam.Effects {
	
	[ExecuteInEditMode]
	[RequireComponent(typeof(UnityEngine.Camera))]
	[AddComponentMenu("Image Effects/Custom/Dither")]

	public class Dither : MonoBehaviour {
		private Material m_material;
		private Shader shader;

		private Material material {
			get {
				if (m_material == null) {
					shader = Shader.Find("Dither");
					m_material = new Material(shader) {hideFlags = HideFlags.DontSave};
				}
				return m_material;
			}
		}

		public void OnRenderImage(RenderTexture src, RenderTexture dest) {
			if (material) Graphics.Blit(src, dest, material);
		}
	}
}