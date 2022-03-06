using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Lurantis Specie to store common natural stats of all Lurantiss
	#region SpecieLurantis
	public class SpecieLurantis : PokemonSpecie
	{
#nullable enable
		private static SpecieLurantis? _instance = null;
#nullable restore
        public static SpecieLurantis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLurantis();
                }
                return _instance;
            }
        }

		#region SpecieLurantis Builder
		public SpecieLurantis() : base(
			"Lurantis",
			0.9,
			18.5,
			70, // HPs
			105, 90, // Attack & Defense
			80, 90, // Special Attack & Defense
			45		
		)
		{}
		#endregion
	}
	#endregion

	//Lurantis Pokemon Class
	#region Lurantis
	public class Lurantis : Pokemon
	{
		#region Lurantis Builders
		/// <summary>
		/// Lurantis Builder waiting for a Nickname & a Level
		/// </summary>
		public Lurantis(string nickname, int level)
		: base(
				754,
				SpecieLurantis.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lurantis Builder only waiting for a Level
		/// </summary>
		public Lurantis(int level)
		: base(
				754,
				SpecieLurantis.Instance, // Pokemon Specie
				"Lurantis", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lurantis Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Lurantis() : base(
			754,
			SpecieLurantis.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}