using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Uxie Specie to store common natural stats of all Uxies
	#region SpecieUxie
	public class SpecieUxie : PokemonSpecie
	{
#nullable enable
		private static SpecieUxie? _instance = null;
#nullable restore
        public static SpecieUxie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieUxie();
                }
                return _instance;
            }
        }

		#region SpecieUxie Builder
		public SpecieUxie() : base(
			"Uxie",
			75, // HPs
			75, 130, // Attack & Defense
			75, 130, // Special Attack & Defense
			95			
		) {}
		#endregion
	}
	#endregion

	//Uxie Pokemon Class
	#region Uxie
	public class Uxie : Pokemon
	{
		#region Uxie Builders
		/// <summary>
		/// Uxie Builder waiting for a Nickname & a Level
		/// </summary>
		public Uxie(string nickname, int level)
		: base(
				480,
				SpecieUxie.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Uxie Builder only waiting for a Level
		/// </summary>
		public Uxie(int level)
		: base(
				480,
				SpecieUxie.Instance, // Pokemon Specie
				"Uxie", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Uxie Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Uxie() : base(
			480,
			SpecieUxie.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}