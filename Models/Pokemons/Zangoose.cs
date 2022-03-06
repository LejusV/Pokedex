using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Zangoose Specie to store common natural stats of all Zangooses
	#region SpecieZangoose
	public class SpecieZangoose : PokemonSpecie
	{
#nullable enable
		private static SpecieZangoose? _instance = null;
#nullable restore
        public static SpecieZangoose Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZangoose();
                }
                return _instance;
            }
        }

		#region SpecieZangoose Builder
		public SpecieZangoose() : base(
			"Zangoose",
			1.3,
			40.3,
			73, // HPs
			115, 60, // Attack & Defense
			60, 60, // Special Attack & Defense
			90		
		)
		{}
		#endregion
	}
	#endregion

	//Zangoose Pokemon Class
	#region Zangoose
	public class Zangoose : Pokemon
	{
		#region Zangoose Builders
		/// <summary>
		/// Zangoose Builder waiting for a Nickname & a Level
		/// </summary>
		public Zangoose(string nickname, int level)
		: base(
				335,
				SpecieZangoose.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zangoose Builder only waiting for a Level
		/// </summary>
		public Zangoose(int level)
		: base(
				335,
				SpecieZangoose.Instance, // Pokemon Specie
				"Zangoose", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zangoose Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Zangoose() : base(
			335,
			SpecieZangoose.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}