using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Volbeat Specie to store common natural stats of all Volbeats
	#region SpecieVolbeat
	public class SpecieVolbeat : PokemonSpecie
	{
#nullable enable
		private static SpecieVolbeat? _instance = null;
#nullable restore
        public static SpecieVolbeat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVolbeat();
                }
                return _instance;
            }
        }

		#region SpecieVolbeat Builder
		public SpecieVolbeat() : base(
			"Volbeat",
			0.7,
			17.7,
			65, // HPs
			73, 75, // Attack & Defense
			47, 85, // Special Attack & Defense
			85		
		)
		{}
		#endregion
	}
	#endregion

	//Volbeat Pokemon Class
	#region Volbeat
	public class Volbeat : Pokemon
	{
		#region Volbeat Builders
		/// <summary>
		/// Volbeat Builder waiting for a Nickname & a Level
		/// </summary>
		public Volbeat(string nickname, int level)
		: base(
				313,
				SpecieVolbeat.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volbeat Builder only waiting for a Level
		/// </summary>
		public Volbeat(int level)
		: base(
				313,
				SpecieVolbeat.Instance, // Pokemon Specie
				"Volbeat", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volbeat Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Volbeat() : base(
			313,
			SpecieVolbeat.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}