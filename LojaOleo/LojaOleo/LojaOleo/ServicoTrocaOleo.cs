﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOleo
{
	public class ServicoTrocaOleo
	{
		public int Codigo { get; set; }
		public DateTime Data { get; set; }
		public Cliente Cliente { get; set; }
		public Oleo Oleo { get; set; }
		public int QtdeLitros { get; set; }
	}
}
