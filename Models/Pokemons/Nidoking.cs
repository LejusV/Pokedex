using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nidoking Specie to store common natural stats of all Nidokings
	#region SpecieNidoking
	public class SpecieNidoking : PokemonSpecie
	{
#nullable enable
		private static SpecieNidoking? _instance = null;
#nullable restore
        public static SpecieNidoking Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNidoking();
                }
                return _instance;
            }
        }

		#region SpecieNidoking Builder
		public SpecieNidoking() : base(
			"Nidoking",
			81, // HPs
			102, 77, // Attack & Defense
			85, 75, // Special Attack & Defense
			85			
		) {}
		#endregion
	}
	#endregion

	//Nidoking Pokemon Class
	#region Nidoking
	public class Nidoking : Pokemon
	{
		#region Nidoking Builders
		/// <summary>
		/// Nidoking Builder waiting for a Nickname & a Level
		/// </summary>
		public Nidoking(string nickname, int level)
		: base(
				34,
				SpecieNidoking.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoking Builder only waiting for a Level
		/// </summary>
		public Nidoking(int level)
		: base(
				34,
				SpecieNidoking.Instance, // Pokemon Specie
				"Nidoking", level,
				Poison.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoking Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Nidoking() : base(
			34,
			SpecieNidoking.Instance, // Pokemon Specie
			Poison.Instance, Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}