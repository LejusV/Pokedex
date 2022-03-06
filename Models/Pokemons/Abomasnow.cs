using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Abomasnow Specie to store common natural stats of all Abomasnows
	#region SpecieAbomasnow
	public class SpecieAbomasnow : PokemonSpecie
	{
#nullable enable
		private static SpecieAbomasnow? _instance = null;
#nullable restore
        public static SpecieAbomasnow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAbomasnow();
                }
                return _instance;
            }
        }

		#region SpecieAbomasnow Builder
		public SpecieAbomasnow() : base(
			"Abomasnow",
			2.2,
			135.5,
			90, // HPs
			92, 75, // Attack & Defense
			92, 85, // Special Attack & Defense
			60		
		)
		{}
		#endregion
	}
	#endregion

	//Abomasnow Pokemon Class
	#region Abomasnow
	public class Abomasnow : Pokemon
	{
		#region Abomasnow Builders
		/// <summary>
		/// Abomasnow Builder waiting for a Nickname & a Level
		/// </summary>
		public Abomasnow(string nickname, int level)
		: base(
				460,
				SpecieAbomasnow.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Abomasnow Builder only waiting for a Level
		/// </summary>
		public Abomasnow(int level)
		: base(
				460,
				SpecieAbomasnow.Instance, // Pokemon Specie
				"Abomasnow", level,
				Grass.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Abomasnow Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Abomasnow() : base(
			460,
			SpecieAbomasnow.Instance, // Pokemon Specie
			Grass.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}