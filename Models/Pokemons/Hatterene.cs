using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Hatterene Specie to store common natural stats of all Hatterenes
	#region SpecieHatterene
	public class SpecieHatterene : PokemonSpecie
	{
#nullable enable
		private static SpecieHatterene? _instance = null;
#nullable restore
        public static SpecieHatterene Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHatterene();
                }
                return _instance;
            }
        }

		#region SpecieHatterene Builder
		public SpecieHatterene() : base(
			"Hatterene",
			57, // HPs
			90, 95, // Attack & Defense
			136, 103, // Special Attack & Defense
			29		
		)
		{
			this._height = 21;
			this._weight = 51;
		}
		#endregion
	}
	#endregion

	//Hatterene Pokemon Class
	#region Hatterene
	public class Hatterene : Pokemon
	{
		#region Hatterene Builders
		/// <summary>
		/// Hatterene Builder waiting for a Nickname & a Level
		/// </summary>
		public Hatterene(string nickname, int level)
		: base(
				858,
				SpecieHatterene.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hatterene Builder only waiting for a Level
		/// </summary>
		public Hatterene(int level)
		: base(
				858,
				SpecieHatterene.Instance, // Pokemon Specie
				"Hatterene", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hatterene Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Hatterene() : base(
			858,
			SpecieHatterene.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}