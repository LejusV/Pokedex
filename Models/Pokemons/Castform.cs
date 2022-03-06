using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Castform Specie to store common natural stats of all Castforms
	#region SpecieCastform
	public class SpecieCastform : PokemonSpecie
	{
#nullable enable
		private static SpecieCastform? _instance = null;
#nullable restore
        public static SpecieCastform Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCastform();
                }
                return _instance;
            }
        }

		#region SpecieCastform Builder
		public SpecieCastform() : base(
			"Castform",
			0.3,
			0.8,
			70, // HPs
			70, 70, // Attack & Defense
			70, 70, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Castform Pokemon Class
	#region Castform
	public class Castform : Pokemon
	{
		#region Castform Builders
		/// <summary>
		/// Castform Builder waiting for a Nickname & a Level
		/// </summary>
		public Castform(string nickname, int level)
		: base(
				351,
				SpecieCastform.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Castform Builder only waiting for a Level
		/// </summary>
		public Castform(int level)
		: base(
				351,
				SpecieCastform.Instance, // Pokemon Specie
				"Castform", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Castform Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Castform() : base(
			351,
			SpecieCastform.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}