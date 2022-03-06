using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Starmie Specie to store common natural stats of all Starmies
	#region SpecieStarmie
	public class SpecieStarmie : PokemonSpecie
	{
#nullable enable
		private static SpecieStarmie? _instance = null;
#nullable restore
        public static SpecieStarmie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStarmie();
                }
                return _instance;
            }
        }

		#region SpecieStarmie Builder
		public SpecieStarmie() : base(
			"Starmie",
			1.1,
			80.0,
			60, // HPs
			75, 85, // Attack & Defense
			100, 85, // Special Attack & Defense
			115		
		)
		{}
		#endregion
	}
	#endregion

	//Starmie Pokemon Class
	#region Starmie
	public class Starmie : Pokemon
	{
		#region Starmie Builders
		/// <summary>
		/// Starmie Builder waiting for a Nickname & a Level
		/// </summary>
		public Starmie(string nickname, int level)
		: base(
				121,
				SpecieStarmie.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Starmie Builder only waiting for a Level
		/// </summary>
		public Starmie(int level)
		: base(
				121,
				SpecieStarmie.Instance, // Pokemon Specie
				"Starmie", level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Starmie Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Starmie() : base(
			121,
			SpecieStarmie.Instance, // Pokemon Specie
			Water.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}