using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Wishiwashi-Solo Species to store common natural stats of all Wishiwashi-Solos
	#region SpeciesWishiwashi-Solo
	public class SpeciesWishiwashiSolo : PokemonSpecies
	{
#nullable enable
		private static SpeciesWishiwashiSolo? _instance = null;
#nullable restore
        public static SpeciesWishiwashiSolo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWishiwashiSolo();
                }
                return _instance;
            }
        }

		#region SpeciesWishiwashi-Solo Constructor
		public SpeciesWishiwashiSolo() : base(
			"Wishiwashi-Solo",
			0.2,
			0.3,
			45, // HPs
			20, 20, // Attack & Defense
			25, 25, // Special Attack & Defense
			40		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Rest",
				"Substitute",
				"Protect",
				"Feint-Attack",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Beat-Up",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Endeavor",
				"Dive",
				"Muddy-Water",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"U-Turn",
				"Aqua-Ring",
				"Aqua-Tail",
				"Soak",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion

	//Wishiwashi-Solo PokemonInstance Class
	#region Wishiwashi-Solo
	public class WishiwashiSoloInstance : PokemonInstance
	{
		#region Wishiwashi-Solo Constructors
		/// <summary>
		/// Wishiwashi-Solo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WishiwashiSoloInstance(string nickname, int level)
		: base(
				746,
				SpeciesWishiwashiSolo.Instance, // Pokemon Species
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
		public WishiwashiSoloInstance(int level)
		: base(
				746,
				SpeciesWishiwashiSolo.Instance, // PokemonInstance Species
				"Wishiwashi-Solo", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wishiwashi-Solo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public WishiwashiSolo() : base(
			746,
			SpeciesWishiwashiSolo.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}