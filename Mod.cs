using System;
using System.Reflection;
using UnityEngine;
using ColossalFramework.UI;
using ICities;

namespace JP_CampusNameList
{
	public class JP_CampusNameList : IUserMod
	{

		public string Name
		{
			get { return "JP University Name List (CNL) v1.0.1"; }
		}

		public string Description
		{
			get { return "Custom Name Listsを使って、DLC Campusのキャンパスエリア名を変更します"; }
		}

	}
}