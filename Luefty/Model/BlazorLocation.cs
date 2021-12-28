using System;
namespace Luefty.Model
{
	public class BlazorLocation
	{
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; }
        public List<BlazorCountry>? BlazorCountries { get; set; }
    }
}

