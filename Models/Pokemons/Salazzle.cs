using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Salazzle Specie to store common natural stats of all Salazzles
	#region SpecieSalazzle
	public class SpecieSalazzle : PokemonSpecie
	{
#nullable enable
		private static SpecieSalazzle? _instance = null;
#nullable restore
        public static SpecieSalazzle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSalazzle();
                }
                return _instance;
            }
        }

		#region SpecieSalazzle Builder
		public SpecieSalazzle() : base(
			"Salazzle",
			1.2,
			22.2,
			68, // HPs
			64, 60, // Attack & Defense
			111, 60, // Special Attack & Defense
			117		
		)
		{}
		#endregion
	}
	#endregion

	//Salazzle Pokemon Class
	#region Salazzle
	public class Salazzle : Pokemon
	{
		#region Salazzle Builders
		/// <summary>
		/// Salazzle Builder waiting for a Nickname & a Level
		/// </summary>
		public Salazzle(string nickname, int level)
		: base(
				758,
				SpecieSalazzle.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salazzle Builder only waiting for a Level
		/// </summary>
		public Salazzle(int level)
		: base(
				758,
				SpecieSalazzle.Instance, // Pokemon Specie
				"Salazzle", level,
				Poison.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salazzle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Salazzle() : base(
			758,
			SpecieSalazzle.Instance, // Pokemon Specie
			Poison.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}