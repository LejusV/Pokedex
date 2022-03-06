using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Wishiwashi-Solo Specie to store common natural stats of all Wishiwashi-Solos
	#region SpecieWishiwashi-Solo
	public class SpecieWishiwashiSolo : PokemonSpecie
	{
#nullable enable
		private static SpecieWishiwashiSolo? _instance = null;
#nullable restore
        public static SpecieWishiwashiSolo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWishiwashiSolo();
                }
                return _instance;
            }
        }

		#region SpecieWishiwashi-Solo Builder
		public SpecieWishiwashiSolo() : base(
			"Wishiwashi-Solo",
			45, // HPs
			20, 20, // Attack & Defense
			25, 25, // Special Attack & Defense
			40		
		)
		{
			this._height = 2;
			this._weight = 3;
		}
		#endregion
	}
	#endregion

	//Wishiwashi-Solo Pokemon Class
	#region Wishiwashi-Solo
	public class WishiwashiSolo : Pokemon
	{
		#region Wishiwashi-Solo Builders
		/// <summary>
		/// Wishiwashi-Solo Builder waiting for a Nickname & a Level
		/// </summary>
		public WishiwashiSolo(string nickname, int level)
		: base(
				746,
				SpecieWishiwashiSolo.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wishiwashi-Solo Builder only waiting for a Level
		/// </summary>
		public WishiwashiSolo(int level)
		: base(
				746,
				SpecieWishiwashiSolo.Instance, // Pokemon Specie
				"Wishiwashi-Solo", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wishiwashi-Solo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public WishiwashiSolo() : base(
			746,
			SpecieWishiwashiSolo.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}