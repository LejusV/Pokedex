using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Slaking Species to store common natural stats of all Slakings
	#region SlakingSpecies
	public class SlakingSpecies : PokemonSpecies
	{
#nullable enable
		private static SlakingSpecies? _instance = null;
#nullable restore
        public static SlakingSpecies Instance => _instance ?? (_instance = new SlakingSpecies());

		#region SlakingSpecies Constructor
		public SlakingSpecies() : base(
			289,
			"Slaking",
			Normal.Instance,
			2.0,
			130.5,
			new PokemonStats(
				150, // HPs
				160, 100, // Attack & Defense
				95, 65, // Spacial Attack & Defense
				100 // Speed
			)			
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
}