using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cranidos Specie to store common natural stats of all Cranidoss
	#region SpecieCranidos
	public class SpecieCranidos : PokemonSpecie
	{
#nullable enable
		private static SpecieCranidos? _instance = null;
#nullable restore
        public static SpecieCranidos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCranidos();
                }
                return _instance;
            }
        }

		#region SpecieCranidos Builder
		public SpecieCranidos() : base(
			"Cranidos",
			0.9,
			31.5,
			67, // HPs
			125, 40, // Attack & Defense
			30, 30, // Special Attack & Defense
			58		
		)
		{}
		#endregion
	}
	#endregion

	//Cranidos Pokemon Class
	#region Cranidos
	public class Cranidos : Pokemon
	{
		#region Cranidos Builders
		/// <summary>
		/// Cranidos Builder waiting for a Nickname & a Level
		/// </summary>
		public Cranidos(string nickname, int level)
		: base(
				408,
				SpecieCranidos.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cranidos Builder only waiting for a Level
		/// </summary>
		public Cranidos(int level)
		: base(
				408,
				SpecieCranidos.Instance, // Pokemon Specie
				"Cranidos", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cranidos Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cranidos() : base(
			408,
			SpecieCranidos.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}