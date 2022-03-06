using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Nidoqueen Specie to store common natural stats of all Nidoqueens
	#region SpecieNidoqueen
	public class SpecieNidoqueen : PokemonSpecie
	{
#nullable enable
		private static SpecieNidoqueen? _instance = null;
#nullable restore
        public static SpecieNidoqueen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNidoqueen();
                }
                return _instance;
            }
        }

		#region SpecieNidoqueen Builder
		public SpecieNidoqueen() : base(
			"Nidoqueen",
			90, // HPs
			92, 87, // Attack & Defense
			75, 85, // Special Attack & Defense
			76		
		)
		{
			this._height = 13;
			this._weight = 600;
		}
		#endregion
	}
	#endregion

	//Nidoqueen Pokemon Class
	#region Nidoqueen
	public class Nidoqueen : Pokemon
	{
		#region Nidoqueen Builders
		/// <summary>
		/// Nidoqueen Builder waiting for a Nickname & a Level
		/// </summary>
		public Nidoqueen(string nickname, int level)
		: base(
				31,
				SpecieNidoqueen.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoqueen Builder only waiting for a Level
		/// </summary>
		public Nidoqueen(int level)
		: base(
				31,
				SpecieNidoqueen.Instance, // Pokemon Specie
				"Nidoqueen", level,
				Poison.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoqueen Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Nidoqueen() : base(
			31,
			SpecieNidoqueen.Instance, // Pokemon Specie
			Poison.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}