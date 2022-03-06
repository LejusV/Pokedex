using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Arcanine Specie to store common natural stats of all Arcanines
	#region SpecieArcanine
	public class SpecieArcanine : PokemonSpecie
	{
#nullable enable
		private static SpecieArcanine? _instance = null;
#nullable restore
        public static SpecieArcanine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArcanine();
                }
                return _instance;
            }
        }

		#region SpecieArcanine Builder
		public SpecieArcanine() : base(
			"Arcanine",
			90, // HPs
			110, 80, // Attack & Defense
			100, 80, // Special Attack & Defense
			95		
		)
		{
			this._height = 19;
			this._weight = 1550;
		}
		#endregion
	}
	#endregion

	//Arcanine Pokemon Class
	#region Arcanine
	public class Arcanine : Pokemon
	{
		#region Arcanine Builders
		/// <summary>
		/// Arcanine Builder waiting for a Nickname & a Level
		/// </summary>
		public Arcanine(string nickname, int level)
		: base(
				59,
				SpecieArcanine.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arcanine Builder only waiting for a Level
		/// </summary>
		public Arcanine(int level)
		: base(
				59,
				SpecieArcanine.Instance, // Pokemon Specie
				"Arcanine", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arcanine Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Arcanine() : base(
			59,
			SpecieArcanine.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}