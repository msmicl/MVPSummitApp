﻿using System;
using Android.App;
using Android.Content;
using Android.Net;
using MVPSummitApp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(NetworkConnection))]
namespace MVPSummitApp.Droid
{
	public class NetworkConnection : INetworkConnection
	{
		public bool IsConnected { get; set; }
		public void CheckNetworkConnection()
		{
			var connectivityManager = (ConnectivityManager)Android.App.Application.Context.GetSystemService(Context.ConnectivityService);
			var activeNetworkInfo = connectivityManager.ActiveNetworkInfo;
			if (activeNetworkInfo != null && activeNetworkInfo.IsConnectedOrConnecting)
			{
				IsConnected = true;
			}
			else
			{
				IsConnected = false;
			}
		}
	}
}
