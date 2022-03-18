using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zigzagoon Species to store common natural stats of all Zigzagoons
	#region SpeciesZigzagoon
	public class SpeciesZigzagoon : PokemonSpecies
	{
#nullable enable
		private static SpeciesZigzagoon? _instance = null;
#nullable restore
        public static SpeciesZigzagoon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZigzagoon();
                }
                return _instance;
            }
        }

		#region SpeciesZigzagoon Constructor
		public SpeciesZigzagoon() : base(
			263,
			"Zigzagoon",
			0.4,
			17.5,
			38, // HPs
			30, 41, // Attack & Defense
			30, 41, // Special Attack & Defense
			60		
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
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Pin-Missile",
				"Growl",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Extreme-Speed",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Secret-Power",
				"Mud-Sport",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Tickle",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Seed-Bomb",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Simple-Beam",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Bestow",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Zigzagoon PokemonInstance Class
	#region Zigzagoon
	public class ZigzagoonInstance : PokemonInstance
	{
		#region Zigzagoon Constructors
		/// <summary>
		/// Zigzagoon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZigzagoonInstance(string nickname, int level)
		: base(
				SpeciesZigzagoon.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zigzagoon Builder only waiting for a Level
		/// </summary>
		public ZigzagoonInstance(int level)
		: base(
				SpeciesZigzagoon.Instance, // PokemonInstance Species
				"Zigzagoon", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zigzagoon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ZigzagoonInstance() : base(
			SpeciesZigzagoon.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}