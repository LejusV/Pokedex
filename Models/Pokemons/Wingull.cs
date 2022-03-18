using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Wingull Species to store common natural stats of all Wingulls
	#region SpeciesWingull
	public class SpeciesWingull : PokemonSpecies
	{
#nullable enable
		private static SpeciesWingull? _instance = null;
#nullable restore
        public static SpeciesWingull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWingull();
                }
                return _instance;
            }
        }

		#region SpeciesWingull Constructor
		public SpeciesWingull() : base(
			278,
			"Wingull",
			0.6,
			9.5,
			40, // HPs
			30, 30, // Attack & Defense
			55, 30, // Special Attack & Defense
			85		
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
				"Gust",
				"Wing-Attack",
				"Fly",
				"Double-Edge",
				"Growl",
				"Supersonic",
				"Mist",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Uproar",
				"Hail",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Air-Cutter",
				"Aerial-Ace",
				"Water-Sport",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Brine",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Aqua-Ring",
				"Air-Slash",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Wide-Guard",
				"Soak",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Wingull PokemonInstance Class
	#region Wingull
	public class WingullInstance : PokemonInstance
	{
		#region Wingull Constructors
		/// <summary>
		/// Wingull Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WingullInstance(string nickname, int level)
		: base(
				SpeciesWingull.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wingull Builder only waiting for a Level
		/// </summary>
		public WingullInstance(int level)
		: base(
				SpeciesWingull.Instance, // PokemonInstance Species
				"Wingull", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wingull Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public WingullInstance() : base(
			SpeciesWingull.Instance, // PokemonInstance Species
			Water.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}