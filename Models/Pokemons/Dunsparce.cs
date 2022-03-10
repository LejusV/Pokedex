using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dunsparce Species to store common natural stats of all Dunsparces
	#region SpeciesDunsparce
	public class SpeciesDunsparce : PokemonSpecies
	{
#nullable enable
		private static SpeciesDunsparce? _instance = null;
#nullable restore
        public static SpeciesDunsparce Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDunsparce();
                }
                return _instance;
            }
        }

		#region SpeciesDunsparce Constructor
		public SpeciesDunsparce() : base(
			"Dunsparce",
			1.5,
			14.0,
			100, // HPs
			70, 70, // Attack & Defense
			65, 65, // Special Attack & Defense
			45		
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
				"Bind",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Fire-Blast",
				"Glare",
				"Dream-Eater",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Flail",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Magic-Coat",
				"Yawn",
				"Endeavor",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Gyro-Ball",
				"Natural-Gift",
				"Trump-Card",
				"Last-Resort",
				"Poison-Jab",
				"Aqua-Tail",
				"Air-Slash",
				"Dragon-Rush",
				"Zen-Headbutt",
				"Captivate",
				"Stealth-Rock",
				"Charge-Beam",
				"Coil",
				"Round",
				"Hex",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Wild-Charge",
				"Drill-Run",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Dunsparce PokemonInstance Class
	#region Dunsparce
	public class DunsparceInstance : PokemonInstance
	{
		#region Dunsparce Constructors
		/// <summary>
		/// Dunsparce Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DunsparceInstance(string nickname, int level)
		: base(
				206,
				SpeciesDunsparce.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dunsparce Builder only waiting for a Level
		/// </summary>
		public DunsparceInstance(int level)
		: base(
				206,
				SpeciesDunsparce.Instance, // PokemonInstance Species
				"Dunsparce", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dunsparce Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Dunsparce() : base(
			206,
			SpeciesDunsparce.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}