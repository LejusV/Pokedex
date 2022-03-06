using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Marill Specie to store common natural stats of all Marills
	#region SpecieMarill
	public class SpecieMarill : PokemonSpecie
	{
#nullable enable
		private static SpecieMarill? _instance = null;
#nullable restore
        public static SpecieMarill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMarill();
                }
                return _instance;
            }
        }

		#region SpecieMarill Builder
		public SpecieMarill() : base(
			"Marill",
			0.4,
			8.5,
			70, // HPs
			20, 50, // Attack & Defense
			20, 50, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Marill Pokemon Class
	#region Marill
	public class Marill : Pokemon
	{
		#region Marill Builders
		/// <summary>
		/// Marill Builder waiting for a Nickname & a Level
		/// </summary>
		public Marill(string nickname, int level)
		: base(
				183,
				SpecieMarill.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marill Builder only waiting for a Level
		/// </summary>
		public Marill(int level)
		: base(
				183,
				SpecieMarill.Instance, // Pokemon Specie
				"Marill", level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marill Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Marill() : base(
			183,
			SpecieMarill.Instance, // Pokemon Specie
			Water.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}