using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Fomantis Specie to store common natural stats of all Fomantiss
	#region SpecieFomantis
	public class SpecieFomantis : PokemonSpecie
	{
#nullable enable
		private static SpecieFomantis? _instance = null;
#nullable restore
        public static SpecieFomantis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFomantis();
                }
                return _instance;
            }
        }

		#region SpecieFomantis Builder
		public SpecieFomantis() : base(
			"Fomantis",
			0.3,
			1.5,
			40, // HPs
			55, 35, // Attack & Defense
			50, 35, // Special Attack & Defense
			35		
		)
		{}
		#endregion
	}
	#endregion

	//Fomantis Pokemon Class
	#region Fomantis
	public class Fomantis : Pokemon
	{
		#region Fomantis Builders
		/// <summary>
		/// Fomantis Builder waiting for a Nickname & a Level
		/// </summary>
		public Fomantis(string nickname, int level)
		: base(
				753,
				SpecieFomantis.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fomantis Builder only waiting for a Level
		/// </summary>
		public Fomantis(int level)
		: base(
				753,
				SpecieFomantis.Instance, // Pokemon Specie
				"Fomantis", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fomantis Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Fomantis() : base(
			753,
			SpecieFomantis.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}