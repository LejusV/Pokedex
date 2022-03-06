using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Numel Specie to store common natural stats of all Numels
	#region SpecieNumel
	public class SpecieNumel : PokemonSpecie
	{
#nullable enable
		private static SpecieNumel? _instance = null;
#nullable restore
        public static SpecieNumel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNumel();
                }
                return _instance;
            }
        }

		#region SpecieNumel Builder
		public SpecieNumel() : base(
			"Numel",
			60, // HPs
			60, 40, // Attack & Defense
			65, 45, // Special Attack & Defense
			35		
		)
		{
			this._height = 7;
			this._weight = 240;
		}
		#endregion
	}
	#endregion

	//Numel Pokemon Class
	#region Numel
	public class Numel : Pokemon
	{
		#region Numel Builders
		/// <summary>
		/// Numel Builder waiting for a Nickname & a Level
		/// </summary>
		public Numel(string nickname, int level)
		: base(
				322,
				SpecieNumel.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Numel Builder only waiting for a Level
		/// </summary>
		public Numel(int level)
		: base(
				322,
				SpecieNumel.Instance, // Pokemon Specie
				"Numel", level,
				Fire.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Numel Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Numel() : base(
			322,
			SpecieNumel.Instance, // Pokemon Specie
			Fire.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}