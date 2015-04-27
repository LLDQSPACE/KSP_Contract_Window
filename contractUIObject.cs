﻿#region license
/*The MIT License (MIT)
Contract UI Object - Object used for contracts in different mission lists

Copyright (c) 2014 DMagic

KSP Plugin Framework by TriggerAu, 2014: http://forum.kerbalspaceprogram.com/threads/66503-KSP-Plugin-Framework

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContractsWindow
{
	/// <summary>
	/// This is the object actually used by the contract window
	/// It stores data for each contract about ordering and whether its parameters are shown
	/// Different mission lists are able to store contracts in different states using this object
	/// </summary>
	public class contractUIObject
	{
		private contractContainer container;
		private bool showParams;
		private int? order;

		internal contractUIObject(contractContainer c)
		{
			container = c;
			showParams = true;
			order = null;
		}

		public contractContainer Container
		{
			get { return container; }
		}

		public bool ShowParams
		{
			get { return showParams; }
			internal set { showParams = value; }
		}

		public int? Order
		{
			get { return order; }
			internal set { order = value; }
		}
	}
}