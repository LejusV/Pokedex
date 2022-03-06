using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sylveon Specie to store common natural stats of all Sylveons
	#region SpecieSylveon
	public class SpecieSylveon : PokemonSpecie
	{
#nullable enable
		private static SpecieSylveon? _instance = null;
#nullable restore
        public static SpecieSylveon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSylveon();
                }
                return _instance;
            }
        }

		#region SpecieSylveon Builder
		public SpecieSylveon() : base(
			"Sylveon",
			95, // HPs
			65, 65, // Attack & Defense
			110, 130, // Special Attack & Defense
			60		
		)
		{
			this._height = 10;
			this._weight = 235;
		}
		#endregion
	}
	#endregion

	//Sylveon Pokemon Class
	#region Sylveon
	public class Sylveon : Pokemon
	{
		#region Sylveon Builders
		/// <summary>
		/// Sylveon Builder waiting for a Nickname & a Level
		/// </summary>
		public Sylveon(string nickname, int level)
		: base(
				700,
				SpecieSylveon.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sylveon Builder only waiting for a Level
		/// </summary>
		public Sylveon(int level)
		: base(
				700,
				SpecieSylveon.Instance, // Pokemon Specie
				"Sylveon", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sylveon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sylveon() : base(
			700,
			SpecieSylveon.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}