using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Wartortle Species to store common natural stats of all Wartortles
	#region SpeciesWartortle
	public class SpeciesWartortle : PokemonSpecies
	{
#nullable enable
		private static SpeciesWartortle? _instance = null;
#nullable restore
        public static SpeciesWartortle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWartortle();
                }
                return _instance;
            }
        }

		#region SpeciesWartortle Constructor
		public SpeciesWartortle() : base(
			"Wartortle",
			1.0,
			22.5,
			59, // HPs
			63, 80, // Attack & Defense
			65, 80, // Special Attack & Defense
			58		
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
				"Mega-Punch",
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Bite",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Withdraw",
				"Defense-Curl",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Rapid-Spin",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Iron-Defense",
				"Water-Pulse",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Zen-Headbutt",
				"Captivate",
				"Round",
				"Scald",
				"Water-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Wartortle PokemonInstance Class
	#region Wartortle
	public class WartortleInstance : PokemonInstance
	{
		#region Wartortle Constructors
		/// <summary>
		/// Wartortle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WartortleInstance(string nickname, int level)
		: base(
				8,
				SpeciesWartortle.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wartortle Builder only waiting for a Level
		/// </summary>
		public WartortleInstance(int level)
		: base(
				8,
				SpeciesWartortle.Instance, // PokemonInstance Species
				"Wartortle", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wartortle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Wartortle() : base(
			8,
			SpeciesWartortle.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}