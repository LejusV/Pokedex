using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Butterfree Specie to store common natural stats of all Butterfrees
	#region SpecieButterfree
	public class SpecieButterfree : PokemonSpecie
	{
#nullable enable
		private static SpecieButterfree? _instance = null;
#nullable restore
        public static SpecieButterfree Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieButterfree();
                }
                return _instance;
            }
        }

		#region SpecieButterfree Builder
		public SpecieButterfree() : base(
			"Butterfree",
			60, // HPs
			45, 50, // Attack & Defense
			90, 80, // Special Attack & Defense
			70		
		)
		{
			this._height = 11;
			this._weight = 320;
		}
		#endregion
	}
	#endregion

	//Butterfree Pokemon Class
	#region Butterfree
	public class Butterfree : Pokemon
	{
		#region Butterfree Builders
		/// <summary>
		/// Butterfree Builder waiting for a Nickname & a Level
		/// </summary>
		public Butterfree(string nickname, int level)
		: base(
				12,
				SpecieButterfree.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Butterfree Builder only waiting for a Level
		/// </summary>
		public Butterfree(int level)
		: base(
				12,
				SpecieButterfree.Instance, // Pokemon Specie
				"Butterfree", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Butterfree Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Butterfree() : base(
			12,
			SpecieButterfree.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}