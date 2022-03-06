using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mudsdale Specie to store common natural stats of all Mudsdales
	#region SpecieMudsdale
	public class SpecieMudsdale : PokemonSpecie
	{
#nullable enable
		private static SpecieMudsdale? _instance = null;
#nullable restore
        public static SpecieMudsdale Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMudsdale();
                }
                return _instance;
            }
        }

		#region SpecieMudsdale Builder
		public SpecieMudsdale() : base(
			"Mudsdale",
			100, // HPs
			125, 100, // Attack & Defense
			55, 85, // Special Attack & Defense
			35		
		)
		{
			this._height = 25;
			this._weight = 9200;
		}
		#endregion
	}
	#endregion

	//Mudsdale Pokemon Class
	#region Mudsdale
	public class Mudsdale : Pokemon
	{
		#region Mudsdale Builders
		/// <summary>
		/// Mudsdale Builder waiting for a Nickname & a Level
		/// </summary>
		public Mudsdale(string nickname, int level)
		: base(
				750,
				SpecieMudsdale.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudsdale Builder only waiting for a Level
		/// </summary>
		public Mudsdale(int level)
		: base(
				750,
				SpecieMudsdale.Instance, // Pokemon Specie
				"Mudsdale", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudsdale Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Mudsdale() : base(
			750,
			SpecieMudsdale.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}