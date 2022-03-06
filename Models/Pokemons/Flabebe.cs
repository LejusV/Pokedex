using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Flabebe Specie to store common natural stats of all Flabebes
	#region SpecieFlabebe
	public class SpecieFlabebe : PokemonSpecie
	{
#nullable enable
		private static SpecieFlabebe? _instance = null;
#nullable restore
        public static SpecieFlabebe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFlabebe();
                }
                return _instance;
            }
        }

		#region SpecieFlabebe Builder
		public SpecieFlabebe() : base(
			"Flabebe",
			44, // HPs
			38, 39, // Attack & Defense
			61, 79, // Special Attack & Defense
			42		
		)
		{
			this._height = 1;
			this._weight = 1;
		}
		#endregion
	}
	#endregion

	//Flabebe Pokemon Class
	#region Flabebe
	public class Flabebe : Pokemon
	{
		#region Flabebe Builders
		/// <summary>
		/// Flabebe Builder waiting for a Nickname & a Level
		/// </summary>
		public Flabebe(string nickname, int level)
		: base(
				669,
				SpecieFlabebe.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flabebe Builder only waiting for a Level
		/// </summary>
		public Flabebe(int level)
		: base(
				669,
				SpecieFlabebe.Instance, // Pokemon Specie
				"Flabebe", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flabebe Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Flabebe() : base(
			669,
			SpecieFlabebe.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}