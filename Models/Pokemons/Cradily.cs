using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cradily Specie to store common natural stats of all Cradilys
	#region SpecieCradily
	public class SpecieCradily : PokemonSpecie
	{
#nullable enable
		private static SpecieCradily? _instance = null;
#nullable restore
        public static SpecieCradily Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCradily();
                }
                return _instance;
            }
        }

		#region SpecieCradily Builder
		public SpecieCradily() : base(
			"Cradily",
			1.5,
			60.4,
			86, // HPs
			81, 97, // Attack & Defense
			81, 107, // Special Attack & Defense
			43		
		)
		{}
		#endregion
	}
	#endregion

	//Cradily Pokemon Class
	#region Cradily
	public class Cradily : Pokemon
	{
		#region Cradily Builders
		/// <summary>
		/// Cradily Builder waiting for a Nickname & a Level
		/// </summary>
		public Cradily(string nickname, int level)
		: base(
				346,
				SpecieCradily.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cradily Builder only waiting for a Level
		/// </summary>
		public Cradily(int level)
		: base(
				346,
				SpecieCradily.Instance, // Pokemon Specie
				"Cradily", level,
				Rock.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cradily Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cradily() : base(
			346,
			SpecieCradily.Instance, // Pokemon Specie
			Rock.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}