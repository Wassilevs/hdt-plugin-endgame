﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HDT.Plugins.EndGame
{
	public class Screenshot : INotifyPropertyChanged
	{
		private Boolean isSelected;

		public Bitmap Image { get; private set; }
		public BitmapImage Thumbnail { get; private set; }
		public Boolean IsSelected {
			get 
			{
				return isSelected;
			}
			set
			{
				if (isSelected != value)
				{
					isSelected = value;
					NotifyPropertyChanged("IsSelected");
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public Screenshot(Bitmap image, BitmapImage thumb)
		{
			Image = image;
			Thumbnail = thumb;
			IsSelected = false;
		}

		private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
	}
}
