using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dottler Specie to store common natural stats of all Dottlers
	#region SpecieDottler
	public class SpecieDottler : PokemonSpecie
	{
#nullable enable
		private static SpecieDottler? _instance = null;
#nullable restore
        public static SpecieDottler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDottler();
                }
                return _instance;
            }
        }

		#region SpecieDottler Builder
		public SpecieDottler() : base(
			"Dottler",
			0.4,
			19.5,
			50, // HPs
			35, 80, // Attack & Defense
			50, 90, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Dottler Pokemon Class
	#region Dottler
	public class Dottler : Pokemon
	{
		#region Dottler Builders
		/// <summary>
		/// Dottler Builder waiting for a Nickname & a Level
		/// </summary>
		public Dottler(string nickname, int level)
		: base(
				825,
				SpecieDottler.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dottler Builder only waiting for a Level
		/// </summary>
		public Dottler(int level)
		: base(
				825,
				SpecieDottler.Instance, // Pokemon Specie
				"Dottler", level,
				Bug.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dottler Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dottler() : base(
			825,
			SpecieDottler.Instance, // Pokemon Specie
			Bug.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}