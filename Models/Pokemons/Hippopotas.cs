using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Hippopotas Specie to store common natural stats of all Hippopotass
	#region SpecieHippopotas
	public class SpecieHippopotas : PokemonSpecie
	{
#nullable enable
		private static SpecieHippopotas? _instance = null;
#nullable restore
        public static SpecieHippopotas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHippopotas();
                }
                return _instance;
            }
        }

		#region SpecieHippopotas Builder
		public SpecieHippopotas() : base(
			"Hippopotas",
			68, // HPs
			72, 78, // Attack & Defense
			38, 42, // Special Attack & Defense
			32		
		)
		{
			this._height = 8;
			this._weight = 495;
		}
		#endregion
	}
	#endregion

	//Hippopotas Pokemon Class
	#region Hippopotas
	public class Hippopotas : Pokemon
	{
		#region Hippopotas Builders
		/// <summary>
		/// Hippopotas Builder waiting for a Nickname & a Level
		/// </summary>
		public Hippopotas(string nickname, int level)
		: base(
				449,
				SpecieHippopotas.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hippopotas Builder only waiting for a Level
		/// </summary>
		public Hippopotas(int level)
		: base(
				449,
				SpecieHippopotas.Instance, // Pokemon Specie
				"Hippopotas", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hippopotas Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Hippopotas() : base(
			449,
			SpecieHippopotas.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}