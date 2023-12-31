﻿using System.ComponentModel.DataAnnotations;

namespace EfCoreApp.Data
{
	public class Ogretmen
	{
		[Key]
		public int OgretmenId { get; set; }
		public string? Ad { get; set; }
		public string? Soyad { get; set; }
		public string? Eposta { get; set; }
		public string? Telefon { get; set; }
		public DateTime BaslamaTarihi { get; set; }
		public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();
	}
}
