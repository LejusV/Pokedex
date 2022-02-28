using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Seel Specie to store common natural stats of all Seels
	#region SpecieSeel
	public class SpecieSeel : PokemonSpecie
	{
#nullable enable
		private static SpecieSeel? _instance = null;
#nullable restore
        public static SpecieSeel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSeel();
                }
                return _instance;
            }
        }

		#region SpecieSeel Builder
		public SpecieSeel() : base(
			"Seel",
			65, // HPs
			45, 55, // Attack & Defense
			45, 70, // Special Attack & Defense
			45			
		) {}
		#endregion
	}
	#endregion

	//Seel Pokemon Class
	#region Seel
	public class Seel : Pokemon
	{
		#region Seel Builders
		/// <summary>
		/// Seel Builder waiting for a Nickname & a Level
		/// </summary>
		public Seel(string nickname, int level)
		: base(
				86,
				SpecieSeel.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seel Builder only waiting for a Level
		/// </summary>
		public Seel(int level)
		: base(
				86,
				SpecieSeel.Instance, // Pokemon Specie
				"Seel", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seel Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Seel() : base(
			86,
			SpecieSeel.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}