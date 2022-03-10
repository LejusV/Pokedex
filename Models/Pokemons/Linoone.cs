using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Linoone Species to store common natural stats of all Linoones
	#region SpeciesLinoone
	public class SpeciesLinoone : PokemonSpecies
	{
#nullable enable
		private static SpeciesLinoone? _instance = null;
#nullable restore
        public static SpeciesLinoone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLinoone();
                }
                return _instance;
            }
        }

		#region SpeciesLinoone Constructor
		public SpeciesLinoone() : base(
			"Linoone",
			0.5,
			32.5,
			78, // HPs
			70, 61, // Attack & Defense
			50, 61, // Special Attack & Defense
			100		
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
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Roar",
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
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Super-Fang",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Belly-Drum",
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
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Seed-Bomb",
				"Switcheroo",
				"Giga-Impact",
				"Shadow-Claw",
				"Gunk-Shot",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Bestow",
				"Work-Up",
				"Rototiller",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Linoone PokemonInstance Class
	#region Linoone
	public class LinooneInstance : PokemonInstance
	{
		#region Linoone Constructors
		/// <summary>
		/// Linoone Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LinooneInstance(string nickname, int level)
		: base(
				264,
				SpeciesLinoone.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Linoone Builder only waiting for a Level
		/// </summary>
		public LinooneInstance(int level)
		: base(
				264,
				SpeciesLinoone.Instance, // PokemonInstance Species
				"Linoone", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Linoone Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Linoone() : base(
			264,
			SpeciesLinoone.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}