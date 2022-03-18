using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Blastoise Species to store common natural stats of all Blastoises
	#region SpeciesBlastoise
	public class SpeciesBlastoise : PokemonSpecies
	{
#nullable enable
		private static SpeciesBlastoise? _instance = null;
#nullable restore
        public static SpeciesBlastoise Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBlastoise();
                }
                return _instance;
            }
        }

		#region SpeciesBlastoise Constructor
		public SpeciesBlastoise() : base(
			9,
			"Blastoise",
			1.6,
			85.5,
			79, // HPs
			83, 100, // Attack & Defense
			85, 105, // Special Attack & Defense
			78		
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
				"Roar",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
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
				"Withdraw",
				"Defense-Curl",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Bubble",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Outrage",
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
				"Hydro-Cannon",
				"Rock-Tomb",
				"Signal-Beam",
				"Iron-Defense",
				"Water-Pulse",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Rock-Climb",
				"Captivate",
				"Smack-Down",
				"Round",
				"Scald",
				"Water-Pledge",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Blastoise PokemonInstance Class
	#region Blastoise
	public class BlastoiseInstance : PokemonInstance
	{
		#region Blastoise Constructors
		/// <summary>
		/// Blastoise Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BlastoiseInstance(string nickname, int level)
		: base(
				SpeciesBlastoise.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blastoise Builder only waiting for a Level
		/// </summary>
		public BlastoiseInstance(int level)
		: base(
				SpeciesBlastoise.Instance, // PokemonInstance Species
				"Blastoise", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blastoise Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BlastoiseInstance() : base(
			SpeciesBlastoise.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}