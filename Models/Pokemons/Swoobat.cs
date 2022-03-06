using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Swoobat Specie to store common natural stats of all Swoobats
	#region SpecieSwoobat
	public class SpecieSwoobat : PokemonSpecie
	{
#nullable enable
		private static SpecieSwoobat? _instance = null;
#nullable restore
        public static SpecieSwoobat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwoobat();
                }
                return _instance;
            }
        }

		#region SpecieSwoobat Builder
		public SpecieSwoobat() : base(
			"Swoobat",
			67, // HPs
			57, 55, // Attack & Defense
			77, 55, // Special Attack & Defense
			114		
		)
		{
			this._height = 9;
			this._weight = 105;
		}
		#endregion
	}
	#endregion

	//Swoobat Pokemon Class
	#region Swoobat
	public class Swoobat : Pokemon
	{
		#region Swoobat Builders
		/// <summary>
		/// Swoobat Builder waiting for a Nickname & a Level
		/// </summary>
		public Swoobat(string nickname, int level)
		: base(
				528,
				SpecieSwoobat.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swoobat Builder only waiting for a Level
		/// </summary>
		public Swoobat(int level)
		: base(
				528,
				SpecieSwoobat.Instance, // Pokemon Specie
				"Swoobat", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swoobat Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Swoobat() : base(
			528,
			SpecieSwoobat.Instance, // Pokemon Specie
			Psychic.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}