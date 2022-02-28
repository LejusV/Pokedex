using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Trapinch Specie to store common natural stats of all Trapinchs
	#region SpecieTrapinch
	public class SpecieTrapinch : PokemonSpecie
	{
#nullable enable
		private static SpecieTrapinch? _instance = null;
#nullable restore
        public static SpecieTrapinch Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTrapinch();
                }
                return _instance;
            }
        }

		#region SpecieTrapinch Builder
		public SpecieTrapinch() : base(
			"Trapinch",
			45, // HPs
			100, 45, // Attack & Defense
			45, 45, // Special Attack & Defense
			10			
		) {}
		#endregion
	}
	#endregion

	//Trapinch Pokemon Class
	#region Trapinch
	public class Trapinch : Pokemon
	{
		#region Trapinch Builders
		/// <summary>
		/// Trapinch Builder waiting for a Nickname & a Level
		/// </summary>
		public Trapinch(string nickname, int level)
		: base(
				328,
				SpecieTrapinch.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trapinch Builder only waiting for a Level
		/// </summary>
		public Trapinch(int level)
		: base(
				328,
				SpecieTrapinch.Instance, // Pokemon Specie
				"Trapinch", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trapinch Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Trapinch() : base(
			328,
			SpecieTrapinch.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}