using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Trumbeak Species to store common natural stats of all Trumbeaks
	#region SpeciesTrumbeak
	public class SpeciesTrumbeak : PokemonSpecies
	{
#nullable enable
		private static SpeciesTrumbeak? _instance = null;
#nullable restore
        public static SpeciesTrumbeak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTrumbeak();
                }
                return _instance;
            }
        }

		#region SpeciesTrumbeak Constructor
		public SpeciesTrumbeak() : base(
			"Trumbeak",
			0.6,
			14.8,
			55, // HPs
			85, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			75		
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
				"Swords-Dance",
				"Fly",
				"Fury-Attack",
				"Growl",
				"Supersonic",
				"Peck",
				"Drill-Peck",
				"Toxic",
				"Screech",
				"Double-Team",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Brick-Break",
				"Feather-Dance",
				"Hyper-Voice",
				"Bullet-Seed",
				"Aerial-Ace",
				"Rock-Blast",
				"Roost",
				"Pluck",
				"U-Turn",
				"Smack-Down",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Trumbeak PokemonInstance Class
	#region Trumbeak
	public class TrumbeakInstance : PokemonInstance
	{
		#region Trumbeak Constructors
		/// <summary>
		/// Trumbeak Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TrumbeakInstance(string nickname, int level)
		: base(
				732,
				SpeciesTrumbeak.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trumbeak Builder only waiting for a Level
		/// </summary>
		public TrumbeakInstance(int level)
		: base(
				732,
				SpeciesTrumbeak.Instance, // PokemonInstance Species
				"Trumbeak", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trumbeak Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Trumbeak() : base(
			732,
			SpeciesTrumbeak.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}