using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Lucario Specie to store common natural stats of all Lucarios
	#region SpecieLucario
	public class SpecieLucario : PokemonSpecie
	{
#nullable enable
		private static SpecieLucario? _instance = null;
#nullable restore
        public static SpecieLucario Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLucario();
                }
                return _instance;
            }
        }

		#region SpecieLucario Builder
		public SpecieLucario() : base(
			"Lucario",
			70, // HPs
			110, 70, // Attack & Defense
			115, 70, // Special Attack & Defense
			90		
		)
		{
			this._height = 12;
			this._weight = 540;
		}
		#endregion
	}
	#endregion

	//Lucario Pokemon Class
	#region Lucario
	public class Lucario : Pokemon
	{
		#region Lucario Builders
		/// <summary>
		/// Lucario Builder waiting for a Nickname & a Level
		/// </summary>
		public Lucario(string nickname, int level)
		: base(
				448,
				SpecieLucario.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lucario Builder only waiting for a Level
		/// </summary>
		public Lucario(int level)
		: base(
				448,
				SpecieLucario.Instance, // Pokemon Specie
				"Lucario", level,
				Fighting.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lucario Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Lucario() : base(
			448,
			SpecieLucario.Instance, // Pokemon Specie
			Fighting.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}