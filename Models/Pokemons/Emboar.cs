using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Emboar Specie to store common natural stats of all Emboars
	#region SpecieEmboar
	public class SpecieEmboar : PokemonSpecie
	{
#nullable enable
		private static SpecieEmboar? _instance = null;
#nullable restore
        public static SpecieEmboar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEmboar();
                }
                return _instance;
            }
        }

		#region SpecieEmboar Builder
		public SpecieEmboar() : base(
			"Emboar",
			110, // HPs
			123, 65, // Attack & Defense
			100, 65, // Special Attack & Defense
			65		
		)
		{
			this._height = 16;
			this._weight = 1500;
		}
		#endregion
	}
	#endregion

	//Emboar Pokemon Class
	#region Emboar
	public class Emboar : Pokemon
	{
		#region Emboar Builders
		/// <summary>
		/// Emboar Builder waiting for a Nickname & a Level
		/// </summary>
		public Emboar(string nickname, int level)
		: base(
				500,
				SpecieEmboar.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Emboar Builder only waiting for a Level
		/// </summary>
		public Emboar(int level)
		: base(
				500,
				SpecieEmboar.Instance, // Pokemon Specie
				"Emboar", level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Emboar Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Emboar() : base(
			500,
			SpecieEmboar.Instance, // Pokemon Specie
			Fire.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}