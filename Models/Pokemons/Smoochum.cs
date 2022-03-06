using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Smoochum Specie to store common natural stats of all Smoochums
	#region SpecieSmoochum
	public class SpecieSmoochum : PokemonSpecie
	{
#nullable enable
		private static SpecieSmoochum? _instance = null;
#nullable restore
        public static SpecieSmoochum Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSmoochum();
                }
                return _instance;
            }
        }

		#region SpecieSmoochum Builder
		public SpecieSmoochum() : base(
			"Smoochum",
			0.4,
			6.0,
			45, // HPs
			30, 15, // Attack & Defense
			85, 65, // Special Attack & Defense
			65		
		)
		{}
		#endregion
	}
	#endregion

	//Smoochum Pokemon Class
	#region Smoochum
	public class Smoochum : Pokemon
	{
		#region Smoochum Builders
		/// <summary>
		/// Smoochum Builder waiting for a Nickname & a Level
		/// </summary>
		public Smoochum(string nickname, int level)
		: base(
				238,
				SpecieSmoochum.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Smoochum Builder only waiting for a Level
		/// </summary>
		public Smoochum(int level)
		: base(
				238,
				SpecieSmoochum.Instance, // Pokemon Specie
				"Smoochum", level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Smoochum Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Smoochum() : base(
			238,
			SpecieSmoochum.Instance, // Pokemon Specie
			Ice.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}