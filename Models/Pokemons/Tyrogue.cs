using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tyrogue Specie to store common natural stats of all Tyrogues
	#region SpecieTyrogue
	public class SpecieTyrogue : PokemonSpecie
	{
#nullable enable
		private static SpecieTyrogue? _instance = null;
#nullable restore
        public static SpecieTyrogue Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTyrogue();
                }
                return _instance;
            }
        }

		#region SpecieTyrogue Builder
		public SpecieTyrogue() : base(
			"Tyrogue",
			35, // HPs
			35, 35, // Attack & Defense
			35, 35, // Special Attack & Defense
			35		
		)
		{
			this._height = 7;
			this._weight = 210;
		}
		#endregion
	}
	#endregion

	//Tyrogue Pokemon Class
	#region Tyrogue
	public class Tyrogue : Pokemon
	{
		#region Tyrogue Builders
		/// <summary>
		/// Tyrogue Builder waiting for a Nickname & a Level
		/// </summary>
		public Tyrogue(string nickname, int level)
		: base(
				236,
				SpecieTyrogue.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrogue Builder only waiting for a Level
		/// </summary>
		public Tyrogue(int level)
		: base(
				236,
				SpecieTyrogue.Instance, // Pokemon Specie
				"Tyrogue", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrogue Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Tyrogue() : base(
			236,
			SpecieTyrogue.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}