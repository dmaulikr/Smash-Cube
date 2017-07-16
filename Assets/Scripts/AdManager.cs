﻿using UnityEngine;
using admob;

/* 
	@author Hudson Schumaker
	@version 1.0.0
*/

public class AdManager : MonoBehaviour {

	public static AdManager instance = null;

	private string bannerId = "ca-app-pub-1780770631989213/7118088880";
	private string videoId  = "ca-app-pub-1780770631989213/8594822082";

	private void Awake() {
		Admob.Instance ().initAdmob (bannerId, videoId);
		Admob.Instance ().setTesting (true);
		Admob.Instance ().loadInterstitial ();
		if (instance == null){
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
		
	public void LoadBigBanner(){
		Admob.Instance ().loadInterstitial ();
	}
		
	public void ShowBanner(){
		Admob.Instance ().showBannerRelative (AdSize.Banner, AdPosition.TOP_CENTER, 5);
	}

	public void ShowBannerDown(){
		Admob.Instance ().showBannerRelative (AdSize.Banner, AdPosition.BOTTOM_CENTER, 5);
	}

	public void RemoveBanners(){
		Admob.Instance ().removeAllBanner ();
	}

	public void ShowVideo(){
		if(Admob.Instance ().isInterstitialReady()){
			Admob.Instance ().showInterstitial ();
		}
	}
}
