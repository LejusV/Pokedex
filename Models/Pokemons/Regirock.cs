using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Regirock Specie to store common natural stats of all Regirocks
	#region SpecieRegirock
	public class SpecieRegirock : PokemonSpecie
	{
#nullable enable
		private static SpecieRegirock? _instance = null;
#nullable restore
        public static SpecieRegirock Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRegirock();
                }
                return _instance;
            }
        }

		#region SpecieRegirock Builder
		public SpecieRegirock() : base(
			"Regirock",
			1.7,
			230.0,
			80, // HPs
			100, 200, // Attack & Defense
			50, 100, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Regirock Pokemon Class
	#region Regirock
	public class Regirock : Pokemon
	{
		#region Regirock Builders
		/// <summary>
		/// Regirock Builder waiting for a Nickname & a Level
		/// </summary>
		public Regirock(string nickname, int level)
		: base(
				377,
				SpecieRegirock.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regirock Builder only waiting for a Level
		/// </summary>
		public Regirock(int level)
		: base(
				377,
				SpecieRegirock.Instance, // Pokemon Specie
				"Regirock", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regirock Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Regirock() : base(
			377,
			SpecieRegirock.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}