using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Celebi Specie to store common natural stats of all Celebis
	#region SpecieCelebi
	public class SpecieCelebi : PokemonSpecie
	{
#nullable enable
		private static SpecieCelebi? _instance = null;
#nullable restore
        public static SpecieCelebi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCelebi();
                }
                return _instance;
            }
        }

		#region SpecieCelebi Builder
		public SpecieCelebi() : base(
			"Celebi",
			0.6,
			5.0,
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100		
		)
		{}
		#endregion
	}
	#endregion

	//Celebi Pokemon Class
	#region Celebi
	public class Celebi : Pokemon
	{
		#region Celebi Builders
		/// <summary>
		/// Celebi Builder waiting for a Nickname & a Level
		/// </summary>
		public Celebi(string nickname, int level)
		: base(
				251,
				SpecieCelebi.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Celebi Builder only waiting for a Level
		/// </summary>
		public Celebi(int level)
		: base(
				251,
				SpecieCelebi.Instance, // Pokemon Specie
				"Celebi", level,
				Psychic.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Celebi Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Celebi() : base(
			251,
			SpecieCelebi.Instance, // Pokemon Specie
			Psychic.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}