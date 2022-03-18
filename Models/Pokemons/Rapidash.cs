using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rapidash Species to store common natural stats of all Rapidashs
	#region SpeciesRapidash
	public class SpeciesRapidash : PokemonSpecies
	{
#nullable enable
		private static SpeciesRapidash? _instance = null;
#nullable restore
        public static SpeciesRapidash Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRapidash();
                }
                return _instance;
            }
        }

		#region SpeciesRapidash Constructor
		public SpeciesRapidash() : base(
			78,
			"Rapidash",
			1.7,
			95.0,
			65, // HPs
			100, 70, // Attack & Defense
			80, 80, // Special Attack & Defense
			105		
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
				"Stomp",
				"Headbutt",
				"Fury-Attack",
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Protect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Secret-Power",
				"Overheat",
				"Bounce",
				"Natural-Gift",
				"Flare-Blitz",
				"Poison-Jab",
				"Giga-Impact",
				"Captivate",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Inferno",
				"Wild-Charge",
				"Drill-Run",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Rapidash PokemonInstance Class
	#region Rapidash
	public class RapidashInstance : PokemonInstance
	{
		#region Rapidash Constructors
		/// <summary>
		/// Rapidash Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RapidashInstance(string nickname, int level)
		: base(
				SpeciesRapidash.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rapidash Builder only waiting for a Level
		/// </summary>
		public RapidashInstance(int level)
		: base(
				SpeciesRapidash.Instance, // PokemonInstance Species
				"Rapidash", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rapidash Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RapidashInstance() : base(
			SpeciesRapidash.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}