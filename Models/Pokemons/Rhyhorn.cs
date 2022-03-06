using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Rhyhorn Specie to store common natural stats of all Rhyhorns
	#region SpecieRhyhorn
	public class SpecieRhyhorn : PokemonSpecie
	{
#nullable enable
		private static SpecieRhyhorn? _instance = null;
#nullable restore
        public static SpecieRhyhorn Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRhyhorn();
                }
                return _instance;
            }
        }

		#region SpecieRhyhorn Builder
		public SpecieRhyhorn() : base(
			"Rhyhorn",
			1.0,
			115.0,
			80, // HPs
			85, 95, // Attack & Defense
			30, 30, // Special Attack & Defense
			25		
		)
		{}
		#endregion
	}
	#endregion

	//Rhyhorn Pokemon Class
	#region Rhyhorn
	public class Rhyhorn : Pokemon
	{
		#region Rhyhorn Builders
		/// <summary>
		/// Rhyhorn Builder waiting for a Nickname & a Level
		/// </summary>
		public Rhyhorn(string nickname, int level)
		: base(
				111,
				SpecieRhyhorn.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhyhorn Builder only waiting for a Level
		/// </summary>
		public Rhyhorn(int level)
		: base(
				111,
				SpecieRhyhorn.Instance, // Pokemon Specie
				"Rhyhorn", level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhyhorn Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Rhyhorn() : base(
			111,
			SpecieRhyhorn.Instance, // Pokemon Specie
			Ground.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}