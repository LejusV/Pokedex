using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Magnemite Specie to store common natural stats of all Magnemites
	#region SpecieMagnemite
	public class SpecieMagnemite : PokemonSpecie
	{
#nullable enable
		private static SpecieMagnemite? _instance = null;
#nullable restore
        public static SpecieMagnemite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagnemite();
                }
                return _instance;
            }
        }

		#region SpecieMagnemite Builder
		public SpecieMagnemite() : base(
			"Magnemite",
			0.3,
			6.0,
			25, // HPs
			35, 70, // Attack & Defense
			95, 55, // Special Attack & Defense
			45		
		)
		{}
		#endregion
	}
	#endregion

	//Magnemite Pokemon Class
	#region Magnemite
	public class Magnemite : Pokemon
	{
		#region Magnemite Builders
		/// <summary>
		/// Magnemite Builder waiting for a Nickname & a Level
		/// </summary>
		public Magnemite(string nickname, int level)
		: base(
				81,
				SpecieMagnemite.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magnemite Builder only waiting for a Level
		/// </summary>
		public Magnemite(int level)
		: base(
				81,
				SpecieMagnemite.Instance, // Pokemon Specie
				"Magnemite", level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magnemite Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Magnemite() : base(
			81,
			SpecieMagnemite.Instance, // Pokemon Specie
			Electric.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}