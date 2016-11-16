﻿/*
 * Created by SharpDevelop.
 * User: Pengzhihu
 * Date: 2013-6-24
 * Time: 11:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace P2PService
{
	/// <summary>
	/// Description of ServerStartEventArgs.
	/// </summary>
	
	public delegate void TcpListenerStartEventHandler(object sender, TcpListenerStartEventArgs e);
	
	public class TcpListenerStartEventArgs : EventArgs
	{
		private int port;
		
		public int Port {
			get { return port; }
			set { port = value; }
		}
		
		public TcpListenerStartEventArgs()
		{
		}
		
		public TcpListenerStartEventArgs(int _port)
			: base()
		{
			this.port = _port;
		}
	}
}
