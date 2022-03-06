using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Torracat Specie to store common natural stats of all Torracats
	#region SpecieTorracat
	public class SpecieTorracat : PokemonSpecie
	{
#nullable enable
		private static SpecieTorracat? _instance = null;
#nullable restore
        public static SpecieTorracat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTorracat();
                }
                return _instance;
            }
        }

		#region SpecieTorracat Builder
		public SpecieTorracat() : base(
			"Torracat",
			0.7,
			25.0,
			65, // HPs
			85, 50, // Attack & Defense
			80, 50, // Special Attack & Defense
			90		
		)
		{}
		#endregion
	}
	#endregion

	//Torracat Pokemon Class
	#region Torracat
	public class Torracat : Pokemon
	{
		#region Torracat Builders
		/// <summary>
		/// Torracat Builder waiting for a Nickname & a Level
		/// </summary>
		public Torracat(string nickname, int level)
		: base(
				726,
				SpecieTorracat.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torracat Builder only waiting for a Level
		/// </summary>
		public Torracat(int level)
		: base(
				726,
				SpecieTorracat.Instance, // Pokemon Specie
				"Torracat", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torracat Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Torracat() : base(
			726,
			SpecieTorracat.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}