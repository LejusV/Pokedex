using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Solrock Specie to store common natural stats of all Solrocks
	#region SpecieSolrock
	public class SpecieSolrock : PokemonSpecie
	{
#nullable enable
		private static SpecieSolrock? _instance = null;
#nullable restore
        public static SpecieSolrock Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSolrock();
                }
                return _instance;
            }
        }

		#region SpecieSolrock Builder
		public SpecieSolrock() : base(
			"Solrock",
			90, // HPs
			95, 85, // Attack & Defense
			55, 65, // Special Attack & Defense
			70			
		) {}
		#endregion
	}
	#endregion

	//Solrock Pokemon Class
	#region Solrock
	public class Solrock : Pokemon
	{
		#region Solrock Builders
		/// <summary>
		/// Solrock Builder waiting for a Nickname & a Level
		/// </summary>
		public Solrock(string nickname, int level)
		: base(
				338,
				SpecieSolrock.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solrock Builder only waiting for a Level
		/// </summary>
		public Solrock(int level)
		: base(
				338,
				SpecieSolrock.Instance, // Pokemon Specie
				"Solrock", level,
				Rock.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solrock Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Solrock() : base(
			338,
			SpecieSolrock.Instance, // Pokemon Specie
			Rock.Instance, Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}