using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Nidorina Specie to store common natural stats of all Nidorinas
	#region SpecieNidorina
	public class SpecieNidorina : PokemonSpecie
	{
#nullable enable
		private static SpecieNidorina? _instance = null;
#nullable restore
        public static SpecieNidorina Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNidorina();
                }
                return _instance;
            }
        }

		#region SpecieNidorina Builder
		public SpecieNidorina() : base(
			"Nidorina",
			70, // HPs
			62, 67, // Attack & Defense
			55, 55, // Special Attack & Defense
			56		
		)
		{
			this._height = 8;
			this._weight = 200;
		}
		#endregion
	}
	#endregion

	//Nidorina Pokemon Class
	#region Nidorina
	public class Nidorina : Pokemon
	{
		#region Nidorina Builders
		/// <summary>
		/// Nidorina Builder waiting for a Nickname & a Level
		/// </summary>
		public Nidorina(string nickname, int level)
		: base(
				30,
				SpecieNidorina.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidorina Builder only waiting for a Level
		/// </summary>
		public Nidorina(int level)
		: base(
				30,
				SpecieNidorina.Instance, // Pokemon Specie
				"Nidorina", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidorina Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Nidorina() : base(
			30,
			SpecieNidorina.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}