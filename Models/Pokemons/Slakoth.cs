using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Slakoth Species to store common natural stats of all Slakoths
	#region SpeciesSlakoth
	public class SpeciesSlakoth : PokemonSpecies
	{
#nullable enable
		private static SpeciesSlakoth? _instance = null;
#nullable restore
        public static SpeciesSlakoth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSlakoth();
                }
                return _instance;
            }
        }

		#region SpeciesSlakoth Constructor
		public SpeciesSlakoth() : base(
			287,
			"Slakoth",
			0.8,
			24.0,
			60, // HPs
			60, 60, // Attack & Defense
			35, 35, // Special Attack & Defense
			30		
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
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Fire-Blast",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
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
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Yawn",
				"Secret-Power",
				"Slack-Off",
				"Crush-Claw",
				"Rock-Tomb",
				"Tickle",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Sucker-Punch",
				"Night-Slash",
				"Shadow-Claw",
				"Gunk-Shot",
				"Captivate",
				"Hone-Claws",
				"After-You",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Play-Rough",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Slakoth PokemonInstance Class
	#region Slakoth
	public class SlakothInstance : PokemonInstance
	{
		#region Slakoth Constructors
		/// <summary>
		/// Slakoth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SlakothInstance(string nickname, int level)
		: base(
				SpeciesSlakoth.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slakoth Builder only waiting for a Level
		/// </summary>
		public SlakothInstance(int level)
		: base(
				SpeciesSlakoth.Instance, // PokemonInstance Species
				"Slakoth", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slakoth Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SlakothInstance() : base(
			SpeciesSlakoth.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}