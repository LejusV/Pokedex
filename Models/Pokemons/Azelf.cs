using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Azelf Specie to store common natural stats of all Azelfs
	#region SpecieAzelf
	public class SpecieAzelf : PokemonSpecie
	{
#nullable enable
		private static SpecieAzelf? _instance = null;
#nullable restore
        public static SpecieAzelf Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAzelf();
                }
                return _instance;
            }
        }

		#region SpecieAzelf Builder
		public SpecieAzelf() : base(
			"Azelf",
			0.3,
			0.3,
			75, // HPs
			125, 70, // Attack & Defense
			125, 70, // Special Attack & Defense
			115		
		)
		{}
		#endregion
	}
	#endregion

	//Azelf Pokemon Class
	#region Azelf
	public class Azelf : Pokemon
	{
		#region Azelf Builders
		/// <summary>
		/// Azelf Builder waiting for a Nickname & a Level
		/// </summary>
		public Azelf(string nickname, int level)
		: base(
				482,
				SpecieAzelf.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azelf Builder only waiting for a Level
		/// </summary>
		public Azelf(int level)
		: base(
				482,
				SpecieAzelf.Instance, // Pokemon Specie
				"Azelf", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azelf Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Azelf() : base(
			482,
			SpecieAzelf.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}