﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Mafia
{
	public partial class NightForNoMafia : ContentPage
	{
		public NightForNoMafia()
		{
			InitializeComponent();
		}



		protected override void OnAppearing() // убрать линию сверху
		{
			base.OnAppearing();
			NavigationPage.SetHasNavigationBar(this, false);
		}
	}
}
