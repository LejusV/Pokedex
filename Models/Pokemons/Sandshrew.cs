using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sandshrew Species to store common natural stats of all Sandshrews
	#region SpeciesSandshrew
	public class SpeciesSandshrew : PokemonSpecies
	{
#nullable enable
		private static SpeciesSandshrew? _instance = null;
#nullable restore
        public static SpeciesSandshrew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSandshrew();
                }
                return _instance;
            }
        }

		#region SpeciesSandshrew Constructor
		public SpeciesSandshrew() : base(
			"Sandshrew",
			0.6,
			12.0,
			50, // HPs
			75, 85, // Attack & Defense
			20, 30, // Special Attack & Defense
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Magnitude",
				"Dynamic-Punch",
				"Rapid-Spin",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Crush-Claw",
				"Rock-Tomb",
				"Sand-Tomb",
				"Aerial-Ace",
				"Mud-Shot",
				"Covet",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Earth-Power",
				"Shadow-Claw",
				"Rock-Climb",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Bulldoze",
				"Rototiller",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Sandshrew PokemonInstance Class
	#region Sandshrew
	public class SandshrewInstance : PokemonInstance
	{
		#region Sandshrew Constructors
		/// <summary>
		/// Sandshrew Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SandshrewInstance(string nickname, int level)
		: base(
				27,
				SpeciesSandshrew.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandshrew Builder only waiting for a Level
		/// </summary>
		public SandshrewInstance(int level)
		: base(
				27,
				SpeciesSandshrew.Instance, // PokemonInstance Species
				"Sandshrew", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandshrew Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Sandshrew() : base(
			27,
			SpeciesSandshrew.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}