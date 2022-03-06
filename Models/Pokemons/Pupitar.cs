using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pupitar Specie to store common natural stats of all Pupitars
	#region SpeciePupitar
	public class SpeciePupitar : PokemonSpecie
	{
#nullable enable
		private static SpeciePupitar? _instance = null;
#nullable restore
        public static SpeciePupitar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePupitar();
                }
                return _instance;
            }
        }

		#region SpeciePupitar Builder
		public SpeciePupitar() : base(
			"Pupitar",
			1.2,
			152.0,
			70, // HPs
			84, 70, // Attack & Defense
			65, 70, // Special Attack & Defense
			51		
		)
		{}
		#endregion
	}
	#endregion

	//Pupitar Pokemon Class
	#region Pupitar
	public class Pupitar : Pokemon
	{
		#region Pupitar Builders
		/// <summary>
		/// Pupitar Builder waiting for a Nickname & a Level
		/// </summary>
		public Pupitar(string nickname, int level)
		: base(
				247,
				SpeciePupitar.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pupitar Builder only waiting for a Level
		/// </summary>
		public Pupitar(int level)
		: base(
				247,
				SpeciePupitar.Instance, // Pokemon Specie
				"Pupitar", level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pupitar Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pupitar() : base(
			247,
			SpeciePupitar.Instance, // Pokemon Specie
			Rock.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}