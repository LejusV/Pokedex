using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Lombre Specie to store common natural stats of all Lombres
	#region SpecieLombre
	public class SpecieLombre : PokemonSpecie
	{
#nullable enable
		private static SpecieLombre? _instance = null;
#nullable restore
        public static SpecieLombre Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLombre();
                }
                return _instance;
            }
        }

		#region SpecieLombre Builder
		public SpecieLombre() : base(
			"Lombre",
			60, // HPs
			50, 50, // Attack & Defense
			60, 70, // Special Attack & Defense
			50		
		)
		{
			this._height = 12;
			this._weight = 325;
		}
		#endregion
	}
	#endregion

	//Lombre Pokemon Class
	#region Lombre
	public class Lombre : Pokemon
	{
		#region Lombre Builders
		/// <summary>
		/// Lombre Builder waiting for a Nickname & a Level
		/// </summary>
		public Lombre(string nickname, int level)
		: base(
				271,
				SpecieLombre.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lombre Builder only waiting for a Level
		/// </summary>
		public Lombre(int level)
		: base(
				271,
				SpecieLombre.Instance, // Pokemon Specie
				"Lombre", level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lombre Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Lombre() : base(
			271,
			SpecieLombre.Instance, // Pokemon Specie
			Water.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}