using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Flygon Specie to store common natural stats of all Flygons
	#region SpecieFlygon
	public class SpecieFlygon : PokemonSpecie
	{
#nullable enable
		private static SpecieFlygon? _instance = null;
#nullable restore
        public static SpecieFlygon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFlygon();
                }
                return _instance;
            }
        }

		#region SpecieFlygon Builder
		public SpecieFlygon() : base(
			"Flygon",
			80, // HPs
			100, 80, // Attack & Defense
			80, 80, // Special Attack & Defense
			100		
		)
		{
			this._height = 20;
			this._weight = 820;
		}
		#endregion
	}
	#endregion

	//Flygon Pokemon Class
	#region Flygon
	public class Flygon : Pokemon
	{
		#region Flygon Builders
		/// <summary>
		/// Flygon Builder waiting for a Nickname & a Level
		/// </summary>
		public Flygon(string nickname, int level)
		: base(
				330,
				SpecieFlygon.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flygon Builder only waiting for a Level
		/// </summary>
		public Flygon(int level)
		: base(
				330,
				SpecieFlygon.Instance, // Pokemon Specie
				"Flygon", level,
				Ground.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flygon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Flygon() : base(
			330,
			SpecieFlygon.Instance, // Pokemon Specie
			Ground.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}