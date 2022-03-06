using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dedenne Specie to store common natural stats of all Dedennes
	#region SpecieDedenne
	public class SpecieDedenne : PokemonSpecie
	{
#nullable enable
		private static SpecieDedenne? _instance = null;
#nullable restore
        public static SpecieDedenne Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDedenne();
                }
                return _instance;
            }
        }

		#region SpecieDedenne Builder
		public SpecieDedenne() : base(
			"Dedenne",
			67, // HPs
			58, 57, // Attack & Defense
			81, 67, // Special Attack & Defense
			101		
		)
		{
			this._height = 2;
			this._weight = 22;
		}
		#endregion
	}
	#endregion

	//Dedenne Pokemon Class
	#region Dedenne
	public class Dedenne : Pokemon
	{
		#region Dedenne Builders
		/// <summary>
		/// Dedenne Builder waiting for a Nickname & a Level
		/// </summary>
		public Dedenne(string nickname, int level)
		: base(
				702,
				SpecieDedenne.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dedenne Builder only waiting for a Level
		/// </summary>
		public Dedenne(int level)
		: base(
				702,
				SpecieDedenne.Instance, // Pokemon Specie
				"Dedenne", level,
				Electric.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dedenne Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dedenne() : base(
			702,
			SpecieDedenne.Instance, // Pokemon Specie
			Electric.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}