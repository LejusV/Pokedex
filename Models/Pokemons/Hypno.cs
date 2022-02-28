using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hypno Specie to store common natural stats of all Hypnos
	#region SpecieHypno
	public class SpecieHypno : PokemonSpecie
	{
#nullable enable
		private static SpecieHypno? _instance = null;
#nullable restore
        public static SpecieHypno Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHypno();
                }
                return _instance;
            }
        }

		#region SpecieHypno Builder
		public SpecieHypno() : base(
			"Hypno",
			85, // HPs
			73, 70, // Attack & Defense
			73, 115, // Special Attack & Defense
			67			
		) {}
		#endregion
	}
	#endregion

	//Hypno Pokemon Class
	#region Hypno
	public class Hypno : Pokemon
	{
		#region Hypno Builders
		/// <summary>
		/// Hypno Builder waiting for a Nickname & a Level
		/// </summary>
		public Hypno(string nickname, int level)
		: base(
				97,
				SpecieHypno.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hypno Builder only waiting for a Level
		/// </summary>
		public Hypno(int level)
		: base(
				97,
				SpecieHypno.Instance, // Pokemon Specie
				"Hypno", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hypno Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Hypno() : base(
			97,
			SpecieHypno.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}