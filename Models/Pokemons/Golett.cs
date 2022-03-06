using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Golett Specie to store common natural stats of all Goletts
	#region SpecieGolett
	public class SpecieGolett : PokemonSpecie
	{
#nullable enable
		private static SpecieGolett? _instance = null;
#nullable restore
        public static SpecieGolett Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGolett();
                }
                return _instance;
            }
        }

		#region SpecieGolett Builder
		public SpecieGolett() : base(
			"Golett",
			59, // HPs
			74, 50, // Attack & Defense
			35, 50, // Special Attack & Defense
			35		
		)
		{
			this._height = 10;
			this._weight = 920;
		}
		#endregion
	}
	#endregion

	//Golett Pokemon Class
	#region Golett
	public class Golett : Pokemon
	{
		#region Golett Builders
		/// <summary>
		/// Golett Builder waiting for a Nickname & a Level
		/// </summary>
		public Golett(string nickname, int level)
		: base(
				622,
				SpecieGolett.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golett Builder only waiting for a Level
		/// </summary>
		public Golett(int level)
		: base(
				622,
				SpecieGolett.Instance, // Pokemon Specie
				"Golett", level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golett Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Golett() : base(
			622,
			SpecieGolett.Instance, // Pokemon Specie
			Ground.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}