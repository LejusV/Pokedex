using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Arctozolt Specie to store common natural stats of all Arctozolts
	#region SpecieArctozolt
	public class SpecieArctozolt : PokemonSpecie
	{
#nullable enable
		private static SpecieArctozolt? _instance = null;
#nullable restore
        public static SpecieArctozolt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArctozolt();
                }
                return _instance;
            }
        }

		#region SpecieArctozolt Builder
		public SpecieArctozolt() : base(
			"Arctozolt",
			2.3,
			150.0,
			90, // HPs
			100, 90, // Attack & Defense
			90, 80, // Special Attack & Defense
			55		
		)
		{}
		#endregion
	}
	#endregion

	//Arctozolt Pokemon Class
	#region Arctozolt
	public class Arctozolt : Pokemon
	{
		#region Arctozolt Builders
		/// <summary>
		/// Arctozolt Builder waiting for a Nickname & a Level
		/// </summary>
		public Arctozolt(string nickname, int level)
		: base(
				881,
				SpecieArctozolt.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arctozolt Builder only waiting for a Level
		/// </summary>
		public Arctozolt(int level)
		: base(
				881,
				SpecieArctozolt.Instance, // Pokemon Specie
				"Arctozolt", level,
				Electric.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arctozolt Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Arctozolt() : base(
			881,
			SpecieArctozolt.Instance, // Pokemon Specie
			Electric.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}