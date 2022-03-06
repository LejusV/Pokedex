using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Hoppip Specie to store common natural stats of all Hoppips
	#region SpecieHoppip
	public class SpecieHoppip : PokemonSpecie
	{
#nullable enable
		private static SpecieHoppip? _instance = null;
#nullable restore
        public static SpecieHoppip Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHoppip();
                }
                return _instance;
            }
        }

		#region SpecieHoppip Builder
		public SpecieHoppip() : base(
			"Hoppip",
			35, // HPs
			35, 40, // Attack & Defense
			35, 55, // Special Attack & Defense
			50		
		)
		{
			this._height = 4;
			this._weight = 5;
		}
		#endregion
	}
	#endregion

	//Hoppip Pokemon Class
	#region Hoppip
	public class Hoppip : Pokemon
	{
		#region Hoppip Builders
		/// <summary>
		/// Hoppip Builder waiting for a Nickname & a Level
		/// </summary>
		public Hoppip(string nickname, int level)
		: base(
				187,
				SpecieHoppip.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoppip Builder only waiting for a Level
		/// </summary>
		public Hoppip(int level)
		: base(
				187,
				SpecieHoppip.Instance, // Pokemon Specie
				"Hoppip", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoppip Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Hoppip() : base(
			187,
			SpecieHoppip.Instance, // Pokemon Specie
			Grass.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}