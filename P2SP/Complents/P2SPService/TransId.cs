﻿/*
 * Created by SharpDevelop.
 * User: Pengzhihu
 * Date: 2014-7-16
 * Time: 10:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Complents.P2SPService
{
	/// <summary>
	/// Description of TransId.
	/// </summary>
	[Serializable]
	public class TransId
	{
		private string toId;
		
		public string ToId {
			get { return toId; }
			set { toId = value; }
		}
		private string fromId;
		
		public string FromId {
			get { return fromId; }
			set { fromId = value; }
		}
		
		private int seqno;
		
		public int Seqno {
			get { return seqno; }
			set { seqno = value; }
		}
		
		private TransType type;
		
		public TransType Type {
			get { return type; }
			set { type = value; }
		}
		

		public TransId(string _toId, string _fromId, TransType _type)
		{
			this.toId = _toId;
			this.fromId = _fromId;
			this.type = _type;
			this.seqno = TransIdMgr.Instance.GetSeqno();
		}
		
		public override string ToString()
		{
			return this.type + "; " + this.toId + "; " + this.fromId + "; " + this.seqno;
		}
	}
}
