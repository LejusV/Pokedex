using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Solosis Specie to store common natural stats of all Solosiss
	#region SpecieSolosis
	public class SpecieSolosis : PokemonSpecie
	{
#nullable enable
		private static SpecieSolosis? _instance = null;
#nullable restore
        public static SpecieSolosis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSolosis();
                }
                return _instance;
            }
        }

		#region SpecieSolosis Builder
		public SpecieSolosis() : base(
			"Solosis",
			45, // HPs
			30, 40, // Attack & Defense
			105, 50, // Special Attack & Defense
			20		
		)
		{
			this._height = 3;
			this._weight = 10;
		}
		#endregion
	}
	#endregion

	//Solosis Pokemon Class
	#region Solosis
	public class Solosis : Pokemon
	{
		#region Solosis Builders
		/// <summary>
		/// Solosis Builder waiting for a Nickname & a Level
		/// </summary>
		public Solosis(string nickname, int level)
		: base(
				577,
				SpecieSolosis.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solosis Builder only waiting for a Level
		/// </summary>
		public Solosis(int level)
		: base(
				577,
				SpecieSolosis.Instance, // Pokemon Specie
				"Solosis", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solosis Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Solosis() : base(
			577,
			SpecieSolosis.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}