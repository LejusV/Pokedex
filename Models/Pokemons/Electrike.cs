using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Electrike Specie to store common natural stats of all Electrikes
	#region SpecieElectrike
	public class SpecieElectrike : PokemonSpecie
	{
#nullable enable
		private static SpecieElectrike? _instance = null;
#nullable restore
        public static SpecieElectrike Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieElectrike();
                }
                return _instance;
            }
        }

		#region SpecieElectrike Builder
		public SpecieElectrike() : base(
			"Electrike",
			0.6,
			15.2,
			40, // HPs
			45, 40, // Attack & Defense
			65, 40, // Special Attack & Defense
			65		
		)
		{}
		#endregion
	}
	#endregion

	//Electrike Pokemon Class
	#region Electrike
	public class Electrike : Pokemon
	{
		#region Electrike Builders
		/// <summary>
		/// Electrike Builder waiting for a Nickname & a Level
		/// </summary>
		public Electrike(string nickname, int level)
		: base(
				309,
				SpecieElectrike.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electrike Builder only waiting for a Level
		/// </summary>
		public Electrike(int level)
		: base(
				309,
				SpecieElectrike.Instance, // Pokemon Specie
				"Electrike", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electrike Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Electrike() : base(
			309,
			SpecieElectrike.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}