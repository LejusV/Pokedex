using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Bonsly Specie to store common natural stats of all Bonslys
	#region SpecieBonsly
	public class SpecieBonsly : PokemonSpecie
	{
#nullable enable
		private static SpecieBonsly? _instance = null;
#nullable restore
        public static SpecieBonsly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBonsly();
                }
                return _instance;
            }
        }

		#region SpecieBonsly Builder
		public SpecieBonsly() : base(
			"Bonsly",
			50, // HPs
			80, 95, // Attack & Defense
			10, 45, // Special Attack & Defense
			10		
		)
		{
			this._height = 5;
			this._weight = 150;
		}
		#endregion
	}
	#endregion

	//Bonsly Pokemon Class
	#region Bonsly
	public class Bonsly : Pokemon
	{
		#region Bonsly Builders
		/// <summary>
		/// Bonsly Builder waiting for a Nickname & a Level
		/// </summary>
		public Bonsly(string nickname, int level)
		: base(
				438,
				SpecieBonsly.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bonsly Builder only waiting for a Level
		/// </summary>
		public Bonsly(int level)
		: base(
				438,
				SpecieBonsly.Instance, // Pokemon Specie
				"Bonsly", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bonsly Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Bonsly() : base(
			438,
			SpecieBonsly.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}