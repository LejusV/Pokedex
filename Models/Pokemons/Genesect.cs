using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Genesect Specie to store common natural stats of all Genesects
	#region SpecieGenesect
	public class SpecieGenesect : PokemonSpecie
	{
#nullable enable
		private static SpecieGenesect? _instance = null;
#nullable restore
        public static SpecieGenesect Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGenesect();
                }
                return _instance;
            }
        }

		#region SpecieGenesect Builder
		public SpecieGenesect() : base(
			"Genesect",
			1.5,
			82.5,
			71, // HPs
			120, 95, // Attack & Defense
			120, 95, // Special Attack & Defense
			99		
		)
		{}
		#endregion
	}
	#endregion

	//Genesect Pokemon Class
	#region Genesect
	public class Genesect : Pokemon
	{
		#region Genesect Builders
		/// <summary>
		/// Genesect Builder waiting for a Nickname & a Level
		/// </summary>
		public Genesect(string nickname, int level)
		: base(
				649,
				SpecieGenesect.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Genesect Builder only waiting for a Level
		/// </summary>
		public Genesect(int level)
		: base(
				649,
				SpecieGenesect.Instance, // Pokemon Specie
				"Genesect", level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Genesect Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Genesect() : base(
			649,
			SpecieGenesect.Instance, // Pokemon Specie
			Bug.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}