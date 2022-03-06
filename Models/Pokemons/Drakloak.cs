using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Drakloak Specie to store common natural stats of all Drakloaks
	#region SpecieDrakloak
	public class SpecieDrakloak : PokemonSpecie
	{
#nullable enable
		private static SpecieDrakloak? _instance = null;
#nullable restore
        public static SpecieDrakloak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrakloak();
                }
                return _instance;
            }
        }

		#region SpecieDrakloak Builder
		public SpecieDrakloak() : base(
			"Drakloak",
			1.4,
			11.0,
			68, // HPs
			80, 50, // Attack & Defense
			60, 50, // Special Attack & Defense
			102		
		)
		{}
		#endregion
	}
	#endregion

	//Drakloak Pokemon Class
	#region Drakloak
	public class Drakloak : Pokemon
	{
		#region Drakloak Builders
		/// <summary>
		/// Drakloak Builder waiting for a Nickname & a Level
		/// </summary>
		public Drakloak(string nickname, int level)
		: base(
				886,
				SpecieDrakloak.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drakloak Builder only waiting for a Level
		/// </summary>
		public Drakloak(int level)
		: base(
				886,
				SpecieDrakloak.Instance, // Pokemon Specie
				"Drakloak", level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drakloak Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Drakloak() : base(
			886,
			SpecieDrakloak.Instance, // Pokemon Specie
			Dragon.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}