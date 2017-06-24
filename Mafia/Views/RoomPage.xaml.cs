﻿using System; using System.Collections.Generic;  using Xamarin.Forms;  namespace Mafia { 	public partial class RoomPage : ContentPage 	{ 		private RoomViewsModel Room; 		RoomViewsModel _viewModel;  		public RoomPage() 		{ 			InitializeComponent(); 			Room = new RoomViewsModel(this); 			this.BindingContext = _viewModel = new RoomViewsModel(this); 		}  		private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e) 		{ 			var useroom = (RoomModel)e.Item; 			GameService.Instance.GetRoomName(useroom.Name); 			GameService.Instance.Connect(GameService.Instance._userName); 			GameService.Instance.NewUser(GameService.Instance._userName); 			var app = (App)Application.Current; // без вовзврата на  			app.MainPage = new NavigationPage(new StartGameUserPage()); 		}  		protected async override void OnAppearing() 		{ 			base.OnAppearing();  			await _viewModel.LoadRooms(); 		} 	} }  