using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Squirtle Species to store common natural stats of all Squirtles
	#region SpeciesSquirtle
	public class SpeciesSquirtle : PokemonSpecies
	{
#nullable enable
		private static SpeciesSquirtle? _instance = null;
#nullable restore
        public static SpeciesSquirtle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSquirtle();
                }
                return _instance;
            }
        }

		#region SpeciesSquirtle Constructor
		public SpeciesSquirtle() : base(
			7,
			"Squirtle",
			0.5,
			9.0,
			44, // HPs
			48, 65, // Attack & Defense
			50, 64, // Special Attack & Defense
			43		
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
				"Mist",
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
				"Confusion",
				"Rage",
				"Mimic",
				"Double-Team",
				"Withdraw",
				"Defense-Curl",
				"Haze",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Foresight",
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
				"Mirror-Coat",
				"Rock-Smash",
				"Whirlpool",
				"Fake-Out",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Yawn",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Water-Spout",
				"Muddy-Water",
				"Iron-Defense",
				"Water-Pulse",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Aqua-Ring",
				"Aura-Sphere",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Zen-Headbutt",
				"Captivate",
				"Aqua-Jet",
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

	//Squirtle PokemonInstance Class
	#region Squirtle
	public class SquirtleInstance : PokemonInstance
	{
		#region Squirtle Constructors
		/// <summary>
		/// Squirtle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SquirtleInstance(string nickname, int level)
		: base(
				SpeciesSquirtle.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Squirtle Builder only waiting for a Level
		/// </summary>
		public SquirtleInstance(int level)
		: base(
				SpeciesSquirtle.Instance, // PokemonInstance Species
				"Squirtle", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Squirtle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SquirtleInstance() : base(
			SpeciesSquirtle.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}