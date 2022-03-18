using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bibarel Species to store common natural stats of all Bibarels
	#region SpeciesBibarel
	public class SpeciesBibarel : PokemonSpecies
	{
#nullable enable
		private static SpeciesBibarel? _instance = null;
#nullable restore
        public static SpeciesBibarel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBibarel();
                }
                return _instance;
            }
        }

		#region SpeciesBibarel Constructor
		public SpeciesBibarel() : base(
			400,
			"Bibarel",
			1.0,
			31.5,
			79, // HPs
			85, 60, // Attack & Defense
			55, 60, // Special Attack & Defense
			71		
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
				"Cut",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Growl",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Waterfall",
				"Swift",
				"Amnesia",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Pluck",
				"Fling",
				"Last-Resort",
				"Aqua-Tail",
				"Giga-Impact",
				"Rock-Climb",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Aqua-Jet",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Rototiller",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Bibarel PokemonInstance Class
	#region Bibarel
	public class BibarelInstance : PokemonInstance
	{
		#region Bibarel Constructors
		/// <summary>
		/// Bibarel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BibarelInstance(string nickname, int level)
		: base(
				SpeciesBibarel.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bibarel Builder only waiting for a Level
		/// </summary>
		public BibarelInstance(int level)
		: base(
				SpeciesBibarel.Instance, // PokemonInstance Species
				"Bibarel", level,
				Normal.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bibarel Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BibarelInstance() : base(
			SpeciesBibarel.Instance, // PokemonInstance Species
			Normal.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}