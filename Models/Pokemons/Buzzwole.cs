using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Buzzwole Specie to store common natural stats of all Buzzwoles
	#region SpecieBuzzwole
	public class SpecieBuzzwole : PokemonSpecie
	{
#nullable enable
		private static SpecieBuzzwole? _instance = null;
#nullable restore
        public static SpecieBuzzwole Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBuzzwole();
                }
                return _instance;
            }
        }

		#region SpecieBuzzwole Builder
		public SpecieBuzzwole() : base(
			"Buzzwole",
			107, // HPs
			139, 139, // Attack & Defense
			53, 53, // Special Attack & Defense
			79		
		)
		{
			this._height = 24;
			this._weight = 3336;
		}
		#endregion
	}
	#endregion

	//Buzzwole Pokemon Class
	#region Buzzwole
	public class Buzzwole : Pokemon
	{
		#region Buzzwole Builders
		/// <summary>
		/// Buzzwole Builder waiting for a Nickname & a Level
		/// </summary>
		public Buzzwole(string nickname, int level)
		: base(
				794,
				SpecieBuzzwole.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buzzwole Builder only waiting for a Level
		/// </summary>
		public Buzzwole(int level)
		: base(
				794,
				SpecieBuzzwole.Instance, // Pokemon Specie
				"Buzzwole", level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buzzwole Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Buzzwole() : base(
			794,
			SpecieBuzzwole.Instance, // Pokemon Specie
			Bug.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}