using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Slaking Species to store common natural stats of all Slakings
	#region SpeciesSlaking
	public class SpeciesSlaking : PokemonSpecies
	{
#nullable enable
		private static SpeciesSlaking? _instance = null;
#nullable restore
        public static SpeciesSlaking Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSlaking();
                }
                return _instance;
            }
        }

		#region SpeciesSlaking Constructor
		public SpeciesSlaking() : base(
			289,
			"Slaking",
			2.0,
			130.5,
			150, // HPs
			160, 100, // Attack & Defense
			95, 65, // Special Attack & Defense
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Fire-Blast",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Brick-Break",
				"Yawn",
				"Secret-Power",
				"Slack-Off",
				"Rock-Tomb",
				"Aerial-Ace",
				"Block",
				"Bulk-Up",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Punishment",
				"Sucker-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"Hone-Claws",
				"Smack-Down",
				"Low-Sweep",
				"After-You",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Quash",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Slaking PokemonInstance Class
	#region Slaking
	public class SlakingInstance : PokemonInstance
	{
		#region Slaking Constructors
		/// <summary>
		/// Slaking Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SlakingInstance(string nickname, int level)
		: base(
				SpeciesSlaking.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slaking Builder only waiting for a Level
		/// </summary>
		public SlakingInstance(int level)
		: base(
				SpeciesSlaking.Instance, // PokemonInstance Species
				"Slaking", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slaking Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SlakingInstance() : base(
			SpeciesSlaking.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}