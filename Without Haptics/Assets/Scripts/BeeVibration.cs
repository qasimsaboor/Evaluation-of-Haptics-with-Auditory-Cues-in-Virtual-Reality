using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SG
{
	public class BeeVibration : MonoBehaviour
	{
		public SG_HapticGlove[] hapticGloves = new SG_HapticGlove[0];
		public SG_Waveform waveFormToSend;
		public SG_Waveform[] allWaveForms = new SG_Waveform[0];
		protected int selectedWaveForm = 0;
		public void SendWaveForm()
		{
			Debug.Log("Sending " + waveFormToSend.name + " to " + hapticGloves.Length + " gloves");
			foreach (SG_HapticGlove glove in hapticGloves)
			{
				if (glove != null)
				{
					glove.SendCmd(waveFormToSend);
				}
			}
		}
		void Start()
		{
			if (this.waveFormToSend != null)
			{
				int index = -1;
				for (int i = 0; i < this.allWaveForms.Length; i++)
				{
					if (allWaveForms[i] == this.waveFormToSend)
					{
						index = i;
						break;
					}
				}
				this.selectedWaveForm = index;
			}
			else if (this.allWaveForms.Length > 0)
			{
				this.waveFormToSend = allWaveForms[0];
				this.selectedWaveForm = 0;
			}
		}

		void OnTriggerEnter(Collider other)
		{
			if (other.gameObject.tag == "Index")
			{
				SendWaveForm();
				Debug.Log("waveform sent");
			}
		}
	}
}
