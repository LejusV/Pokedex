using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mime-Jr Specie to store common natural stats of all Mime-Jrs
	#region SpecieMime-Jr
	public class SpecieMimeJr : PokemonSpecie
	{
#nullable enable
		private static SpecieMimeJr? _instance = null;
#nullable restore
        public static SpecieMimeJr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMimeJr();
                }
                return _instance;
            }
        }

		#region SpecieMime-Jr Builder
		public SpecieMimeJr() : base(
			"Mime-Jr",
			0.6,
			13.0,
			20, // HPs
			25, 45, // Attack & Defense
			70, 90, // Special Attack & Defense
			60		
		)
		{}
		#endregion
	}
	#endregion

	//Mime-Jr Pokemon Class
	#region Mime-Jr
	public class MimeJr : Pokemon
	{
		#region Mime-Jr Builders
		/// <summary>
		/// Mime-Jr Builder waiting for a Nickname & a Level
		/// </summary>
		public MimeJr(string nickname, int level)
		: base(
				439,
				SpecieMimeJr.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mime-Jr Builder only waiting for a Level
		/// </summary>
		public MimeJr(int level)
		: base(
				439,
				SpecieMimeJr.Instance, // Pokemon Specie
				"Mime-Jr", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mime-Jr Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public MimeJr() : base(
			439,
			SpecieMimeJr.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}