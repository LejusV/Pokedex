using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Alakazam Specie to store common natural stats of all Alakazams
	#region SpecieAlakazam
	public class SpecieAlakazam : PokemonSpecie
	{
#nullable enable
		private static SpecieAlakazam? _instance = null;
#nullable restore
        public static SpecieAlakazam Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAlakazam();
                }
                return _instance;
            }
        }

		#region SpecieAlakazam Builder
		public SpecieAlakazam() : base(
			"Alakazam",
			1.5,
			48.0,
			55, // HPs
			50, 45, // Attack & Defense
			135, 95, // Special Attack & Defense
			120		
		)
		{}
		#endregion
	}
	#endregion

	//Alakazam Pokemon Class
	#region Alakazam
	public class Alakazam : Pokemon
	{
		#region Alakazam Builders
		/// <summary>
		/// Alakazam Builder waiting for a Nickname & a Level
		/// </summary>
		public Alakazam(string nickname, int level)
		: base(
				65,
				SpecieAlakazam.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alakazam Builder only waiting for a Level
		/// </summary>
		public Alakazam(int level)
		: base(
				65,
				SpecieAlakazam.Instance, // Pokemon Specie
				"Alakazam", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alakazam Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Alakazam() : base(
			65,
			SpecieAlakazam.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}