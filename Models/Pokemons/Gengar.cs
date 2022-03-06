using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gengar Specie to store common natural stats of all Gengars
	#region SpecieGengar
	public class SpecieGengar : PokemonSpecie
	{
#nullable enable
		private static SpecieGengar? _instance = null;
#nullable restore
        public static SpecieGengar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGengar();
                }
                return _instance;
            }
        }

		#region SpecieGengar Builder
		public SpecieGengar() : base(
			"Gengar",
			60, // HPs
			65, 60, // Attack & Defense
			130, 75, // Special Attack & Defense
			110		
		)
		{
			this._height = 15;
			this._weight = 405;
		}
		#endregion
	}
	#endregion

	//Gengar Pokemon Class
	#region Gengar
	public class Gengar : Pokemon
	{
		#region Gengar Builders
		/// <summary>
		/// Gengar Builder waiting for a Nickname & a Level
		/// </summary>
		public Gengar(string nickname, int level)
		: base(
				94,
				SpecieGengar.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gengar Builder only waiting for a Level
		/// </summary>
		public Gengar(int level)
		: base(
				94,
				SpecieGengar.Instance, // Pokemon Specie
				"Gengar", level,
				Ghost.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gengar Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gengar() : base(
			94,
			SpecieGengar.Instance, // Pokemon Specie
			Ghost.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}